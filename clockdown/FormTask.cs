using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;

namespace clockdown
{
    public partial class FormTask : Form
    {
        ArrayList Dias = new ArrayList();

        DeviceManipulator manipulator = new DeviceManipulator();
        public ZkemClient objZkeeper;
        Logs Registros = new Logs();

        string ipAddress;
        string port;
        string machineNumber;


        private void RaiseDeviceEvent(object sender, string actionType)
        {
            switch (actionType)
            {
                case UniversalStatic.acx_Disconnect:
                    {
                        ShowStatusBar("Dispositivo desconectado", true);
                        break;
                    }

                default:
                    break;
            }

        }



        private ArrayList AsignarSemana()
        {
            ArrayList Semana = new ArrayList();

            if (checkLun.Checked) { Semana.Add(1); }
            if (checkMar.Checked) { Semana.Add(2); }
            if (checkMie.Checked) { Semana.Add(3); }
            if (checkJue.Checked) { Semana.Add(4); }
            if (checkVie.Checked) { Semana.Add(5); }
            if (checkSab.Checked) { Semana.Add(6); }
            if (checkDom.Checked) { Semana.Add(7); }

            return Semana;
        }

        private DateTime AsignarHora()
        {
            string Hora = comboHora.Text;
            string Minuto = comboMinuto.Text;
            string HoraAsig = Hora + ":" + Minuto + ":00";
            var timeHms = Convert.ToDateTime(HoraAsig);
            return timeHms;

        }

        //Validacion para la ejecucion de la carga
        private bool Validar()
        {
            bool sem = Semanal();
            bool frec = EscogerFrec();

            if (frec == true || sem == true) { return true; } else { return false; }

        }


        //Validación del día de la semana para generar la carga
        private bool Semanal()
        {
            Dias = AsignarSemana();

            int Dia = 0;
            int Diactual = Convert.ToInt32(DateTime.Today.DayOfWeek);

            foreach (int val in Dias)

                if (val == Diactual)
                {
                    Dia++;
                }

            if (Dia > 0) { return true; } else { return false; }


        }

        //Validacion de la frecuencia para activar los casilleros de semana
        private bool EscogerFrec()
        {
            bool diario = false;

            switch (comboBox1.Text)
            {
                case "Diariamente":
                    groupBox1.Enabled = false;
                    diario = true;
                    break;

                case "Semanalmente":
                    groupBox1.Enabled = true;
                    diario = false;
                    break;
            }

            return diario;
        }

        public FormTask()
        {
            InitializeComponent();
        }

        private void FormTask_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            EscogerFrec();
            progressBar1.Visible = false;
           // tblMarcacionesTableAdapter.Fill(baseClockDataSet.TblMarcaciones);
            //tblMarcacionesDataGridView.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            bool validarDia = Validar();
            //Validar();
            string horaAsignada = AsignarHora().ToString();
            string hora = DateTime.Now.ToString();

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

            if (validarDia == true && horaAsignada == hora)
            {
                textBox1.Clear();
                MostrarLogs(Registros.Add("Tarea programada iniciada"));
                EjecutarTarea();
                CargarDatos();

            }


        }

        //Muestra logs en cuadro de texto
        private void MostrarLogs(string Texto)
        {

            textBox1.Text += Texto + "\r\n";

        }


        private void btnAplicar_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            MostrarLogs(Registros.Add("Tarea Descargar ejecutada a petición de usuario"));
            EjecutarTarea();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            MostrarLogs(Registros.Add("Tarea Cargar ejecutada a petición de usuario"));
            CargarDatos();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscogerFrec();
        }

        private bool ConectarReloj(string ipDir, string puerto, string maquina, string nombreMaq)
        {

            int portNumber = 4370;
            bool isValidIpA;
            bool IsDeviceConnected = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                ShowStatusBar(string.Empty, true);


                //Verifica que la información sea correcta y que el dispositivo esté respondiendo antes de conectar
                if (ipDir == string.Empty || puerto == string.Empty)
                    throw new Exception("La dirección IP y número de puerto son obligatorios !!");


                if (!int.TryParse(puerto, out portNumber))
                    throw new Exception("Número de puerto inválido");

                isValidIpA = UniversalStatic.ValidateIP(ipDir);


                if (!isValidIpA)
                    throw new Exception("La dirección IP del dispositivo no es válida !!");

                isValidIpA = UniversalStatic.PingTheDevice(ipDir);


                if (!isValidIpA)
                {
                    throw new Exception("El dispositivo " + ipDir + ":" + puerto + " no respondió!!");

                }


                objZkeeper = new ZkemClient(RaiseDeviceEvent);
                IsDeviceConnected = objZkeeper.Connect_Net(ipDir, portNumber);

                if (IsDeviceConnected)
                {
                    string deviceInfo = manipulator.FetchDeviceInfo(objZkeeper, int.Parse(maquina.Trim()));

                    MostrarLogs(Registros.Add("Dispositvo " + deviceInfo + " - " + nombreMaq + " - " + maquina + " - " + ipDir + ":" + puerto + " conectado exitosamente"));
                }

                this.Cursor = Cursors.Default;

                return true;
            }


            catch (Exception ex)
            {
                ShowStatusBar(ex.Message, false);
                MostrarLogs(Registros.Add(ex.Message));
                this.Cursor = Cursors.Default;

                return false;
            }


        }

        //Cambios en la etiqueta LblStatus
        public void ShowStatusBar(string message, bool type)
        {
            if (message.Trim() == string.Empty)
            {
                LblStatus.Visible = false;
                return;
            }

            LblStatus.Visible = true;
            LblStatus.Text = message;
            LblStatus.ForeColor = Color.White;

            if (type)
                LblStatus.BackColor = Color.FromArgb(79, 208, 154);
            else
                LblStatus.BackColor = Color.FromArgb(230, 112, 134);
        }


        private void EjecutarTarea()
        {
            //Recuperación de la info de dispositivos registrados
            //tblDispositivosTableAdapter.FillByEnabled(baseClockDataSet.TblDispositivos);
            machinesTableAdapter.FillByEnabled(att2000DataSet.Machines);

            foreach (DataRow fila in att2000DataSet.Machines)
            {
                //Asignación de valores para conectar
                ipAddress = fila[3].ToString();
                port = fila[5].ToString();
                machineNumber = fila[7].ToString();
                string nombre = fila[1].ToString();


                if (!ConectarReloj(ipAddress, port, machineNumber, nombre))
                    continue;
                if (!DescargarDatos())
                    continue;
            }

        }


        private int FiltrarMarcaciones(string Clave, OleDbConnection conect) {
            
            string filt = "SELECT count(*) FROM TblMarcaciones WHERE(MarcId = @clave)";
            using (OleDbCommand filtrar = new OleDbCommand(filt, conect))
            {
                filtrar.Parameters.AddWithValue("@clave", Clave);
                return Convert.ToInt32(filtrar.ExecuteScalar());
            }
            
        }
        private bool DescargarDatos()
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<MachineInfo> lstMachineInfo = manipulator.GetLogData(objZkeeper, int.Parse(machineNumber.Trim()));

                if (lstMachineInfo != null && lstMachineInfo.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    ShowStatusBar(string.Empty, true);
                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = lstMachineInfo.Count;
                    progressBar1.Value = 1;
                    progressBar1.Step = 1;

                    var ListDownloadInfo = new DataTable();
                    ListDownloadInfo.Columns.Add("Key", typeof(string));
                    ListDownloadInfo.Columns.Add("EnrollNumber", typeof(string));
                    ListDownloadInfo.Columns.Add("VerifyMode", typeof(int));
                    ListDownloadInfo.Columns.Add("InOutMode", typeof(int));
                    ListDownloadInfo.Columns.Add("DtRecord", typeof(string));
                    ListDownloadInfo.Columns.Add("Fecha", typeof(string));
                    ListDownloadInfo.Columns.Add("Hora", typeof(DateTime));
                    ListDownloadInfo.Columns.Add("WorkCode", typeof(int));
                    ListDownloadInfo.Columns.Add("status", typeof(bool));
                    ListDownloadInfo.Columns.Add("MachineNumber", typeof(string));

                    using (var conexion = LocalConn.GetConnection())

                    {
                        conexion.Open();//abre la conexion

                        foreach (MachineInfo fila in lstMachineInfo)
                        {

                            string Key = fila.KeyRecord;
                            string EnrollNumber1 = (fila.IndRegID).ToString();
                            int VerifyMode = fila.VerifyMode;
                            int InOutMode = fila.InOutMode;
                            string DtRecord = fila.DateTimeRecord;
                            string Fecha = fila.DateOnlyRecord.ToString("dd/MM/yyyy");
                            DateTime Hora = fila.TimeOnlyRecord;
                            int WorkCode = fila.WorkCode;
                                                        

                            if (FiltrarMarcaciones(Key, conexion) == 0)
                          
                            {
                                string conteo = FiltrarMarcaciones(Key, conexion).ToString();

                                try
                                {
                                    using (OleDbCommand ins = new OleDbCommand())
                                    {
                                        ins.Connection = conexion;
                                        ins.CommandType = CommandType.Text;
                                        ins.CommandText = "INSERT INTO TblMarcaciones ([MarcId],[MarcEmpClock],[MarcVerMode],[MarcInOutMode],[MarcRecord],[MarcFecha],[MarcHora],[MarcWorkCode],[MarcUploaded],[MarcMachine]) VALUES (?,?,?,?,?,?,?,?,?,?)";
                                        ins.Parameters.AddWithValue("@Id", Key);
                                        ins.Parameters.AddWithValue("@EmpClock", EnrollNumber1);
                                        ins.Parameters.AddWithValue("@VerMode", VerifyMode);
                                        ins.Parameters.AddWithValue("@InOutMode", InOutMode);
                                        ins.Parameters.AddWithValue("@Record", DtRecord);
                                        ins.Parameters.AddWithValue("@Fecha", Fecha);
                                        ins.Parameters.AddWithValue("@Hora", Hora);
                                        ins.Parameters.AddWithValue("@WorkCode", WorkCode);
                                        ins.Parameters.AddWithValue("@Uploaded", false);
                                        ins.Parameters.AddWithValue("@Machine", machineNumber);
                                        ins.ExecuteNonQuery();

                                    }
                                   
                                    ShowStatusBar("Agregado " + Key, true);
                                    progressBar1.PerformStep();
                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show(Ex.Message);
                                }
                            }
                            else
                            {
                                progressBar1.PerformStep();
                            }
                            
                        }

                        conexion.Close();//cierra la conexion
                    }
 
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    
                    //Eliminación de los registros de asistencia del reloj!!!

                     int idwErrorCode = 0;

                     objZkeeper.EnableDevice(int.Parse(machineNumber.Trim()), false);//disable the device
                     if (objZkeeper.ClearGLog(int.Parse(machineNumber.Trim())))
                     {
                         objZkeeper.RefreshData(int.Parse(machineNumber.Trim()));//the data in the device should be refreshed
                         MostrarLogs(Registros.Add("Todos los registros de asistencia fueron eliminados del terminal!"));
                     }
                     else
                     {
                         objZkeeper.GetLastError(ref idwErrorCode);
                         MostrarLogs(Registros.Add("Operación de eliminación fallida, Error=" + idwErrorCode.ToString()));
                     }
                     objZkeeper.EnableDevice(int.Parse(machineNumber.Trim()), true);//enable the device


                    Cursor = Cursors.Default;

                    MostrarLogs(Texto: Registros.Add(lstMachineInfo.Count + " registros encontrados en dispositivo  !!"));
                }
                else
                {
                    MostrarLogs(Texto: Registros.Add("No se encontraron registros en el dispositivo"));
                }
                objZkeeper.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                MostrarLogs(Texto: Registros.Add(ex.Message));
                objZkeeper.Disconnect();
                return false;
            }

        }

        private void CargarDatos()
        {

            //tblMarcacionesCedTableAdapter.FillByUploaded(baseClockDataSet.TblMarcacionesCed);
            marcacionesCedTableAdapter.FillByUploaded(att2000DataSet.DataTable1);

            if (att2000DataSet.DataTable1.Count > 0)
            {
                string idKey;
                string cedula;
                int verif;
                int inout;
                DateTime record;
                string fecha;
                DateTime hora;
                int workcode;
                bool uploaded;
                string maquina;

                using (var conexionInf = InformixConn.GetConnection())

                {
                    conexionInf.Open();//abre la conexion

                    foreach (DataRow fila in att2000DataSet.DataTable1.Rows)
                    {

                        try
                        {

                            idKey = fila[0].ToString();
                            cedula = fila[1].ToString();
                            verif = int.Parse(fila[2].ToString());
                            inout = int.Parse(fila[3].ToString());
                            record = DateTime.Parse(fila[4].ToString());
                            fecha = fila[5].ToString();
                            hora = DateTime.Parse(fila[6].ToString());
                            workcode = int.Parse(fila[7].ToString());
                            uploaded = bool.Parse(fila[8].ToString());
                            //idClock = int.Parse(fila[9].ToString());
                            maquina = fila[9].ToString();

                            //Se agregan registros al informix

                            using (OdbcCommand ins = new OdbcCommand())
                            {
                                ins.Connection = conexionInf;
                                ins.CommandType = CommandType.Text;
                                ins.CommandText = "INSERT INTO informix.saetiem (userid,checktime,checktyte,verifycode,sensorid,workcode,userextfmt,checkdate) VALUES (?,?,?,?,?,?,?,?)";
                                ins.Parameters.AddWithValue("Id", cedula);
                                ins.Parameters.AddWithValue("Hora", hora);
                                ins.Parameters.AddWithValue("InOutMode", inout);
                                ins.Parameters.AddWithValue("VerMode", verif);
                                ins.Parameters.AddWithValue("Machine", maquina);
                                ins.Parameters.AddWithValue("WorkCode", workcode);
                                ins.Parameters.AddWithValue("Exfmt", 0);
                                ins.Parameters.AddWithValue("Fecha", fecha);
                                ins.ExecuteNonQuery();

                            }

                            //saetiemTableAdapter.InsertQuery(cedula, hora, inout, verif, maquina, workcode, 0, fecha);

                            marcacionesTableAdapter.UpdateQueryKey(true, idKey);//actualiza el estado del registro

                            MostrarLogs(Registros.Add("insertado " + cedula + " " + fecha + " " + hora + " clave: " + idKey));

                        }
                        catch (Exception ex)
                        {
                            MostrarLogs(Registros.Add(ex.Message));
                        }

                    }
                    conexionInf.Close();//cierra la conexion
                }

            }
            else
            {
                MostrarLogs(Registros.Add("no se encontraron registros nuevos"));
            }

        }

        private void FormTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
                

    }
}
