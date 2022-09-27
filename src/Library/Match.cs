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

        public bool LookingForMatch(Employer employer)
        {
            foreach (Worker worker in ActiveWorkers)
            {
                if (ExactMatch(worker, employer))
                {
                    ConsolePrinter.MatchPrinter(worker, employer);
                }


            }
        }

        private bool ExactMatch(Worker worker, Employer employer)
        {
            if (worker.Service.FieldArea == employer.Service.FieldArea)
            {
                if (worker.Service.StarsRating >= employer.Service.StarsRating)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"We found someone for you. However, his rating ({worker.}) is lower than expected ?");
                }
            }
            else
            {
                return false;
            }
        }

        //  Habilitacion para la negociacion entre ambas partes
        public bool Negotiate()
        {

        }
    }
}