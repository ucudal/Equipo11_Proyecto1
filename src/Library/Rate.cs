using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase se encarga de conocer las instancias de una evaluacion de una IPerson.
    /// Conoce la descripcion de un Rating
    /// Conoce la puntuacion de un Rating
    /// Contiene TotalRating() que calcula la valoracion promedio de los Rating de un IPerson.
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// Constructor de la clase Rating.
        /// Por cada nueva instancia de Rate, se modifica el Rating de la persona ingresada
        /// y se añade dicha instancia a Reputation 
        /// </summary>
        /// <param name="person"></param>
        /// <param name="rating"></param>
        /// <param name="description"></param>
        public Rate(IPerson person, double rating, string description)
        {
            this.Rating = rating;
            this.Description = description;
            person.Reputation.Add(this);
            person.Rating= TotalRating(person);
        }

        IPerson person;
        private string description;

        /// <summary>
        /// Breve descripcion formal de una parte respecto a la otra
        /// </summary>
        /// <value></value>
        public string Description 
        {
        get
            {
                return this.description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.description = value;
                }
            }
        }
        private double rating;

        /// <summary>
        /// La evaluacion consiste de una puntuacion entre 0 y 5
        /// </summary>
        /// <value></value>
        public double Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                if (value <= 5)
                {
                    this.rating = value;
                }
            }
        }

        /// <summary>
        /// Calcula el rating promedio del IPerson
        /// </summary>
        /// <returns></returns>
        public static double TotalRating(IPerson person)
        {
            double allRates = 0;
            int rateCtr = 0;
            foreach (Rate rate in person.Reputation)
            {
                allRates += rate.Rating;
                rateCtr += 1;
            }
            double finalRate = allRates / rateCtr;
            return finalRate;
        }
    }
}