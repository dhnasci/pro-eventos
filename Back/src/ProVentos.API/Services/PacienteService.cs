using System;
using System.Collections.Generic;
using ProVentos.API.Models;
using ProVentos.API.Repositories;

namespace ProVentos.API.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _pacienteRepository.ObterTodos();
        }

        public Paciente ObterPorId(int id)
        {
            return _pacienteRepository.ObterPorId(id);
        }

        public bool Adicionar(Paciente paciente)
        {
            paciente.Criacao = DateTime.UtcNow;
            paciente.Ativo = true;
            _pacienteRepository.Adicionar(paciente);
            return _pacienteRepository.SalvarAlteracoes();
        }

        public bool Atualizar(int id, Paciente paciente)
        {
            var pacienteExistente = _pacienteRepository.ObterPorId(id);
            if (pacienteExistente == null)
                return false;

            // Atualiza os campos que podem ser alterados
            pacienteExistente.Nome = paciente.Nome;
            pacienteExistente.Telefone = paciente.Telefone;
            pacienteExistente.Endereco = paciente.Endereco;
            pacienteExistente.CPF = paciente.CPF;
            pacienteExistente.Bairro = paciente.Bairro;
            pacienteExistente.Cidade = paciente.Cidade;
            pacienteExistente.SiglaEstado = paciente.SiglaEstado;
            pacienteExistente.Anamnese = paciente.Anamnese;
            pacienteExistente.Ativo = paciente.Ativo;
            pacienteExistente.Alteracao = DateTime.UtcNow;

            _pacienteRepository.Atualizar(pacienteExistente);
            return _pacienteRepository.SalvarAlteracoes();
        }

        public bool Remover(int id)
        {
            var pacienteExistente = _pacienteRepository.ObterPorId(id);
            if (pacienteExistente == null)
                return false;

            _pacienteRepository.Remover(pacienteExistente);
            return _pacienteRepository.SalvarAlteracoes();
        }
    }
}
