using DAL.Repositories;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork
    {
        private IRepository<Usuario> _repositoryUsuario = null;

        public IRepository<Usuario> RepositoryUsuario
        {
            get
            {
                if (this._repositoryUsuario == null)
                {
                    this._repositoryUsuario = new UsuarioRepository();
                }
                return _repositoryUsuario;
            }
        }

    }
}
