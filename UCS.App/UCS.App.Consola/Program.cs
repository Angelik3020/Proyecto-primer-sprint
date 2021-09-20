using System;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi primer sprit");
            //AddDirectivo();
            ActualizarDirectivo();
        }

        //AddDirectivo
        private static void AddDirectivo()
        {
            var directivo = new Directivo
            {
                nombre = "Giovany",
                apellido = "Pacho",
                identificacion = 1134,
                edad = 29,
                unidadDesempeña = "Ingenierias"
            };

            Console.WriteLine(directivo.nombre+"\n" + directivo.apellido+"\n Se desempeña en = "+directivo.unidadDesempeña);
            Directivo directivoretornado = _repoDirectivo.AddDirectivo(directivo);
            if (directivoretornado!=null)
            Console.WriteLine("Se realizo un nuevo registro en la base de datos:>>"+directivoretornado.id);
        }
            
        //BuscarDirectivo
        private static void BuscarDirectivo (int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            Console.WriteLine(directivo.nombre+" "+directivo.apellido+"\n Unidad: "+directivo.unidadDesempeña);
        }

        //DeleteDirectivo
        private static void EliminarDirectivo(int idDirectivo)
        {
            _repoDirectivo.DeleteDirectivo(idDirectivo);
        }
       
        //UpdateDirectivo
         private static void ActualizarDirectivo()
        {
            var directivo = new Directivo 
            {
               id = 2,
               nombre = "Thomas",
               apellido = "Ramirez",
               identificacion = 110,
               edad = 36,
               unidadDesempeña = "Derecho"
               
            };
            Directivo directivoretornado =_repoDirectivo.UpdateDirectivo(directivo);                         
            if (directivoretornado!=null)
                Console.WriteLine("Se sustituyo un directivo en la base de datos");
        
        }

        //GetAllDirectivo
          private static void BuscarDirectivo()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivo();
            
            foreach (var directivo in directivos)
            {
                Console.WriteLine(directivo.nombre);
            }
            
        }

    }
}
