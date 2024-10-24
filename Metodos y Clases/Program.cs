﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_y_Clases
{
    internal class Program
    {
        static void eje01()
        {
            Console.Write("Introduce el tamaño del array a crear: ");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arrayLenght];
            int suma = 0;
            int media = 0;

            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write($"Introduzca el {i}º número: ");
                int n = Convert.ToInt32(Console.ReadLine());
                suma += n;
            }

            Console.WriteLine($"La suma de todos los valores es {suma}");
            Console.WriteLine($"La media de todos los valores es {suma / arrayLenght}");
        }

        static int cuentaEspacios(string s) {
            int espacio = 0;
            for (int i = 0;i<s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    espacio++;
                }
            }
            return espacio;
        }

        static void eje02() {
            Console.Write("Introduzca su cadena de caracteres: ");
            string cadena = Console.ReadLine();

            Console.WriteLine($"El número de espacios en blanco es: {cuentaEspacios(cadena)}");
        }

        static int factorial(int n)
        {
            int fact = 1;
            for(int i = n; i>0; i--)
            {
                fact *= i;
            }

            return fact;
        }

        static void eje03() {
            Console.Write("Introduzca el número para calcular el factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine($"El factorial de {n} es {factorial(n)}");
        }

        static bool esPrimo(int n)
        {
            bool esPrimo = true;

            for(int i = 2; i < n + 1 / 2; i++)
            {
                if (n % i == 0)
                {
                    esPrimo = false;
                }
            }
            
            return esPrimo;
        }
        static void eje04() {
            Console.Write("Introduce un número para comprobar si es primo: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El {n} es primo?: {esPrimo(n)}");
        }

        static int potencia(int b , int exponente) {
            int potencia = 1;

            for (int i = 0; i<exponente; i++)
            {
                potencia*= b;
            }

            return potencia;
        }

        static void eje05() {
            Console.Write("Base del número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Potencia del número: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{b}^{exponente} = {potencia(b,exponente)}");
        }

        static bool creedenciales(string user, string password)
        {
            if(user.Equals("usuario2DAM") && password.Equals("pass2DAM"))
                return true;
            else
                return false;
        }

        static void eje06() {
            int intentos = 3;
            bool exito = false;

            do {
                Console.Write("Introduzca el usuario: ");
                string user = Console.ReadLine();

                Console.Write("Introduzca la contraseña: ");
                string password = Console.ReadLine();

                if (creedenciales(user, password))
                {
                    exito = true;
                    Console.WriteLine("Exito");
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Creedenciales incorrectas, te quedan {intentos} intentos");
                }

            }while (intentos > 0 && exito == false);
        }

        static bool esMultiplo(int n, int n2)
        {
            if (n2 % n == 0)
                return true;
            else
                return false;
        }
        static void eje07()
        {
            Console.Write("Introduzca el primero número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Es múltiplo {n} de {n2}?: {esMultiplo(n,n2)}");
        }

        static int sumaDigitos(string n) {
            int suma = 0;

            for(int i = 0; i<n.Length; i++)
            {
                suma += (int)char.GetNumericValue(n[i]);
            }

            return suma;
        }

        static void eje08() { 
            Console.Write("Introduzca el número: ");
            string n = Console.ReadLine();

            Console.WriteLine($"La suma de los dígitos de {n} es: {sumaDigitos(n)}");
        }

        static int menorNumero(int[] n)
        {
            int menor = int.MaxValue;
            for(int i = 0; i < n.Length; i++)
            {
                if(n[i] < menor)
                {
                    menor = n[i];
                }
            }
            return menor;
        }
        static void eje09() {
            int[] n = { 1, 2, 3, 4, 5, 6, 7, 8,-20, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine($"El menor número del array es {menorNumero(n)}");
        }

        class Cliente
        {
            private static int _id = 0;
            private int id = _id++;
            private string name;
            private int cantidadTotal;

            public Cliente(string name, int cantidadTotal)
            {
                this.id = id;
                this.name = name;
                this.cantidadTotal = cantidadTotal;
            }

            public void ingresar(int n, Banco banco)
            {

            }

            public void sacar(int n, Banco banco)
            {

            }

            public void GetCantidadTotal(Banco banco)
            {

            }

            public void MostrarInformacion()
            {

            }
        }

        class Banco
        {
            public int id;
            public string name;

            public Banco(int id, string name) {
                this.id = id;
                this.name = name;
            }



        }

        static void eje10() {
            Banco banco = new Banco(1, "Santander");
        
        }
        static void Main(string[] args)
        {
            eje10();
        }
    }
}
