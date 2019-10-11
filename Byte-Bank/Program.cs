using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("ByteBank - Cadastro de Clientes");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Cliente cliente1 = new Cliente(nome,cpf,email);
        Console.WriteLine(cliente1.Senha);
        
        
        bool trocouSenha = false;
        do{
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            trocouSenha = cliente1.TrocaSenha(senha);
            if (trocouSenha){
                Console.WriteLine("Senha alterada com sucesso!");
            } else {
                Console.WriteLine("Senha inválida");
            }
        }while(!trocouSenha);
        Console.WriteLine();

        Console.WriteLine("ByteBank - Cadastro da Conta");
        Console.Write("Entre com a agência: ");
        int agencia = int.Parse(Console.ReadLine());
        Console.Write("Entre com a conta: ");
        int conta = int.Parse(Console.ReadLine());
        

        ContaCorrente contacorrente1 = new ContaCorrente(agencia,conta,cliente1);
        double saldo;
        do{
            Console.WriteLine("Entre com o saldo: ");
            saldo = double.Parse(Console.ReadLine());
            if (!contacorrente1.Deposito(saldo)) {
                Console.WriteLine("Valor do saldo deve ser positivo.");
            }
            }while(saldo < 0);
            Console.WriteLine();
            

            Cliente cliente2= new Cliente("Cesar","123.456.789-10","1@as.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,312,cliente2);

            #region Deposito.
            Cliente usuario = contacorrente1.Titular;
            Console.WriteLine("ByteBank - Depósito em conta");
            Console.WriteLine($"Bem vindo - {usuario._Nome}");
            Console.WriteLine($"Agencia {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            Console.Write("Digite o valor de depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contacorrente1.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo saldo: {contacorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Saque.
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem Vindo - {usuario._Nome}");
            Console.WriteLine($"Agencia {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            Console.WriteLine();
            Console.Write("Digite o valor do saque: ");
            valor = double.Parse(Console.ReadLine());
            contacorrente1.Saque(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo saldo: {contacorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Trasferência.
            Console.WriteLine("ByteBank - Transferência");
            Console.WriteLine($"Bem Vindo - {usuario._Nome}");
            Console.WriteLine($"Agencia {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            Console.WriteLine($"Saldo: {contacorrente1.Saldo}");
            Console.WriteLine();
            Console.Write("Digite o valor da transferência: ");
            valor = double.Parse(Console.ReadLine());
            if(contacorrente1.Transferencia(contaCorrente2,valor)){
                Console.WriteLine("Transferência efetuada.");
            } else {
                Console.WriteLine("Não foi possível realizar a operação.");
            }
            Console.WriteLine();
            Console.WriteLine($"Novo saldo origem: {contacorrente1.Saldo}");
            Console.WriteLine($"Novo saldo destino: {contaCorrente2.Saldo}");
            Console.WriteLine();
            #endregion
        }
    }
}
