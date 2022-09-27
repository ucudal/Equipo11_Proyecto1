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
    public static void PersonPrinter (IPerson person)
    {
        Console.WriteLine($"Nombre: {person.Name}.\nNumero de Telefono: {person.PhoneNumber}.\nMail: {person.EmailAddress}.\n");
    }

    //  Employer es el usuario
    public static void MatchPrinter(Worker worker, Employer user)
    {
        Console.WriteLine("¡Has emparejado! A continuación te otorgaremos los datos de contacto para realizar un acuerdo...");
        PersonPrinter(worker);
        Console.WriteLine($"Una vez confirmado el acuerdo, se le otorgará la C.I de {user.Name} por cuestiones de seguridad.");
    }
    public static void NoMatch(IPerson user, IPerson userMatch)
    {
        Console.WriteLine("Por el momento no se encuentra disponible un emparejamiento. Vuelva a intentar más tarde...");
    }

    public static void finalizedSearch()
    {
        Console.WriteLine("La búsuqeda ha finalizado");
    }

    public static void notExactMatch(IPerson worker)
    {
        Console.WriteLine($"Hemos encontrado a alguien para ti, sin embargo su calificación {worker.Name} es menor que la esperada");
    }
    
    
}
//No contiene la funcionalidad de Console (despues copiar y pegar el archivo donde si pueda funcionar)
}