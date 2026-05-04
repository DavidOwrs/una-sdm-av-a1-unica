using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324155606.Data;
using ValeAtivos324155606.Models;

namespace ValeAtivos324155606.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EquipamentoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipamento>>> GetEquipamento()
        {
            return await _context.Equipamentos.ToListAsync();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Equipamento>>GetEquipamento(int id)
        {
            var Equipamento = await _context.Equipamentos.FindAsync(id);

            if (Equipamento == null) return NotFound();

            return Equipamento;
        }
        [HttpPost]
        public async Task<ActionResult<Equipamento>>PostEquipamento(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof (GetEquipamento), new {id = equipamento.Id},equipamento);
        }
    }
}