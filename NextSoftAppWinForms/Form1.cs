using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using NextSoftAppWinForms.Model;

namespace NextSoftAppWinForms
{
    public partial class Form1 : Form
    {
        string textoID = "Digite o ID aqui";

        public Form1 ()
        {
            InitializeComponent();

            cbListagem.Items.Add("Condominio");
            cbListagem.Items.Add("Familia");
            cbListagem.Items.Add("Morador");
            cbListagem.Text = "Condominio";
        }

        private async void GetAllAsync ()
        {
            string urlAPI = $"{txtURL.Text}/{cbListagem.SelectedItem}";

            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync(urlAPI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        dataGridView.DataSource = JsonConvert.DeserializeObject<Generica[]>(jsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Falhou, Status HTTP: " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetIdAsync (int id)
        {
            string urlAPI= $"{txtURL.Text}/{cbListagem.SelectedItem}/{id}".ToString();

            using (var cliente = new HttpClient())
            {
                BindingSource dados = new BindingSource();

                HttpResponseMessage response = await cliente.GetAsync(urlAPI);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dados.DataSource = JsonConvert.DeserializeObject<Generica>(jsonString);
                    dataGridView.DataSource = dados;
                }
                else
                {
                    MessageBox.Show("Falhou, Status HTTP: " + response.StatusCode);
                }
            }
        }

        private async void PostAsync (Generica dados)
        {
            string urlAPI = $"{txtURL.Text}/{cbListagem.SelectedItem}";

            using (var cliente = new HttpClient())
            {
                var serializacao = JsonConvert.SerializeObject(dados);
                var conteudo = new StringContent(serializacao, Encoding.UTF8, "application/json");
                var result = await cliente.PostAsync(urlAPI, conteudo);
            }

            GetAllAsync();
        }

        private async void PutAsync(Generica dados)
        {
            string urlAPI = $"{txtURL.Text}/{cbListagem.SelectedItem}/{dados.Id}".ToString();

            if (dados.Id == 0)
            {
                MessageBox.Show("Escolha um id maior que 0 para alteração.","Atenção!");
                return;
            }

            using (var cliente = new HttpClient())
            {
                var conteudo = JsonConvert.SerializeObject(dados);
                var response = await cliente.PutAsync(urlAPI, new StringContent(conteudo, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Atualização concluída.");
                else
                    MessageBox.Show($"Falhou, Status HTTP: {response.StatusCode}", "Atenção!");
            }

            GetAllAsync();
        }

        private async void DeleteAsync (int id)
        {
            string urlAPI = $"{txtURL.Text}/{cbListagem.SelectedItem}/{id}".ToString();

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(urlAPI);

                var confirmarExclusao = MessageBox.Show($"Tem certeza que deseja apagar o Id {id} do end point {cbListagem.SelectedItem}?", "Deleção de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirmarExclusao == DialogResult.Yes)
                {
                    HttpResponseMessage response = await cliente.DeleteAsync(urlAPI);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Id {id} excluído com sucesso.");
                        GetAllAsync();
                    }
                    else
                        MessageBox.Show($"Falhou, Status Code: " + response.StatusCode);
                }
            }
        }

        private int Validador (string txtURL)
        {
            var divisaoURL = txtURL.Split('/');
            bool resultadoURL = Int32.TryParse(divisaoURL[divisaoURL.Length - 1], out int idURL);

            if (idURL == 0 || !resultadoURL)
            {
                MessageBox.Show("Coloque um número no campo id e que seja maior que 0.", "Atenção");
                return 0;
            }

            return idURL;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtID.Text = string.Empty;
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            GetAllAsync();
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            int resultado = Validador(txtID.Text);

            if (resultado != 0)
                GetIdAsync (resultado);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
                txtID.Text = textoID;
        }

        private void btnDeleteId_Click(object sender, EventArgs e)
        {
            int resultado = Validador(txtID.Text);

            if (resultado != 0)
                DeleteAsync (resultado);
        }

        private void btnPost_Click(object sender, EventArgs e)
        { 
            CadastroDados cadastro = new CadastroDados();
            cadastro.TipoRequisicao = "Post";
            cadastro.ShowDialog();

            Generica dados = new Generica()
            {
                Id = cadastro.Id,
                Nome = cadastro.Nome,
                Bairro = cadastro.Bairro,
                Idade = cadastro.Idade,
                Apto = cadastro.Apto,
                Id_Familia = cadastro.Id_Familia,
                Id_Condominio = cadastro.Id_Condominio
            };

            PostAsync(dados);
        }

        private void btnPutId_Click(object sender, EventArgs e)
        {
            CadastroDados alteracao = new CadastroDados();
            alteracao.TipoRequisicao = "Put";
            alteracao.ShowDialog();

            Generica dados = new Generica()
            {
                Id = alteracao.Id,
                Nome = alteracao.Nome,
                Bairro = alteracao.Bairro,
                Idade = alteracao.Idade,
                Apto = alteracao.Apto,
                Id_Familia = alteracao.Id_Familia,
                Id_Condominio = alteracao.Id_Condominio
            };

            PutAsync(dados);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a aplicação?",
                "Fechar",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }
    }
}
