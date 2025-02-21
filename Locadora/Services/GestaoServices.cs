﻿using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        private List<Filme> _filme = Armazenamento.Filme;
        private List<Serie> _serie = Armazenamento.Serie;
        public void Cadastrar()
        {
            //Console.WriteLine("O que deseja cadastrar?");
            //Console.WriteLine("1 - Filme");
            //Console.WriteLine("2 - Série");
            //Console.WriteLine("Qualquer outro número para voltar");

            //int respotas = int.Parse(Console.ReadLine());
            //if (respotas == 1)
            //{
            //    CadastrarFilme();
            //}
            //if (respotas == 2)
            //{
            //    CadastrarSerie();
            //}
        }

        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme();
            filme.Titulo = filmeRecebido.Titulo;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;
            filme.Duracao = filmeRecebido.Duracao;

            _filme.Add(filme);

            return filme;
        }

       

        public List<Filme> ListarFilme()
        {
                return Armazenamento.Filme
                    .OrderBy(filme => filme.Titulo)
                    .ThenBy(filme => filme.Quantidade)
                    .ThenBy(filme => filme.Valor)
                    .ThenBy(filme => filme.Duracao)
                    .ToList();
         
        }

        public void CadastrarFilme()
        {
            Filme filme = new Filme();

            Console.WriteLine("Qual o nome do filme que deseja cadastrar?");
            filme.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos fitas deste filme existem?");
            filme.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste filme?");
            filme.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a duração do filme?");
            filme.Duracao = int.Parse(Console.ReadLine());

            _filme.Add(filme);
        } 

        public List<Serie> ListarSerie()
        {
            return Armazenamento.Serie
                    .OrderBy(filme => filme.Titulo)
                    .ThenBy(filme => filme.Quantidade)
                    .ThenBy(filme => filme.Valor)
                    .ThenBy(filme => filme.Temporadas)
                    .ToList();
        }

        public Serie CadastrarSerie(SerieViewModel serieRecebido)
        {
            Serie serie = new Serie();
            serie.Titulo = serieRecebido.Titulo;
            serie.Quantidade = serieRecebido.Quantidade;
            serie.Valor = serieRecebido.Valor;
            serie.Temporadas = serieRecebido.Temporadas;

            _serie.Add(serie);

            return serie;
        }
        public void CadastrarSerie()
        {
            Serie serie = new Serie();

            Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            serie.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos cópias desta série existem?");
            serie.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste séries?");
            serie.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas temporadas tem esta série?");
            serie.Temporadas = int.Parse(Console.ReadLine());

            _serie.Add(serie);
        }
        public List<object> ListarItens()
        {
            List<object> listaQueVaiSerRetornada = new List<object>();

            listaQueVaiSerRetornada.AddRange(_filme);
            listaQueVaiSerRetornada.AddRange(_serie);

            return listaQueVaiSerRetornada;
        }
    }
}
