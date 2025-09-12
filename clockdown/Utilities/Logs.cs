using System;
using System.IO;

namespace clockdown
{
    public class Logs
    {

        private string CrearRegistro(String data)
        {
            string horaLog = DateTime.Now.ToString();
            string regLog = horaLog + " - " + data;

            return regLog;
        }

        public string Path()
        {
            string path = Directory.GetCurrentDirectory() + "/Registros.txt";
            return path;
        }

        public string Add(String dato)
        {
            string linea = CrearRegistro(dato);
            string ruta = Path();
            StreamWriter Escribir = new StreamWriter(ruta, true);
            Escribir.WriteLine(linea);
            Escribir.Close();
            return linea;

        }
    }
}
