using System;
using System.Threading.Tasks;
class HelloWorld {
  static void Main() {
    int doacaoSua = 0;
    
    Console.WriteLine("Carl Jhonson - 'CJ', 24 anos, morador da Grove Street, Los Santos");
    Console.WriteLine("APADD - Assoaciação de Prevenção e Assistência aos Dependentes de Drogas, fundada em 1988");
    Console.WriteLine("CJ, após recuperar seu bairro, vê que muitos dos seus antigos companheiros estão muito dependentes das drogas traficadas pelos Ballas.");
    Console.WriteLine("Então, CJ entra em contato com a APADD e faz solicitações para socorrer seus amigos.");
    Console.WriteLine("Desde então, a Grove Street se tornou um lugar mais pacífico e CJ contribui com 10000 dólares mensais para a Assoaciação até os dias de hoje");
    
    while (true) {
    Console.WriteLine("O que você gostaria de ver sobre?");
    Console.WriteLine("1. Quanto CJ doou para a APADD");
    Console.WriteLine("2. Quanto outros membros da Grove doaram para APADD");
    Console.WriteLine("3. Fazer doações para APADD");
    Console.WriteLine("4. Quanto já doei para APADD");
    int opcao = int.Parse(Console.ReadLine());
    
    switch (opcao) {
        case 1:
        int doacaoCJ = 0;
        for (int mes=1; mes<364; mes++) {
            doacaoCJ = mes*10000;
        }
        Console.WriteLine($"CJ doou ${doacaoCJ:F2} para a APADD!");
        break;
        
        case 2:
        int ano = 0;
        double doacaoMembros = 0;
        Console.WriteLine("Após 1 ano, outros membros da Grove também passaram a fazer doações mensais, como forma de agradecimento.");
        Console.WriteLine("E com cada vez mais membros se recuperando, mais doadores foram surgindo.");
            do {
                
                for (int mesMembros=1; mesMembros<352; mesMembros++) {
                ano = mesMembros/12 + 1;
                doacaoMembros += mesMembros * ano;
                
        }
        } while (ano < 20);
        
        Console.WriteLine($"Dessa forma, todos os outros membros doaram ${doacaoMembros:F2} no total");
        break;
        
        case 3:
        int doacao;
        Console.WriteLine("Você quer doar em (real) ou (dólar)?");
        string donation = Console.ReadLine();
        if (donation == "dólar") {
            
            Console.WriteLine("Quanto você deseja doar?");
            doacao = int.Parse(Console.ReadLine());
            doacaoSua += doacao;
            
        } else if (donation == "real") {
            
            Console.WriteLine("Quanto você deseja doar?");
            doacao = int.Parse(Console.ReadLine())/5;
            doacaoSua += doacao;
            
        } else {
            
            Console.WriteLine("Opção inválida!");
            break;
            
        }
        
        Console.WriteLine($"Transferência concluída! Você ajudou a APADD com ${doacao:F2}! Obrigado!");
        break;
        
        case 4:
        if (doacaoSua != 0){
        Console.WriteLine($"Você já doou {doacaoSua:F2}!");
        } else {
            Console.WriteLine("Você não doou nada!");
        }
        break;
        
        default:
        
        Console.WriteLine("Opção inválida! Selecione uma opção dentre as oferecidas.");
        break;
    }
    }
  }
}