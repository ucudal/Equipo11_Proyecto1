using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    /// <summary>
    /// Conoce el diccionario WorkFields
    /// </summary>
public class JobFields
{
    /// <summary>
    /// Keys: campos de trabajo sobre los cual trabajará el programa
    /// Value: lista de cadenas con trabajos especificos respectivos al area
    /// </summary>
    /// <value></value>
    public static Dictionary<string, List<string>> WorkFields = new Dictionary<string, List<string>>

    {
        {"Entretenimiento", new List<string> () {"Animador"}},
        {"Arte", new List<string> () {"Diseño Grafico", "Animacion", "Musica", "Cine", "Artes Plasticas y Visuales"}},
        {"Agricultura", new List<string> () {"Jardineria", "Cultivacion", "Forestacion", "Ganaderia", "Pescaderia"}},
        {"Construcción", new List<string> () {"Animador"}},
        {"Transporte", new List<string> () {"Flete"}},
        {"Administración", new List<string> () {"Secretariado", "Gerencia", "Contaduria", "Recursos Humanos", "Bienes Raices"}},
        {"Comunicación", new List<string> () {"Redes", "Eventos", "Relaciones Publicas"}},
        {"Servicio Social", new List<string> () {"Ayudante"}},
        {"Educación", new List<string> () {"Idioma", "Matematica", "Fisica", "Quimica", "Biologia", "Filosofia", "Literatura", "Biblotecario"}},
        {"Tecnología", new List<string> () {"Hardware", "Software"}},
        {"Mantenimiento", new List<string> () {"Fontaneria", "Mecanico", "Electricista", "Carpintero", "Limpieza"}},
        {"Salud", new List<string> () {"Veterinaria", "Enfermero", "Dentista", "Terapia"}},
        {"Ventas", new List<string> ()},
        {"Otros", new List<string> () {"Niñero"}}, //si se les ocurre alguno mas agreguen
    };

}
}