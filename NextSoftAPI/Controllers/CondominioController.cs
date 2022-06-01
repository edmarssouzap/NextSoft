using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NextSoftAPI.Data;
using NextSoftAPI.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace NextSoftAPI.Controllers
{
    /// <summary>
    /// Endpoint Condominio
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CondominioController : ControllerBase
    {
        private readonly NextSoftAPIDataContext db;

        /// <summary>
        /// Construtor de Condominio
        /// </summary>
        /// <param name="db">DataContext</param>
        public CondominioController (NextSoftAPIDataContext db)
        {
            this.db = db;
        }
        
        /// <summary>
        /// Lista todos os condominios
        /// </summary>
        /// <returns>Lista de condominio</returns>
        [HttpGet("")]
        public async Task<ActionResult<List<Condominio>>> ObterListaAsync()
        {
            var listaCondominio = await db.Condominio.ToListAsync();

            if (listaCondominio == null)
            {
                return BadRequest(listaCondominio);
            }

            return Ok(listaCondominio);
        }

        /// <summary>
        /// Obtem dados de um especifico condominio
        /// </summary>
        /// <param name="id">Id do condominio</param>
        /// <returns>Retorna um JSON com os dados de Condominio</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Condominio>> ObterIdAsync(int id)
        {
            var idCondominio = await db.Condominio.FindAsync(id);

            if (idCondominio == null)
            {
                return NotFound(idCondominio);
            }

            return Ok(idCondominio);
        }

        /// <summary>
        /// Adiciona informações no banco de dados
        /// </summary>
        /// <param name="condominio">Obtem dados coletados de um condominio</param>
        /// <returns>Status de operação sucedida e retorna os dados enviados</returns>
        [HttpPost("")]
        public async Task<ActionResult<Condominio>> CriarAsync([FromBody] Condominio condominio)
        {
            var idCondominio = await db.Condominio.FindAsync(condominio.Id);

            if (idCondominio != null)
                return BadRequest();

            if (ModelState.IsValid && condominio.Id == 0)
            {
                try
                {
                    db.Condominio.Add(condominio);
                    await db.SaveChangesAsync();
                }
                catch(Exception)
                {
                    return StatusCode(500);
                }

                return Ok(condominio);
            }

            return BadRequest(condominio);
        }

        /// <summary>
        /// Atualiza dados de um condominio
        /// </summary>
        /// <param name="id">Id do condominio</param>
        /// <param name="condominio">Dados para atualizar de condominio</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Condominio>> AtualizarAsync(int id, [FromBody] Condominio condominio)
        {
            var validacaoModel = TryValidateModel(condominio);
            var idCondominio = await db.Condominio.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (!validacaoModel || idCondominio == null)
                return BadRequest(condominio);
            
            try
            {
                db.Condominio.Update(condominio);
                await db.SaveChangesAsync();
            }
            catch(Exception)
            {
                return StatusCode(500);
            }

            return Ok();
        }

        /// <summary>
        /// Deleta um condominio do banco de dados
        /// </summary>
        /// <param name="id">Id de condominio</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Condominio>> DeletarAsync(int id)
        {
            var idCondominio = await db.Condominio.FindAsync(id);

            if (idCondominio == null)
                return NotFound();

            db.Condominio.Remove(idCondominio);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
