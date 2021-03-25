using System;

namespace clase_producto
{
    class Pruducto
    {
        static void Main(string[] args)
        {
            int SUMREFRE,totalg,op,V,h = 0, p = 0, s = 0, sl = 0;
            string PA, NOM;
            double a, b, c, d, e, f, g, suma = 0;
            do
            {
                Console.WriteLine("\n\t\t maquina de alimentos ~colis ");
                Console.WriteLine("\n\t\t 1.- inserte las monedas");
                Console.WriteLine("\n\t\t 2. - opciones administrativas");
                Console.WriteLine("\n\t\t 3. - comprar");
                Console.WriteLine("\n\t\t 4.- SALIR");
                Console.Write("\n\t\t opcion: ");
                V = Convert.ToInt16(Console.ReadLine());
                if (V == 1)
                {
                    Console.Clear();
                    Console.Write("\n\t\t inserte la(s) moneda(s) y billetes(s) de 50 centavos:");

                    a = Convert.ToDouble(Console.ReadLine());
                    suma = suma + a * 0.5;
                    Console.Write("\n\t\t inserte la(s) moneda(s) de 5 pesos: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    suma = suma + b * 5;
                    Console.Write("\n\t\t inserte la(s) moneda(s) de 10 pesos: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    suma = suma + c * 10;
                    Console.Write("\n\t\t inserte la(s) moneda(s) de 25 pesos: ");
                    d = Convert.ToDouble(Console.ReadLine());
                    suma = suma + d * 25;
                    Console.Write("\n\t\t inserte la(s) billetes(s) de 50 pesos: ");
                    e = Convert.ToDouble(Console.ReadLine());
                    suma = suma + e * 50;
                    Console.Write("\n\t\t inserte la(s) billetes(s) de 100 pesos: ");
                    f = Convert.ToDouble(Console.ReadLine());
                    suma = suma + e * 100;
                    Console.Write("\n\t\t inserte la(s) billetes(s) de 200 pesos: ");
                    g = Convert.ToDouble(Console.ReadLine());
                    suma = suma + e * 200;
                    Console.Clear();

                }
                if (V == 2)
                {
                    Console.Clear(); 
                    Console.Write("\n\t\t ESCRIBRE EL NOMBRE DEL USUARIO: "); 
                    NOM = Console.ReadLine(); 
                    if (NOM == "admin" || NOM == "ADMIN")
                    {
                        Console.Write("\n\t\t INGRESE EL PASSWORD : ");
                        PA = Console.ReadLine();
                        if (PA == "colis" || PA == "colis")
                        { 
                            SUMREFRE = h + p + sl + s;
                            Console.WriteLine("\n\t\t SE VENDIERON " + SUMREFRE + " alimentos(S)");
                            totalg = SUMREFRE * 8;
                            Console.WriteLine("\n\t\t LA GANANCIA POR LOS ALIMENTOS VENDIDOS FUE DE " + totalg + " PESOS");
                            Console.ReadKey(); 
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t PASSWORD INCORRECTO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t NOMBRE DE USUARIO INCORRECTO");
                    }

                }
                if (V == 3)
                {
                    if (suma >= 8)
                    {
                        Console.Clear(); Console.WriteLine("\n\t\t seleccione el alimento"); 
                        Console.WriteLine("\n\t\t 1. - Leche"); 
                        Console.WriteLine("\n\t\t 2. - Avena"); 
                        Console.WriteLine("\n\t\t 3. - Pan");
                        Console.WriteLine("\n\t\t 4. - Arroz");
                        Console.WriteLine("\n\t\t 5. - Huevos ");
                        Console.WriteLine("\n\t\t 6. - frijoles");
                        Console.Write("\n\t\t cual es su opcion 1,2,3,4,5,6 :");
                        op = Convert.ToInt32(Console.ReadLine()); 
                        if (op == 1) 
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado una leche");
                            suma = suma - 8; Console.WriteLine("su cambio es de " + suma);
                            h++; 
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (op == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado una avena"); 
                            suma = suma - 8;
                            Console.WriteLine("su cambio es de " + suma);
                            p++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (op == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado un pan");
                            suma = suma - 8;
                            Console.WriteLine("su cambio es de " + suma);
                            s++; Console.ReadKey(); 
                            Console.Clear();
                        }
                        if (op == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado un arroz");
                            suma = suma - 8;
                            Console.WriteLine("su cambio es de " + suma); 
                            sl++; 
                            Console.ReadKey(); 
                            Console.Clear();
                        }
                        if (op == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado unos huevos");
                            suma = suma - 8;
                            Console.WriteLine("su cambio es de " + suma);
                            sl++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (op == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("se ha despachado unos frijoles");
                            suma = suma - 8;
                            Console.WriteLine("su cambio es de " + suma);
                            sl++;
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("inserte mas monedas"); 
                        Console.WriteLine("el dinero que inserto es :" + suma);
                    }

                }
                if (V == 4)
                {
                    Environment.Exit(0);
                }
            } while (V != 4);

        }
    }
}
