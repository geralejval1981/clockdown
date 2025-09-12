
namespace clockdown
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDom = new System.Windows.Forms.CheckBox();
            this.checkSab = new System.Windows.Forms.CheckBox();
            this.checkVie = new System.Windows.Forms.CheckBox();
            this.checkJue = new System.Windows.Forms.CheckBox();
            this.checkMie = new System.Windows.Forms.CheckBox();
            this.checkMar = new System.Windows.Forms.CheckBox();
            this.checkLun = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMinuto = new System.Windows.Forms.ComboBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblStatus = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSet1 = new clockdown.DataSet1();
            this.saetiem1TableAdapter = new clockdown.DataSet1TableAdapters.saetiem1TableAdapter();
            this.saetiemTableAdapter = new clockdown.DataSet1TableAdapters.saetiemTableAdapter();
            this.marcacionesTableAdapter = new clockdown.Att2000DataSetTableAdapters.MarcacionesTableAdapter();
            this.att2000DataSet = new clockdown.Att2000DataSet();
            this.marcacionesCedTableAdapter = new clockdown.Att2000DataSetTableAdapters.MarcacionesCedTableAdapter();
            this.machinesTableAdapter = new clockdown.Att2000DataSetTableAdapters.MachinesTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.att2000DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnSubir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboMinuto);
            this.panel1.Controls.Add(this.comboHora);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 100);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(464, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(676, 52);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(112, 28);
            this.btnSubir.TabIndex = 15;
            this.btnSubir.Text = "Carga Manual";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Registros del sistema";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(676, 18);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(112, 28);
            this.btnAplicar.TabIndex = 14;
            this.btnAplicar.Text = "Descarga Manual";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDom);
            this.groupBox1.Controls.Add(this.checkSab);
            this.groupBox1.Controls.Add(this.checkVie);
            this.groupBox1.Controls.Add(this.checkJue);
            this.groupBox1.Controls.Add(this.checkMie);
            this.groupBox1.Controls.Add(this.checkMar);
            this.groupBox1.Controls.Add(this.checkLun);
            this.groupBox1.Location = new System.Drawing.Point(228, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias";
            // 
            // checkDom
            // 
            this.checkDom.AutoSize = true;
            this.checkDom.Location = new System.Drawing.Point(170, 39);
            this.checkDom.Name = "checkDom";
            this.checkDom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkDom.Size = new System.Drawing.Size(48, 17);
            this.checkDom.TabIndex = 19;
            this.checkDom.Text = "Dom";
            this.checkDom.UseVisualStyleBackColor = true;
            // 
            // checkSab
            // 
            this.checkSab.AutoSize = true;
            this.checkSab.Location = new System.Drawing.Point(170, 16);
            this.checkSab.Name = "checkSab";
            this.checkSab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkSab.Size = new System.Drawing.Size(45, 17);
            this.checkSab.TabIndex = 18;
            this.checkSab.Text = "Sab";
            this.checkSab.UseVisualStyleBackColor = true;
            // 
            // checkVie
            // 
            this.checkVie.AutoSize = true;
            this.checkVie.Location = new System.Drawing.Point(112, 16);
            this.checkVie.Name = "checkVie";
            this.checkVie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkVie.Size = new System.Drawing.Size(41, 17);
            this.checkVie.TabIndex = 17;
            this.checkVie.Text = "Vie";
            this.checkVie.UseVisualStyleBackColor = true;
            // 
            // checkJue
            // 
            this.checkJue.AutoSize = true;
            this.checkJue.Location = new System.Drawing.Point(63, 39);
            this.checkJue.Name = "checkJue";
            this.checkJue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkJue.Size = new System.Drawing.Size(43, 17);
            this.checkJue.TabIndex = 16;
            this.checkJue.Text = "Jue";
            this.checkJue.UseVisualStyleBackColor = true;
            // 
            // checkMie
            // 
            this.checkMie.AutoSize = true;
            this.checkMie.Location = new System.Drawing.Point(63, 16);
            this.checkMie.Name = "checkMie";
            this.checkMie.Size = new System.Drawing.Size(43, 17);
            this.checkMie.TabIndex = 15;
            this.checkMie.Text = "Mie";
            this.checkMie.UseVisualStyleBackColor = true;
            // 
            // checkMar
            // 
            this.checkMar.AutoSize = true;
            this.checkMar.Location = new System.Drawing.Point(13, 39);
            this.checkMar.Name = "checkMar";
            this.checkMar.Size = new System.Drawing.Size(44, 17);
            this.checkMar.TabIndex = 14;
            this.checkMar.Text = "Mar";
            this.checkMar.UseVisualStyleBackColor = true;
            // 
            // checkLun
            // 
            this.checkLun.AutoSize = true;
            this.checkLun.Location = new System.Drawing.Point(13, 16);
            this.checkLun.Name = "checkLun";
            this.checkLun.Size = new System.Drawing.Size(44, 17);
            this.checkLun.TabIndex = 13;
            this.checkLun.Text = "Lun";
            this.checkLun.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minuto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frecuencia:";
            // 
            // comboMinuto
            // 
            this.comboMinuto.FormattingEnabled = true;
            this.comboMinuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboMinuto.Location = new System.Drawing.Point(583, 36);
            this.comboMinuto.Name = "comboMinuto";
            this.comboMinuto.Size = new System.Drawing.Size(39, 21);
            this.comboMinuto.TabIndex = 2;
            this.comboMinuto.Text = "00";
            // 
            // comboHora
            // 
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboHora.Location = new System.Drawing.Point(536, 36);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(39, 21);
            this.comboHora.TabIndex = 1;
            this.comboHora.Text = "01";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Diariamente",
            "Semanalmente"});
            this.comboBox1.Location = new System.Drawing.Point(34, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Diariamente";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblStatus);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(817, 33);
            this.panel2.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(20, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(554, 33);
            this.LblStatus.TabIndex = 2;
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Location = new System.Drawing.Point(574, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(150, 33);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Location = new System.Drawing.Point(724, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 33);
            this.lblHora.TabIndex = 0;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(817, 377);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(20, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(777, 377);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saetiem1TableAdapter
            // 
            this.saetiem1TableAdapter.ClearBeforeFill = true;
            // 
            // saetiemTableAdapter
            // 
            this.saetiemTableAdapter.ClearBeforeFill = true;
            // 
            // marcacionesTableAdapter
            // 
            this.marcacionesTableAdapter.ClearBeforeFill = true;
            // 
            // att2000DataSet
            // 
            this.att2000DataSet.DataSetName = "Att2000DataSet";
            this.att2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcacionesCedTableAdapter
            // 
            this.marcacionesCedTableAdapter.ClearBeforeFill = true;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga programada dispositivos Biosystem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTask_FormClosed);
            this.Load += new System.EventHandler(this.FormTask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.att2000DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboMinuto;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkDom;
        private System.Windows.Forms.CheckBox checkSab;
        private System.Windows.Forms.CheckBox checkVie;
        private System.Windows.Forms.CheckBox checkJue;
        private System.Windows.Forms.CheckBox checkMie;
        private System.Windows.Forms.CheckBox checkMar;
        private System.Windows.Forms.CheckBox checkLun;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.saetiem1TableAdapter saetiem1TableAdapter;
        private DataSet1TableAdapters.saetiemTableAdapter saetiemTableAdapter;
        private Att2000DataSetTableAdapters.MarcacionesTableAdapter marcacionesTableAdapter;
        private Att2000DataSet att2000DataSet;
        private Att2000DataSetTableAdapters.MarcacionesCedTableAdapter marcacionesCedTableAdapter;
        private Att2000DataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
    }
}