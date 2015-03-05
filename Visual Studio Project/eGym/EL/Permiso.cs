using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL
{
   public class Permiso
    {
        private int _id;
        private String _nombre;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


    }
}
