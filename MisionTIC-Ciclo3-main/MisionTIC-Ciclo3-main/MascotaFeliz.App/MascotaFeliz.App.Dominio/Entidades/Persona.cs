using System; //Importar el sistema 
namespace MascotaFeliz.App.Dominio //Paquetes 
{
    public class Persona
    {
        public int Id {get;set;} //Propiedad, encapsula el atributo (id) de la clase y los get y set 
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
    }
}
