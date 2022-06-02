using System;
using System.Windows.Forms;

namespace NextSoftAppWinForms
{
    public partial class CadastroDados : Form
    {
        /// <summary>
        /// Variavel para verificar qual sera o tipo de requisicao: POST ou PUT
        /// </summary>
        public string TipoRequisicao { get; set; }
        
        /// <summary>
        /// Mapea algumas propriedades do form cadastro para envio da requisicao
        /// </summary>
        public int Id { get { return int.Parse(txtID.Text); } }
        public string Nome { get { return txtNome.Text; } }
        public string Bairro { get { return txtBairro.Text; } }
        public int Idade { get { return int.Parse(txtIdade.Text); } }
        public int Apto { get { return int.Parse(txtApto.Text); } }
        public int Id_Condominio { get { return int.Parse(txtCondominio.Text); } }
        public int Id_Familia { get { return int.Parse(txtFamilia.Text); } }

        public CadastroDados()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty ||
                txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha os campos para enviar os dados.", "Atenção!");
                return;
            }

            Close();
        }

        /// <summary>
        /// Verifica se o pedido sera do tipo Post ou Put para trocar titulo e campo de id
        /// </summary>
        private void CadastroDados_Load(object sender, EventArgs e)
        {
            switch (TipoRequisicao)
            {
                case "Post":
                    lbTitulo.Text = "Criacao de dados";
                    lbID.Visible = false;
                    txtID.Visible = false;
                    break;

                case "Put":
                    lbTitulo.Text = "Alteração de dados";
                    lbID.Visible = true;
                    txtID.Visible = true;
                    break;
            }
        }
    }
}
