using System;

namespace empleados_y_sueldo
{
            class Matriz
   {
            private string[] empleados;
            private int[,] sueldos;
            private int[] sueldostot;

            public void Cargar()
            {
                empleados = new String[5];
                sueldos = new int[5, 3];
                for (int f = 0; f < empleados.Length; f++)
                {
                    Console.Write("Ingrese el nombre del empleado:");
                    empleados[f] = Console.ReadLine();
                    for (int c = 0; c < sueldos.GetLength(1); c++)
                    {
                        Console.Write("Ingrese sueldo:");
                        string linea;
                        linea = Console.ReadLine();
                        sueldos[f, c] = int.Parse(linea);
                    }
                }
            }

            public void CalcularSumaSueldos()
            {
                sueldostot = new int[5];
                for (int f = 0; f < sueldos.GetLength(0); f++)
                {
                    int suma = 0;
                    for (int c = 0; c < sueldos.GetLength(1); c++)
                    {
                        suma = suma + sueldos[f, c];
                    }
                    sueldostot[f] = suma;
                }
            }

            public void ImprimirTotalPagado()
            {
                Console.WriteLine("Total de sueldos pagados por empleado.");
                for (int f = 0; f < sueldostot.Length; f++)
                {
                    Console.WriteLine(empleados[f] + " - " + sueldostot[f]);
                }
            }

            public void EmpleadoMayorSueldo()
            {
                int may = sueldostot[0];
                string nom = empleados[0];
                for (int f = 0; f < sueldostot.Length; f++)
                {
                    if (sueldostot[f] > may)
                    {
                        may = sueldostot[f];
                        nom = empleados[f];
                    }
                }
                Console.WriteLine("El empleado con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
            }

            static void Main(string[] args)
            {
                Matriz ma = new Matriz();
                ma.Cargar();
                ma.CalcularSumaSueldos();
                ma.ImprimirTotalPagado();
                ma.EmpleadoMayorSueldo();
                Console.ReadKey();
            }
    }
}
