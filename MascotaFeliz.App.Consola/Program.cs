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
            AddMascota();0
            BuscarMascota(7);
            ListadoMascotas();
            BuscarDueno(12);
            ListadoDuenos();
            BuscarVeterinario(13);
            ListadoVeterinarios();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Cecilia",
                Apellidos = "Rodríguez",
                Direccion = "El dorado",
                Telefono = "6016398224",
                Correo = "cecil@hotmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Maunel",
                Apellidos = "Sánchez",
                Direccion = "Piedecuesta",
                Telefono = "6031321251",
                TarjetaProfesional = "115864"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "Tomy",
                Color = "blanco",
                Especie = "canino",
                Raza = "criollo",
            };
            _repoMascota.AddMascota(mascota);
        }
        // Consultas de mascotas
        private static void BuscarMascota(int idMascota)
        {
            Console.WriteLine();
            Console.WriteLine("Nombre   Color  Especie  Raza");
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+" "+mascota.Color+" "+mascota.Especie+" "+mascota.Raza);

        }
        private static void ListadoMascotas()
        {
            Console.WriteLine();
            Console.WriteLine("Nombre   Color  Especie  Raza");
            var Mascotas = _repoMascota.GetAllMascotas();
                foreach (Mascota i in Mascotas) {
                    Console.WriteLine(i.Nombre+" "+i.Color+" "+i.Especie+" "+i.Raza);
                }
        }
        //Consulta de dueños
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine();
            Console.WriteLine("Nombres   Apellidos  Dirección   Teléfono    Correo");
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + "  " + dueno.Direccion + "  " + dueno.Telefono + "  " + dueno.Correo);

        }
        private static void ListadoDuenos()
        {
            Console.WriteLine();
            Console.WriteLine("Nombres   Apellidos  Dirección   Teléfono    Correo");
            var Duenos = _repoDueno.GetAllDuenos();
                foreach (Dueno d in Duenos) {
                    Console.WriteLine(d.Nombres+" " + d.Apellidos + "  " + d.Direccion + "  " + d.Telefono + "  " + d.Correo);
                }
        } 
        // Consulta de veterinarios                          
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine();
            Console.WriteLine("Nombres Apellidos Dirección  Teléfono  T. P.");
            Console.WriteLine(veterinario.Nombres+" " + veterinario.Apellidos + "  " + veterinario.Direccion + "  " + veterinario.Telefono + "  " + veterinario.TarjetaProfesional);
        }
        private static void ListadoVeterinarios()
        {
            Console.WriteLine();
            Console.WriteLine("Nombres Apellidos Dirección  Teléfono  T. P.");
            var Veterinarios = _repoVeterinario.GetAllVeterinarios();
                foreach (Veterinario v in Veterinarios) {
                    Console.WriteLine(v.Nombres +" " + v.Apellidos + "  " + v.Direccion + "  " + v.Telefono + "  " + v.TarjetaProfesional);
                }
        } 
        
    }
}
