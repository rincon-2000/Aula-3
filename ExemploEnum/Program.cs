using System;

namespace ExemploEnum
{
    class Program
    {
        enum EstadosCivis : byte
        {
            Casado,
            Solteiro,
            Viuvo,
            Separado,
            Outro
        }
        static void Main(string[] args)
        {
            for(byte i = 0; i <= 4; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(EstadosCivis), i));
            }
        }
    }
}
