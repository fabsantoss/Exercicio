using System;
using System.Collections.Generic;
using System.IO;

namespace TODOList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todoitem> TODOList = new List<Todoitem>();
            string  fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try{
                string[] todofile = File.ReadAllLines(filePath);

                foreach (var line in todofile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"","");
                    string nota = itens[1].Replace("\"","");

                    Todoitem todoitem = new Todoitem(titulo, nota);
                    TODOList.Add(todoitem);
                }

            } catch(IOException ioe){
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao = 0;

            do {
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(TODOList);
                System.Console.WriteLine("Digite uma opção:");
                System.Console.WriteLine("1 - Adicionar Item");
                System.Console.WriteLine("2 - Remover Item");
                System.Console.WriteLine("3 - Sair do programa");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                    /**
                    * TODO: Método de adicionar itens à lista 
                     */
                    break;
                    case 2:
                    /**
                    * TODO: Método de remover itens à lista 
                     */
                    break;
                    case 3:
                    System.Console.WriteLine("Tchau!");
                    break;
                    default:
                    System.Console.WriteLine("opção invalida");
                    Console.ReadLine();

                    break;
                }
            }while(opcao != 3);



        }

        public static void ListaItens(List<Todoitem> todoList)
        {
            Console.Clear();
            int count =1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Titulo{"",12} Notas");
            foreach (Todoitem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
            }
            
        }

        public static void AddItem(List<Todoitem> todoList)
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item: ");
            System.Console.WriteLine();
            System.Console.WriteLine("Titulo");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Notas: ");
            string nota = Console.ReadLine();
            Todoitem item = new Todoitem(titulo, nota);

            todoList.Add(item);

        }
    }
}