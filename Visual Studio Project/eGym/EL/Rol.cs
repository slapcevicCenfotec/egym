using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Rol 
    {
        private String _nombre;
        private String _descripcion;
        private List<Permiso> _listaPermisos;


        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public List<Permiso> Permiso
        {
            get { return _listaPermisos; }
            set { _listaPermisos = value; }
        }


    }
}
