using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models {
    public class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrWhiteSpace(placa)) {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            if (veiculos.Contains(placa)) {
                Console.WriteLine($"O veículo {placa} já está estacionado.");
                return;
            }

            veiculos.Add(placa);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }


        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa)) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string inputHoras = Console.ReadLine();
                int horas = 0;

                if (int.TryParse(inputHoras, out horas) && horas >= 0) {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                }
                else {
                    Console.WriteLine("Quantidade de horas inválida.");
                }
            }
            else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos() {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos) {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}