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
    /// Endpoint Morador
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MoradorController : ControllerBase
    {
        private readonly NextSoftAPIDataContext db;

        /// <summary>
        /// Construtor de Morador
        /// </summary>
        /// <param name="db">DataContext</param>
        public MoradorController (NextSoftAPIDataContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Lista todos os moradores
        /// </summary>
        /// <returns>Lista de morador</returns>
        [HttpGet("")]
        public async Task<ActionResult<List<Morador>>> ObterListaAsync()
        {
            var listaMorador = await db.Morador.ToListAsync();

            if (listaMorador == null)
            {
                return BadRequest(listaMorador);
            }

            return Ok(listaMorador);
        }

        /// <summary>
        /// Obtem dados de um especifico morador
        /// </summary>
        /// <param name="id">Id do morador</param>
        /// <returns>Retorna um JSON com os dados de Morador</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Morador>> ObterIdAsync(int id)
        {
            var idMorador = await db.Morador.FindAsync(id);

            if (idMorador == null)
            {
                return NotFound(idMorador);
            }

            return Ok(idMorador);
        }

        /// <summary>
        /// Adiciona informações no banco de dados
        /// </summary>
        /// <param name="morador">Obtem dados coletados de um morador</param>
        /// <returns>Status de operação sucedida e retorna os dados enviados</returns>
        [HttpPost("")]
        public async Task<ActionResult<Morador>> CriarAsync([FromBody] Morador morador)
        {
            var idMorador = await db.Morador.FindAsync(morador.Id);

            if (idMorador != null)
                return BadRequest();

            if (ModelState.IsValid && morador.Id == 0)
            {
                try
                {
                    db.Morador.Add(morador);
                    await db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }

                return Ok(morador);
            }

            return BadRequest(morador);
        }

        /// <summary>
        /// Atualiza dados de um morador
        /// </summary>
        /// <param name="id">Id do morador</param>
        /// <param name="morador">Dados para atualizar de morador</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Morador>> AtualizarAsync(int id, [FromBody] Morador morador)
        {
            var validacaoModel = TryValidateModel(morador);
            var idMorador = await db.Morador.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (!validacaoModel || idMorador == null)
                return BadRequest(morador);

            try
            {
                db.Morador.Update(morador);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

            return Ok();
        }

        /// <summary>
        /// Deleta um morador do banco de dados
        /// </summary>
        /// <param name="id">Id de morador</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Morador>> DeletarAsync(int id)
        {
            var idMorador = await db.Morador.FindAsync(id);

            if (idMorador == null)
                return NotFound();

            db.Morador.Remove(idMorador);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
