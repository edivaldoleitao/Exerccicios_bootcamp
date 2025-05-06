﻿using Cadastro_series.Classes;

#pragma warning disable CS8602


// exibir por genero
string opcao = string.Empty;


SeriesRepositorio seriesrep = new SeriesRepositorio();
Fachada fachada = new Fachada(seriesrep);

while (opcao != "X")
{
    System.Console.WriteLine("");
    System.Console.WriteLine("Cadastro de séries");
    System.Console.WriteLine("Informe a opção desejada: ");
    System.Console.WriteLine("1 - Listar Séries");
    System.Console.WriteLine("2 - Inserir nova série");
    System.Console.WriteLine("3 - Atualizar Série");
    System.Console.WriteLine("4 - Excluir Série");
    System.Console.WriteLine("5 - Exibir Série");
    System.Console.WriteLine("6 - Listar séries por nota");
    System.Console.WriteLine("7 - exibir por gênero");
    System.Console.WriteLine("C - Limpar Tela");
    System.Console.WriteLine("X - Sair");


    opcao = Console.ReadLine().ToUpper();


    switch (opcao)
    {
        case "1":
            fachada.Listar();
            break;
        case "2":
            fachada.Inserir();
            break;
        case "3":
            fachada.Atualizar();
            break;
        case "4":
            fachada.Excluir();
            break;
        case "5":
            fachada.ExibirSerie();
            break;
        case "6":
            fachada.ExibirPorNota();
            break;

        case "7":
            fachada.ExibirPorGenero();
            break;
        case "C":
            Console.Clear();
            break;
        case "X":
            break;
        default:
            System.Console.WriteLine("opção inválida");
            break;
    }
}
