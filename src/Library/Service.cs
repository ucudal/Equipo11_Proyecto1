using System;

namespace ClassLibrary
{
    public class Service
    {
        private string fieldArea;
        private string field;
        private string description;
        private double starsRating;
        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                //aseguro que la field exista como una clave dentro del diccionario de campos de trabajo del programa
                if (!string.IsNullOrEmpty(value) && JobFields.WorkFields.ContainsKey(value))
                {
                    this.field = value;
                }
            }
        }
        public string FieldArea
        {
            get
            {
                return this.fieldArea;
            }
            set
            {
                //Aseguro que la string se encuentre dentro de la lista asociada a la clave Field
                if (!string.IsNullOrEmpty(value) && JobFields.WorkFields[this.field].Contains(value))
                {
                    this.fieldArea = value;
                }
            }
        }
        public int StarsRating
        {
            get
            {
                return this.StarsRating;
            }
            set
            {
                //Aseguro que se respete el sistema de 5 estrellas de puntuacion
                if (value <= 5)
                {
                    this.starsRating = value;
                }
            }
        }
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

        public int amountOfRatings {get; set;}

        public Service(string field, string fieldArea, string description)
        {
            this.Field = field;
            this.Field = fieldArea;
            this.StarsRating = 0;
            this.amountOfRatings=0;
            this.Description = description;
        }
    }
}