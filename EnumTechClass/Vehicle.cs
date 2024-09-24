using System;

namespace EnumTechClass
{
    public enum TipoVeiculo
    {
        Carro,
        Caminhao,
        Motocicleta,
        SUV
    }

    public class Motor
    {
        public string TipoMotor { get; set; }
        public int Potencia { get; set; }
        public double Cilindrada { get; set; }

        public Motor(string tipoMotor, int potencia, double cilindrada)
        {
            TipoMotor = tipoMotor;
            Potencia = potencia;
            Cilindrada = cilindrada;
        }
    }

    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public Motor Motor { get; set; }

        public Veiculo(string marca, string modelo, int ano, TipoVeiculo tipo, Motor motor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Tipo = tipo;
            Motor = motor;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("Detalhes do Veículo:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine("Detalhes do Motor:");
            Console.WriteLine($"  Tipo do Motor: {Motor.TipoMotor}");
            Console.WriteLine($"  Potência: {Motor.Potencia} HP");
            Console.WriteLine($"  Cilindrada: {Motor.Cilindrada} L");
        }
    }

}


