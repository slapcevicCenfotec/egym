using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using System.Collections;

namespace DAL.Repositories
{
    class RolRepository
    {

        //private List<IEntity> _insertItems;
        //private List<IEntity> _deleteItems;
        //private List<IEntity> _updateItems;

        //public RolRepository()
        //{
        //    _insertItems = new List<IEntity>();
        //    _deleteItems = new List<IEntity>();
        //    _updateItems = new List<IEntity>();
        //}

        //public void Insert(Rol entity)
        //{
        //    _insertItems.Add(entity);
        //}

        //public void Delete(Rol entity)
        //{
        //    _deleteItems.Add(entity);
        //}

        //public void Update(Rol entity)
        //{
        //    _updateItems.Add(entity);
        //}

        //public IEnumerable<Rol> GetAll()
        //{


        //    List<Rol> listaEstrellas = null;

        //    SqlCommand cmd = new SqlCommand();
        //    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_listar_estrellas");



        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        listaEstrellas = new List<Rol>();
                
        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            listaEstrellas.Add(new Rol
        //            {
        //                Id = Convert.ToInt32(dr["ID"]),
        //                Nombre = dr["NOMBRE"].ToString(),
        //                Descripcion= dr["DESCRIPCION"].ToString(),
        //            });
        //        }
        //    }

        //    return listaEstrellas;
        //}

        //public Rol GetById(int id)
        //{
        //    Rol objEstrella = null;
        //    var sqlQuery = "SELECT Id, Nombre, Descripcion FROM T_ROL WHERE ID = @ID";
        //    SqlCommand cmd = new SqlCommand(sqlQuery);
        //    cmd.Parameters.AddWithValue("@ID", id);

        //    var ds = DBAccess.ExecuteQuery(cmd);

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        var dr = ds.Tables[0].Rows[0];

        //        objEstrella = new Rol
        //        {
        //            Id = Convert.ToInt32(dr["Id"]),
        //            Nombre = dr["Nombre"].ToString(),
        //            TemperaturaPromedio = Convert.ToDouble(dr["Tipo"])
                   
        //        };
        //    }



        //    return objEstrella;
        //}

        //public void Save()
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        try
        //        {
        //            if (_insertItems.Count > 0)
        //            {
        //                foreach (Estrella objEstrella in _insertItems)
        //                {
        //                    InsertEstrella(objEstrella);
        //                }
        //            }

        //            if (_updateItems.Count > 0)
        //            {
        //                foreach (Estrella p in _updateItems)
        //                {
        //                    UpdateEstrella(p);
        //                }
        //            }

        //            if (_deleteItems.Count > 0)
        //            {
        //                foreach (Estrella p in _deleteItems)
        //                {
        //                    DeleteEstrella(p);
        //                }
        //            }

        //            scope.Complete();
        //        }
        //        catch (TransactionAbortedException ex)
        //        {

        //        }
        //        catch (ApplicationException ex)
        //        {

        //        }
        //        finally
        //        {
        //            Clear();
        //        }

        //    }
        //}

        //public void Clear()
        //{
        //    _insertItems.Clear();
        //    _deleteItems.Clear();
        //    _updateItems.Clear();
        //}

        //private void InsertEstrella(Rol objEstrella)
        //{

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Parameters.Add(new SqlParameter("@nombre", objEstrella.Nombre));
        //        cmd.Parameters.Add(new SqlParameter("@temperatura", objEstrella.TemperaturaPromedio));
          

        //        DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_agregar_estrella");

        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}

        //private void UpdateEstrella(Rol objEstrella)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Parameters.Add(new SqlParameter("@nomb", objEstrella.Nombre));
        //        cmd.Parameters.Add(new SqlParameter("@temperatura", objEstrella.TemperaturaPromedio));


        //        DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_estrella");

        //    }
        //    catch (Exception ex)
        //    {
                
        //    }
        //}

        //private void DeleteEstrella(Estrella objEstrella)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Parameters.Add(new SqlParameter("@", objEstrella.Id));
        //        DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_estrella");

        //    }
        //    catch (SqlException ex)
        //    {
        //        logear la excepcion a la bd con un Exception
                

        //    }
        //    catch (Exception ex)
        //    {
        //        logear la excepcion a la bd con un Exception;
               
        //    }
        
        
        
        //}
        
    }
}
    

