using System;

class Introdução{

    static void Main(){

        MoedaAtual();
    }
    static void MoedaAtual(){

        Console.Clear();
        Console.WriteLine("Converta seus valores monetarios");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Qual a moeda atual ?");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dóla");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Iene");
        Console.WriteLine("5 - Sair");

        string res = Console.ReadLine();

        switch (res){
            
            case "1": Real(); break;
            case "2": Dóla(); break;
            case "3": Euro(); break;
            case "4": Iene(); break;
            case "5": System.Environment.Exit(0); break;
            default: MoedaAtual(); break;
        }
    }
    static void Real(){
        
        Console.Clear();
        Console.WriteLine("Qual o valor da moeda atual ?");
        string VA = Console.ReadLine();
        decimal va = decimal.Parse(VA);

        Console.Clear();
        Console.WriteLine("Qual a moeda desejada ?");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dóla");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Iene");
        Console.WriteLine("5 - Sair");

        string res = Console.ReadLine();
        decimal M =0;
        string moeda = "";

        switch (res){
            case "1": M = va; moeda = "Real"; break;
            case "2": M = va * 0.1721m; moeda = "Dóla"; break;
            case "3": M = va * 0.16381m; moeda = "Euro"; break;
            case "4": M = va * 25.53247m; moeda = "Iene"; break;
            case "5": System.Environment.Exit(0); break;
            default:Real(); break;
        }
        Console.Clear();
        Console.WriteLine("Valor da moeda atual (Real): ${0}", va.ToString("N2"));
        Console.WriteLine("Valor da moeda desejada ({0}): ${1}", moeda, M.ToString("N2"));
        Console.WriteLine("Fazer outro calculo ? (s/n)");

        string continuar = Console.ReadLine();
        if (continuar == "s"){
            MoedaAtual();
        }else{
            System.Environment.Exit(0);
        }
    }
        static void Dóla(){
        
        Console.Clear();
        Console.WriteLine("Qual o valor da moeda atual ?");
        string VA = Console.ReadLine();
        decimal va = decimal.Parse(VA);

        Console.Clear();
        Console.WriteLine("Qual a moeda desejada ?");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dóla");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Iene");
        Console.WriteLine("5 - Sair");

        string res = Console.ReadLine();
        decimal M =0;
        string moeda = "";

        switch (res){
            case "1": M = va / 0.1721m; moeda = "Real"; break;
            case "2": M = va; moeda = "Dóla"; break;
            case "3": M = va * 0.9454m; moeda = "Euro"; break;
            case "4": M = va * 149.76m; moeda = "Iene"; break;
            case "5": System.Environment.Exit(0); break;
            default:Dóla(); break;
        }
        Console.Clear();
        Console.WriteLine("Valor da moeda atual (Dóla): ${0}", va.ToString("N2"));
        Console.WriteLine("Valor da moeda desejada ({0}): ${1}", moeda, M.ToString("N2"));
        Console.WriteLine("Fazer outro calculo ? (s/n)");

        string continuar = Console.ReadLine();
        if (continuar == "s"){
            MoedaAtual();
        }else{
            System.Environment.Exit(0);
            }
        }

        static void Euro(){
        
        Console.Clear();
        Console.WriteLine("Qual o valor da moeda atual ?");
        string VA = Console.ReadLine();
        decimal va = decimal.Parse(VA);

        Console.Clear();
        Console.WriteLine("Qual a moeda desejada ?");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dóla");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Iene");
        Console.WriteLine("5 - Sair");

        string res = Console.ReadLine();
        decimal M =0;
        string moeda = "";

        switch (res){
            case "1": M = va / 0.16381m; moeda = "Real"; break;
            case "2": M = va / 0.9454m; moeda = "Dóla"; break;
            case "3": M = va; moeda = "Euro"; break;
            case "4": M = va * 0.0063m; moeda = "Iene"; break;
            case "5": System.Environment.Exit(0); break;
            default:Euro(); break;
        }
        Console.Clear();
        Console.WriteLine("Valor da moeda atual (Euro): ${0}", va.ToString("N2"));
        Console.WriteLine("Valor da moeda desejada ({0}): ${1}", moeda, M.ToString("N2"));
        Console.WriteLine("Fazer outro calculo ? (s/n)");

        string continuar = Console.ReadLine();
        if (continuar == "s"){
            MoedaAtual();
        }else{
            System.Environment.Exit(0);
        }
    }
        static void Iene(){
        
        Console.Clear();
        Console.WriteLine("Qual o valor da moeda atual ?");
        string VA = Console.ReadLine();
        decimal va = decimal.Parse(VA);

        Console.Clear();
        Console.WriteLine("Qual a moeda desejada ?");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dóla");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Iene");
        Console.WriteLine("5 - Sair");

        string res = Console.ReadLine();
        decimal M =0;
        string moeda = "";

        switch (res){
            case "1": M = va / 25.53247m; moeda = "Real"; break;
            case "2": M = va / 149.76m; moeda = "Dóla"; break;
            case "3": M = va / 0.0063m; moeda = "Euro"; break;
            case "4": M = va; moeda = "Iene"; break;
            case "5": System.Environment.Exit(0); break;
            default:Iene(); break;
        }
        Console.Clear();
        Console.WriteLine("Valor da moeda atual (Iene): ${0}", va.ToString("N2"));
        Console.WriteLine("Valor da moeda desejada ({0}): ${1}", moeda, M.ToString("N2"));
        Console.WriteLine("Fazer outro calculo ? (s/n)");

        string continuar = Console.ReadLine();
        if (continuar == "s"){
            MoedaAtual();
        }else{
            System.Environment.Exit(0);
        }
    }
}