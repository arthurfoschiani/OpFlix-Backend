﻿using Senai.OpFlix.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Interfaces
{
    public interface ILancamentoRepository
    {
        Lancamento BuscarPorId(int id);
        List<Lancamento> Listar();
        void Cadastrar(Lancamento lancamento);
        void Atualizar(Lancamento lancamento);
        void Deletar(int id);
        List<Lancamento> FiltrarPorPlataforma(string plataforma);
        List<Lancamento> FiltrarPorCategoria(int categoria);
        List<Lancamento> FiltrarPorDataLancamento(int lancamento);
    }
}
