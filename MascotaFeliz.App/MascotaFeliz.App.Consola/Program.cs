using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;
namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a trabajar con las tablas");
            AddDueno();
            AddVeterinario();
            AddMascota();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Alberto",
                Apellidos = "Paredes",
                Direccion = "Las Casas",
                Telefono = "98765423",
                TarjetaProfesional = "506070"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "Firulais",
                Color = "Negro",
                Especie = "Canino",
                Raza = "Schnauzer",
            };
            _repoMascota.AddMascota(mascota);
        }
    }
}
