using System.Collections.Generic;
using ProVentos.API.Models;

namespace ProVentos.API.Services
{
    public interface IPacienteService
    {
        IEnumerable<Paciente> ObterTodos();
        Paciente ObterPorId(int id);
        bool Adicionar(Paciente paciente);
        bool Atualizar(int id, Paciente paciente);
        bool Remover(int id);
    }
}
