﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAPi.Data;
using ProjetoAPi.Models;

namespace ProjetoAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Servicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servico>>> GetServicos()
        {
            return await _context.Servicos.ToListAsync();
        }

        // GET: api/Servicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servico>> GetServico(Guid id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            if (servico == null)
            {
                return NotFound();
            }

            return servico;
        }

        // PUT: api/Servicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServico(Guid id, Servico servico)
        {
            if (id != servico.ServicoId)
            {
                return BadRequest();
            }

            _context.Entry(servico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Servicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servico>> PostServico(Servico servico)
        {
            _context.Servicos.Add(servico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServico", new { id = servico.ServicoId }, servico);
        }

        // DELETE: api/Servicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServico(Guid id)
        {
            var servico = await _context.Servicos.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }

            _context.Servicos.Remove(servico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServicoExists(Guid id)
        {
            return _context.Servicos.Any(e => e.ServicoId == id);
        }
        // Adicione este método ao ServicosController

        // GET: api/Servicos/Detalhes
        [HttpGet("Detalhes")]
        public async Task<ActionResult<IEnumerable<object>>> GetServicosDetalhes()
        {
            var servicosDetalhes = await _context.Servicos
                .Select(s => new
                {
                    Nome = s.Nome,
                    Preco = s.Preco,
                    Duracao = s.Duracao
                })
                .ToListAsync();

            return Ok(servicosDetalhes);
        }
    }
}
