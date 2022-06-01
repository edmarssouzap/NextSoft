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
    /// Endpoint Familia
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        private readonly NextSoftAPIDataContext db;

        /// <summary>
        /// Construtor de Familia
        /// </summary>
        /// <param name="db">DataContext</param>
        public FamiliaController (NextSoftAPIDataContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Lista todos as familias
        /// </summary>
        /// <returns>Lista de familias</returns>
        [HttpGet]
        public async Task<ActionResult<List<Familia>>> ObterListaAsync()
        {
            var listaFamilia = await db.Familia.ToListAsync();

            if (listaFamilia == null)
            {
                return BadRequest(listaFamilia);
            }

            return Ok(listaFamilia);
        }

        /// <summary>
        /// Obtem dados de uma especifica familia
        /// </summary>
        /// <param name="id">Id da familia</param>
        /// <returns>Retorna um JSON com os dados de familia</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Familia>> ObterIdAsync(int id)
        {
            var idFamilia = await db.Familia.FindAsync(id);

            if (idFamilia == null)
            {
                return NotFound(idFamilia);
            }

            return Ok(idFamilia);
        }

        /// <summary>
        /// Adiciona informações no banco de dados
        /// </summary>
        /// <param name="familia">Obtem dados coletados de uma familia</param>
        /// <returns>Status de operação sucedida e retorna os dados enviados</returns>
        [HttpPost("")]
        public async Task<ActionResult<Familia>> CriarAsync([FromBody] Familia familia)
        {
            var idFamilia = await db.Familia.FindAsync(familia.Id);

            if (idFamilia != null)
                return BadRequest();

            if (ModelState.IsValid && familia.Id == 0)
            {
                try
                {
                    db.Familia.Add(familia);
                    await db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }

                return Ok(familia);
            }

            return BadRequest(familia);
        }

        /// <summary>
        /// Atualiza dados de uma familia
        /// </summary>
        /// <param name="id">Id da familia</param>
        /// <param name="familia">Dados para atualizar de familia</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Familia>> AtualizarAsync(int id, [FromBody] Familia familia)
        {
            var validacaoModel = TryValidateModel(familia);
            var idFamilia = await db.Familia.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (!validacaoModel || idFamilia == null)
                return BadRequest(familia);

            try
            {
                db.Familia.Update(familia);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

            return Ok();
        }

        /// <summary>
        /// Deleta uma familia do banco de dados
        /// </summary>
        /// <param name="id">Id da familia</param>
        /// <returns>Retorna status de operacao sucedida</returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Familia>> DeletarAsync(int id)
        {
            var idFamilia = await db.Familia.FindAsync(id);

            if (idFamilia == null)
                return NotFound();

            db.Familia.Remove(idFamilia);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
