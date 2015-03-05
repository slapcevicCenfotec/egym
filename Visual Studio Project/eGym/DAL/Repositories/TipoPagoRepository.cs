using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;


namespace DAL.Repositories
{
    public class TipoPagoRepository : IRepository<TipoPago>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public TipoPagoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(TipoPago entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(TipoPago entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(TipoPago entity)
        {
            _updateItems.Add(entity);
        }
        public void Save()
        {
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

       


    }
}
