using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using apiexamen.dll;

namespace CPob
{
    public class CPExamenes
    {
        private Apiexamen objCPE = new Apiexamen();

        public DataTable MostrarEx()
        {
            DataTable tabla = new DataTable();
            tabla = objCPE.GetD();
            return tabla;
        }
        public void InsertEx(string idExamen, string Nombre, string Descripcion)
        {
            objCPE.PutD(Convert.ToInt32(idExamen), Nombre, Descripcion);
        }
        public void UpdateEx(string idExamen, string Nombre, string Descripcion)
        {
            objCPE.UpdateD(Convert.ToInt32(idExamen), Nombre, Descripcion);
        }
        public void DeleteEx(string idExamen)
        {
            objCPE.UpdateD(Convert.ToInt32(idExamen));
        }
        public DataTable MostrarED(string Nombre, string Descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objCPE.ShowED(Nombre, Descripcion);
            return tabla;
        }
    }
}
