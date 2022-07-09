using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen3
{
     class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            List<data> datos = new List<data>();
            data[] arrayData = new data[200];
            double[] valor_apertura = new double[200];
            double[] valor_maximo = new double[200];
            double[] valor_minimo = new double[200];
            double[] valor_cierre = new double[200];
            double apertura_maximo = 0;
            double apertura_minimo = 0;
            double maximo_maximo = 0;
            double maximo_minimo = 0;
            double minimo_maximo = 0;
            double minimo_minimo = 0;
            double cierre_maximo = 0;
            double cierre_minimo = 0;

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
                //*********Con arreglo de objetos
                arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);                              

                line = sr.ReadLine();
                contador++;
            }

            for (int i = 0; i < 200; i++)
            {                
                valor_apertura[i] = (arrayData[i].APERTURA);
                valor_maximo[i] = (arrayData[i].MAXIMO);
                valor_minimo[i] = (arrayData[i].MINIMO);
                valor_cierre[i] = (arrayData[i].CIERRE);

                apertura_maximo = valor_apertura.Max();
                apertura_minimo = valor_apertura.Min();
                maximo_maximo = valor_maximo.Max();
                maximo_minimo = valor_maximo.Min();
                minimo_maximo = valor_minimo.Max();
                minimo_minimo = valor_minimo.Min();
                cierre_maximo = valor_cierre.Max();
                cierre_minimo = valor_cierre.Min();
            }

            Console.WriteLine("Apertura:");
            Console.WriteLine("         Maximo:" + apertura_maximo);
            Console.WriteLine("         Minimo:" + apertura_minimo);
            Console.WriteLine();
            Console.WriteLine("Maximo: ");
            Console.WriteLine("        Maximo:" + maximo_maximo);
            Console.WriteLine("        Minimo:" + maximo_minimo);
            Console.WriteLine();
            Console.WriteLine("Minimo: ");
            Console.WriteLine("        Maximo:" + minimo_maximo);
            Console.WriteLine("        Minimo:" + minimo_minimo);
            Console.WriteLine();
            Console.WriteLine("Cierre: ");
            Console.WriteLine("        Maximo:" + cierre_maximo);
            Console.WriteLine("        Minimo:" + cierre_minimo);

            Console.ReadKey();
        }
    }
}
