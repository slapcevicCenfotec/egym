using DAL;
using EL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class Gestor
    {
        private UnitOfWork unitOfWork;

        public Gestor()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Usuario> listarUsuarios()
        {
            var lista = unitOfWork.RepositoryUsuario.GetAll();
            return lista;
        }
    }
}
