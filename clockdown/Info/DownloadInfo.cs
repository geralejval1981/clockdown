using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;



namespace clockdown
{
    public class DownloadInfo
    {
        public string Key { get; set; }
        public string EnrollNumber { get; set; }
        public int VerifyMode { get; set; }
        public int InOutMode { get; set; }
        public string DtRecord { get; set; }
        public string Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int WorkCode { get; set; }
        public bool Status {
            get { return false; }
        }
        public string MachineNumber { get; set; }

        //metodos
        public void insertMassiveData(IEnumerable<DownloadInfo> detailsList) {
            //crear tabla
            var tabla = new DataTable();
            tabla.Columns.Add("key", typeof(string));
            tabla.Columns.Add("enrollNumber", typeof(string));
            tabla.Columns.Add("verifyMode", typeof(int));
            tabla.Columns.Add("inOutMode", typeof(int));
            tabla.Columns.Add("dtRecord", typeof(string));
            tabla.Columns.Add("fecha", typeof(string));
            tabla.Columns.Add("hora", typeof(DateTime));
            tabla.Columns.Add("workCode", typeof(int));
            tabla.Columns.Add("status", typeof(bool));
            tabla.Columns.Add("machineNumber", typeof(string));

            foreach (var itemDetail in detailsList) {
                tabla.Rows.Add(new object[]
                    {
                        itemDetail.Key,
                        itemDetail.EnrollNumber,
                        itemDetail.VerifyMode,
                        itemDetail.InOutMode,
                        itemDetail.DtRecord,
                        itemDetail.Fecha,
                        itemDetail.Hora,
                        itemDetail.WorkCode,
                        itemDetail.Status,
                        itemDetail.MachineNumber

                    });
            
            }

            //insertar a la base
            using (var conexion = LocalConn.GetConnection())
            {
                conexion.Open();
                using (OleDbTransaction transaccion = conexion.BeginTransaction())
                {
                    //using (OleDbCommand cmd = new OleDbCommand(string,conexion,transaccion))
                    { 

                    }
                }
            }

        }

                
    }
}
