using System;
using System.Collections.Generic;
using System.Globalization;
using proposto2.dominio;

namespace proposto2 {
    class Tela {
        //o "front end" do usuario
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar marcas");
            Console.WriteLine("2 - Listar carros ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastrar carro");
            Console.WriteLine("5 - Cadastrar acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarMarcas() {
            Console.WriteLine("Listagem de marcas: ");
            for (int i = 0; i < Program.marcas.Count; i++) {
                Console.WriteLine(Program.marcas[i]);
            }
            Console.WriteLine();
        }

        public static void mostrarCarrosDeUmaMarca() {
            Console.Write("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1) {
                throw new ModelException("Código da marca não encontrado: " + codMarca);
            }
            Console.WriteLine("Carros da marca " + Program.marcas[pos].nome + ":");
            List<Carro> lista = Program.marcas[pos].carros;
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();

        }

        public static void cadastrarMarca() {
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País: ");
            string pais = Console.ReadLine();
            Marca M = new Marca(codigo, nome, pais);
            Program.marcas.Add(M);
        }

        public static void cadastrarCarro() {
            Console.WriteLine("Digite os dados do carro");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1) {
                throw new ModelException("Código da marca não encontrado: " + codMarca);
            }
            Console.Write("Código do carro: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Marca M = Program.marcas[pos];
            Carro C = new Carro(codigo, modelo, ano, precoBasico, M);
            M.addCarro(C);
            Program.carros.Add(C);
        }

        public static void cadastrarAcessorio() {
            Console.WriteLine("Digite os dados do acessório:");
            Console.Write("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCarro);
            if (pos == -1) {
                throw new ModelException("Código do carro não encontrado: " + codCarro);
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carro C = Program.carros[pos];
            Acessorio A = new Acessorio(descricao, preco, C);
            C.acessorios.Add(A);
        }

        public static void mostrarCarro(List<Carro> carros) {
            Console.Write("Digite o código do carro: ");
            Console.Write("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCarro);
            if (pos == -1) {
                throw new ModelException("Código do carro não encontrado: " + codCarro);
            }
            Console.WriteLine(carros[pos]);
            Console.WriteLine();
        }

    }

}
