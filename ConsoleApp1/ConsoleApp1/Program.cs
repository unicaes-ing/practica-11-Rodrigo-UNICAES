using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                int cel = int.Parse(Console.ReadLine());
                Console.WriteLine("Fecha de nacimiento: ");
                string date = Console.ReadLine();
                Console.WriteLine("Salario: ");
                decimal sueldo = decimal.Parse(Console.ReadLine());
                FileStream file = new FileStream("clientes.doc", FileMode.Create, FileAccess.Write);
                BinaryWriter wiwi = new BinaryWriter(file);
                wiwi.Write(nombre);
                wiwi.Write(cel);
                wiwi.Write(date);
                wiwi.Write(sueldo);
                file.Close();
                wiwi.Close();
                Console.WriteLine();
                Console.WriteLine("Datos Guardados........ ");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en el proceso..... ");
            }
        }
    }
}
