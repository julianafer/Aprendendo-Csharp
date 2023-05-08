namespace HelloWorld
{
    class Program
    {
        // enum
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        // escopo global
        static string meuNome = "Juliana Ferreira";

        static void Main(string[] args)
        {
            // declarações de variáveis
            int segundaGuerraMundial = 1942;
            string cor_favorita = "Vermelho";
            float velocidadeF1 = 294.98f;
            bool segundaGuerraMundialAconteceu = true;

            // print na mesma linha e pulando linha
            Console.Write("Hello World!");
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            // outras declarações
            var ano = 2023;
            const float PI = 3.1415f;
            dynamic qualquerTipo = "qualquer coisa";
            qualquerTipo = 1000;

            // leitura de dados passados pelo usuário
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.Write(nome);

            // condicionais e operadores lógicos
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11) {
                Console.WriteLine("Você é uma criança!");
            } else if (idade >= 12 && idade <= 18) {
                Console.WriteLine("Você é um adolescente!");
            } else if (idade >= 19 && idade <= 60) {
                Console.WriteLine("Você é um adulto!");
            } else {
                Console.WriteLine("Você é um idoso!");
            }

            // funções
            exibirMsg();
            GerarPreco(60, "Curso de Node.js");
            GerarPreco(-3, "Nesquik");

            // retorno de funções
            int soma1 = somar(1,2,3);
            int soma2 = somar(10,20,30);
            Console.WriteLine("Primeira soma:" + soma1 + ", Segunda soma:" + soma2);

            // Arrays
            string[] produtos = new string[5] {"Minecraft", "Roblox", "Fortnite", "Portal", "Tetris"};
            int[] valores = {10, 20, 30};

            // Switch 
            string cor = "Verde";
            switch(cor) {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei");
                    break;
            }

            // Enum
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaDaFulana = Cor.Azul;
            Console.WriteLine((int)corFavorita); // transforma a string no índice do enum
            Console.WriteLine((Cor)2); // faz o contrário
            Console.WriteLine(corFavoritaDaFulana);

            // enum com switch
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;
            switch (opcaoSelecionada) {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar algo!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer listar algo!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar algo!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }

            // while
            int contador = 1;
            while (contador <= 10) {
                Console.WriteLine(contador + " Rodando o while!");
                contador++;
            }

            // do while
            int contador2 = 1;
            do {
                Console.WriteLine(contador2 + " - do while");
                contador2++;
            } while (contador2 <= 10);

            // foreach
            string[] documentos = {"RG", "Identidade", "CNH", "Carteira de estudante"};
            foreach (string documento in documentos) {
                Console.WriteLine(documento + " - foreach");
            }

            // for
            for (int c = 0; contador < documentos.Length; c++) {
                Console.WriteLine(documentos[c] + " - for");
            }
            for (int c = documentos.Length-1; c >= 0; c--) {
                Console.WriteLine(documentos[c] + " - for ao contrário");
            }

            // escopo global
            Console.WriteLine(meuNome);
            exibirMsg();
        }

        // funções
        static void exibirMsg() {
            Console.WriteLine(meuNome); // escopo global
            Console.WriteLine("bla bla bla");
        }

        static void GerarPreco(int preco, string nome) {
            int precoAbs = Math.Abs(preco);
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine(precoAbs);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }

        static int somar(int a, int b, int c) {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}