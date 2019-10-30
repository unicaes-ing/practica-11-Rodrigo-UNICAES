using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leer
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream file = new FileStream("clientes.doc", FileMode.Open, FileAccess.Read);
                BinaryReader wiwi = new BinaryReader(file);
                string nombre = wiwi.ReadString();
                int cel = wiwi.ReadInt32();
                string date = wiwi.ReadString();
                decimal sueldo = wiwi.ReadDecimal();
                file.Close();
                wiwi.Close();
                Console.WriteLine("Datos del cliente: ");
                Console.WriteLine();
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Telefono: {0}", cel);
                Console.WriteLine("Fecha de nacimiento: {0}", date);
                Console.WriteLine("Salario: {0}$", sueldo);
                Console.WriteLine();
                Console.WriteLine("Presione culaquier tecla para salir.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Error bug 155555555 /)(/&(/&%/)(=/)%&%(7 ");
            }
        }
    }
}
