using System;
using System.Text;

namespace ClassLibrary
{

    /// <summary>
    /// Esta clase se encargará unicamente de la impresión de datos.
    /// Incluye métodos los cuales serán llamados desde otras clases cuando sea necesario
    /// </summary>
    public class ConsolePrinter
    {

        /// <summary>
        /// Impresion de los datos de cotacto de un IPerson
        /// </summary>
        /// <param name="person"></param>
        public static void PersonPrinter(IPerson person)
        {
            Console.WriteLine($"Nombre: {person.Name}.\nNumero de Telefono: {person.PhoneNumber}.\nMail: {person.EmailAddress}.\nRating: {person.Rating}\n");
        }

        /// <summary>
        /// Impresion en consola cuando se produce un emparejamiento exitoso
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="user"></param>
        public static void MatchPrinter(Worker worker, Employer user)
        {
            Console.WriteLine("¡Has emparejado! A continuación te otorgaremos los datos de contacto para realizar un acuerdo...");
            PersonPrinter(worker);
            Console.WriteLine($"Una vez confirmado el acuerdo, se le otorgará la C.I de {user.Name} por cuestiones de seguridad.");
        }

        /// <summary>
        /// Impresion en consola cuando no se produce ningun emparejamiento exitoso
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userMatch"></param>
        public static void NoMatch(IPerson user, IPerson userMatch)
        {
            Console.WriteLine("Por el momento no se encuentra disponible un emparejamiento. Vuelva a intentar más tarde...");
        }

        /// <summary>
        /// Impresion en consola cuando la busqueda de emparejamiento ha finalizado
        /// </summary>

        public static void FinalizedSearch()
        {
            Console.WriteLine("La búsuqeda ha finalizado");
        }

        /// <summary>
        /// Impresion en consola cuando se habilita una negociacion para finalizar un emparejamiento de forma exitosa
        /// </summary>
        /// <param name="worker"></param>
        public static void notExactMatch(IPerson worker)
        {
            Console.WriteLine($"Hemos encontrado a alguien para ti, sin embargo su calificación {worker.Name} es menor que la esperada");
        }
    }
}