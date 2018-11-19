using System;
using System.Collections.Generic;
using System.Text;

namespace AppClima1.Clases
{
    public class Clima
    {
        //116be50d5edd9b7f6e236817a565723f API KEY 
        public string Titulo { get; set; }
        public string Temperatura { get; set; }
        public string Viento { get; set; }
        public string Humedad { get; set; }
        public string Visibilidad { get; set; }

        public Clima()
        {
            this.Titulo = string.Empty;
            this.Temperatura = string.Empty;
            this.Viento = string.Empty;
            this.Humedad = string.Empty;
            this.Visibilidad = string.Empty; 
        }


    }
}
