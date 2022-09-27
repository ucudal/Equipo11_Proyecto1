using System;

namespace ClassLibrary
{

    ///  Esta clase comparara los datos entre worker y empleador
    /// A partir de ahi dictaminara si existe un emparejamiento posible o no
    /// A futuro pensamos hacer uso del chatbot para darle la libertad de negociacion y flexibilizar algunos datos (ej: salario, ubicacion)
    /// Y que eso permita un emparejamiento a pesar de que los datos iniciales no coincidieran del todo
    public class Match
    {
        private IPerson person;

        public static bool LookingForMatch(Employer employer)
        {
            foreach (Worker worker in ActiveWorkers.activeWorkers)
            {
                if (ExactMatch(worker, employer))
                {
                    ConsolePrinter.MatchPrinter(worker, employer);
                    return true;
                }
                else
                {
                    ConsolePrinter.NoMatch(employer, worker);
                    return false;
                }
            }
            //Falta un return afuera del foreach por eso es el error   
        }

        private static bool ExactMatch(Worker worker, Employer employer)
        {
            if (worker.Service.FieldArea == employer.Service.FieldArea)
            {
                if (worker.Service.StarsRating >= employer.Service.StarsRating)
                {
                    return true;
                }
                else
                {
                    ConsolePrinter.notExactMatch(worker);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //  Habilitacion para la negociacion entre ambas partes
        public static bool Negotiate()
        {
        }
    }
}