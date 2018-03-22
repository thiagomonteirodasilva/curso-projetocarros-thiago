using System;
using System.Collections.Generic;
using proposto2.dominio;
using System.Text;
using System.Threading.Tasks;

namespace proposto2 {
    class Program {

        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        
        static void Main(string[] args) {

            int opcao = 0;

            //lista de marcas
            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            //lista de carros
            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            m1.addCarro(c1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            m1.addCarro(c2);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            m1.addCarro(c3);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, m2);
            m2.addCarro(c4);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, m2);
            m2.addCarro(c5);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, m2);
            m2.addCarro(c6);

            //armazenando carros e marcas no programa
            marcas.Add(m1);
            marcas.Add(m2);
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            while (opcao != 7) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    opcao = int.Parse(Console.ReadLine());

                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1) {
                    Tela.mostrarMarcas();
                }
                else if (opcao == 2) {
                    try {
                        Tela.mostrarCarrosDeUmaMarca();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro ao cadastrar marca: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                    //Tela.mostrarCarrosDeUmaMarca();
                } else if (opcao == 3) {
                    try {
                        Tela.cadastrarMarca();
                    } catch (ModelException e){
                        Console.WriteLine("Erro ao cadastrar marca: " + e.Message);
                    } catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    try {
                        Tela.cadastrarCarro();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro ao cadastrar carro: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5) {
                    try {
                        Tela.cadastrarAcessorio();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro ao cadastrar acessorio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 6) {
                    try {
                        Tela.mostrarCarro(carros);
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro ao cadastrar acessorio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 7) {
                    Console.WriteLine("Fim do programa.");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                }

                Console.ReadLine();
            }

        }
    }
}
