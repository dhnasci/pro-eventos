using System.Collections.Generic;
using ProVentos.API.Models;

namespace ProVentos.API.Repositories
{
    public interface IPacienteRepository
    {
        IEnumerable<Paciente> ObterTodos();
        Paciente ObterPorId(int id);
        void Adicionar(Paciente paciente);
        void Atualizar(Paciente paciente);
        void Remover(Paciente paciente);
        bool SalvarAlteracoes();
    }
}
