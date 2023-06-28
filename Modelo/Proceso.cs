using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Proceso
    {
        private int id;
        private String nombre;
        private int tamaño;
        //private String recurso;
      private String estado;
        
       
    

        public Proceso(int id, String nombre, int tamaño, String estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tamaño = tamaño;
            this.Estado = estado;
            
            //this.recurso = recurso;
        }
        public Proceso()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Tamaño { get => tamaño; set => tamaño = value; }
        public string Estado { get => estado; set => estado = value; }
        //public String Recursos { get => recurso; set => recurso = value; }

        public int getId() { return this.id; }
        public String getNom() { return this.nombre; }
        public int getTam() { return this.tamaño; }
        public String getEstadoI() { return this.estado; }
        
        //public String getRecurso() { return this.recurso; }
        
    }
}
