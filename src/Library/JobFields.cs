// Felipe Villaronga


using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    /// <summary>
    /// Conoce el diccionario WorkFields
    /// </summary>
    public class Jobs
    {
        /// <summary>
        /// Keys: campos de trabajo sobre los cual trabajará el programa
        /// Value: lista de cadenas con trabajos especificos respectivos al area
        /// </summary>
        /// <value></value>

        public Jobs(string name, string specificJob)
        {
            this.Name = name;
            this.SpecificJob = specificJob;
        }
        private string specificJob;
        /// <summary>
        /// Nombre específico del trabajo
        /// </summary>
        /// <value></value>
        public string SpecificJob
        {
            get
            {
                return this.specificJob;
            }
            set
            {
                if (JobFields.ContainsKey(value))
                {
                    this.specificJob= value;
                }
            }
        }
    private string name;

        /// <summary>
        /// Nombre del rubro de trabajo
        /// </summary>
        /// <value></value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (JobFields.ContainsKey(value))
                {
                    this.name = value;
                }
            }
        }
        /// <summary>
        /// Diccionario cuyas claves son los nombres de los rubros de trabajo (con los cuales cuenta el programa),
        /// y cuyo valor es una lista con los nombres de los trabajos mas específicos respectivos a cada rubro.
        /// </summary>
        /// <value></value>
        public static Dictionary<string, List<string>> JobFields = new Dictionary<string, List<string>>

    {
        {"Entretenimiento", new List<string> () {"Animador"}},
        {"Arte", new List<string> () {"Diseño Grafico", "Animacion", "Musica", "Cine", "Artes Plasticas y Visuales"}},
        {"Agricultura", new List<string> () {"Jardineria", "Cultivacion", "Forestacion", "Ganaderia", "Pescaderia"}},
        {"Construccion", new List<string> () {"Animador"}},
        {"Transporte", new List<string> () {"Flete"}},
        {"Administracion", new List<string> () {"Secretariado", "Gerencia", "Contaduria", "Recursos Humanos", "Bienes Raices"}},
        {"Comunicacion", new List<string> () {"Redes", "Eventos", "Relaciones Publicas"}},
        {"Servicio Social", new List<string> () {"Ayudante"}},
        {"Educacion", new List<string> () {"Idioma", "Matematica", "Fisica", "Quimica", "Biologia", "Deporte", "Filosofia", "Literatura", "Biblotecario"}},
        {"Tecnología", new List<string> () {"Hardware", "Software"}},
        {"Mantenimiento", new List<string> () {"Fontaneria", "Mecanico", "Electricista", "Carpintero", "Limpieza"}},
        {"Salud", new List<string> () {"Veterinaria", "Enfermero", "Dentista", "Terapia"}},
        {"Ventas", new List<string> () {"Ejecutivo", "Cajero", "Gerente"}},
        {"Otros", new List<string> () {"Niñero"}}, //si se les ocurre alguno mas agreguen
    };

    }
}