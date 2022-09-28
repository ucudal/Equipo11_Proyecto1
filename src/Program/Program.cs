//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;


namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Service changa= new Service("Educacion", "Deporte", "Escuela de futbol", 1500);
            IPerson chinoRecoba= new Worker("Alvaro Recoba", "099123456", "arecoba@gmail.com", "12345678", 20, new Location(80, 170), changa);
            Service buscoClases= new Service("Educacion", "Deporte", "Clases de futbol", 2000);
            Employer castro= new Employer("Alex Castro", "099654321", "parcero@gmail.com","87654321", 4, new Location(30, 400), buscoClases);
            Match.LookingForMatch(castro);
            Rate castroCalificaAlChino= new Rate (chinoRecoba, 5, "mejore mucho mi pegada");
            Rate chinoCalificaAlColombiano= new Rate (castro, 4.5, "pago generoso");

            ConsolePrinter.PersonPrinter(castro);
            ConsolePrinter.PersonPrinter(chinoRecoba);
            Console.WriteLine(castro.Reputation[0].Description);
            Console.WriteLine(chinoRecoba.Reputation[0].Description);
            Console.WriteLine(Distance.DistanceCalculator(chinoRecoba,castro));

            
        }
    }
}