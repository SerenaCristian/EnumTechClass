using System;

namespace EnumTechClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('-', 50);
            Console.WriteLine(sep);
            Console.WriteLine("Sistema Enum Tech Class");
            Console.WriteLine(sep);

            Motor MotorCarro = new Motor("Flex", 999, 1.0 );
            Motor MotorCarroTiguan = new Motor("Flex", 1984, 2.0);

            Veiculo uno = new Veiculo("Fiat", "uno", 2018, TipoVeiculo.Carro, MotorCarro);
            Veiculo Tiguan = new Veiculo("Volkswagen", "SUV", 2022, TipoVeiculo.SUV, MotorCarroTiguan);

            uno.ImprimirDetalhes();

            Console.WriteLine(sep);

            Tiguan.ImprimirDetalhes();

            Console.WriteLine(sep);
        }
    }
}
