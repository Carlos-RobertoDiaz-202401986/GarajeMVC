using System.Collections.Generic;

namespace GarageMVC.Models
{
    public class Garage
    {
        public int numeroGaraje { get; set; }
        public string descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }

       
        private List<Auto> autos;

        
        public Garage(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados = 0)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
            this.autos = new List<Auto>();
        }

        
        public void ingresarAuto(Auto auto)
        {
            this.autos.Add(auto);
            this.espaciosOcupados = autos.Count;
        }

        
        public List<Auto> GetAutos()
        {
            return this.autos;
        }

        
        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}