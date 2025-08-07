using System.Collections.Generic;
using System.Linq;
using ProVentos.API.Data;
using ProVentos.API.Models;

namespace ProVentos.API.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DataContext _context;

        public PacienteRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObterPorId(int id)
        {
            return _context.Pacientes.FirstOrDefault(p => p.PacienteId == id);
        }

        public void Adicionar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
        }

        public void Atualizar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
        }

        public void Remover(Paciente paciente)
        {
            _context.Pacientes.Remove(paciente);
        }

        public bool SalvarAlteracoes()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
