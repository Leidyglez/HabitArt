using DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Reflection;

namespace Business
{
    public class PropietariosLogica
    {
        public DataTable GetPropietarios()
        {
            try
            {
                using var dBContext = new AppDbContext();
                var propietarios = dBContext.Propietarios.ToList();
                DataTable dt = propietarios.ToDataTable();
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetPropietarios(string buscador)
        {
            if (string.IsNullOrWhiteSpace(buscador))
                return GetPropietarios();

            try
            {
                using var dBContext = new AppDbContext();
                var propietarios = dBContext.Propietarios.Where(s => s.Cedula.Contains(buscador)
                                                                || s.Nombre.Contains(buscador)
                                                                || s.Telefono.Contains(buscador)).ToList();
                DataTable dt = propietarios.ToDataTable();
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Propietario GetPropietarioById(int id)
        {
            using var dBContext = new AppDbContext();
            return dBContext.Propietarios.Find(id);
        }

        public void CreatePropietario(Propietario propietario)
        {
            using var dBContext = new AppDbContext();
            dBContext.Propietarios.Add(propietario);
            dBContext.SaveChanges();
        }

        public void UpdatePropietario(Propietario propietario)
        {
            using var dBContext = new AppDbContext();
            dBContext.Entry(propietario).State = EntityState.Modified;
            dBContext.SaveChanges();
        }

        public void DeletePropietario(int id)
        {
            using var dBContext = new AppDbContext();
            var propietario = dBContext.Propietarios.Find(id);
            if (propietario != null)
            {
                dBContext.Propietarios.Remove(propietario);
                dBContext.SaveChanges();
            }
        }
    }


    public static class ListtoDataTableConverter
    {
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}