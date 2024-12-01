
using System;

namespace Servicio.Conversiones
{
    public class FechaService
    {
        // Retorna la fecha actual en un formato corto "dd/MM/yyyy".
        public string ObtenerFechaFormatoCorto()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        // Retorna la fecha actual en un formato largo "dddd, dd MMMM yyyy".
        public string ObtenerFechaFormatoLargo()
        {
            return DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

         // Retorna la fecha actual en formato ISO "yyyy-MM-ddTHH:mm:ss".
        public string ObtenerFechaFormatoISO()
        {
            return DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
