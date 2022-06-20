namespace Administrador
{
    partial class Formtrainer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrainerselec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtalumselec = new System.Windows.Forms.TextBox();
            this.btnselectra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cborutina1 = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cborutina2 = new System.Windows.Forms.ComboBox();
            this.btnasigrutin = new System.Windows.Forms.Button();
            this.btnregistrarrutina = new System.Windows.Forms.Button();
            this.cboasignarrutina = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbomaquina = new System.Windows.Forms.ComboBox();
            this.lstmaquinas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione trainer:";
            // 
            // cboTrainerselec
            // 
            this.cboTrainerselec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTrainerselec.FormattingEnabled = true;
            this.cboTrainerselec.Items.AddRange(new object[] {
            "Marcelo García",
            "Antonio Herrera"});
            this.cboTrainerselec.Location = new System.Drawing.Point(125, 25);
            this.cboTrainerselec.Name = "cboTrainerselec";
            this.cboTrainerselec.Size = new System.Drawing.Size(151, 23);
            this.cboTrainerselec.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de alumnos:";
            // 
            // txtalumselec
            // 
            this.txtalumselec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtalumselec.Location = new System.Drawing.Point(6, 126);
            this.txtalumselec.Multiline = true;
            this.txtalumselec.Name = "txtalumselec";
            this.txtalumselec.Size = new System.Drawing.Size(421, 219);
            this.txtalumselec.TabIndex = 6;
            // 
            // btnselectra
            // 
            this.btnselectra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnselectra.Location = new System.Drawing.Point(116, 60);
            this.btnselectra.Name = "btnselectra";
            this.btnselectra.Size = new System.Drawing.Size(82, 24);
            this.btnselectra.TabIndex = 7;
            this.btnselectra.Text = "Seleccionar";
            this.btnselectra.UseVisualStyleBackColor = true;
            this.btnselectra.Click += new System.EventHandler(this.btnselectra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI Alumno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nueva rutina:";
            // 
            // cborutina1
            // 
            this.cborutina1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cborutina1.FormattingEnabled = true;
            this.cborutina1.Items.AddRange(new object[] {
            "Pecho",
            "Espalda",
            "Biceps",
            "Triceps",
            "Hombro",
            "Pierna"});
            this.cborutina1.Location = new System.Drawing.Point(94, 25);
            this.cborutina1.Name = "cborutina1";
            this.cborutina1.Size = new System.Drawing.Size(112, 23);
            this.cborutina1.TabIndex = 11;
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDNI.Location = new System.Drawing.Point(113, 109);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(126, 23);
            this.txtDNI.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(212, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "+";
            // 
            // cborutina2
            // 
            this.cborutina2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cborutina2.FormattingEnabled = true;
            this.cborutina2.Items.AddRange(new object[] {
            "Pecho",
            "Espalda",
            "Biceps",
            "Triceps",
            "Hombro",
            "Pierna"});
            this.cborutina2.Location = new System.Drawing.Point(238, 25);
            this.cborutina2.Name = "cborutina2";
            this.cborutina2.Size = new System.Drawing.Size(112, 23);
            this.cborutina2.TabIndex = 14;
            // 
            // btnasigrutin
            // 
            this.btnasigrutin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnasigrutin.Location = new System.Drawing.Point(254, 138);
            this.btnasigrutin.Name = "btnasigrutin";
            this.btnasigrutin.Size = new System.Drawing.Size(112, 30);
            this.btnasigrutin.TabIndex = 15;
            this.btnasigrutin.Text = "Asignar rutina";
            this.btnasigrutin.UseVisualStyleBackColor = true;
            this.btnasigrutin.Click += new System.EventHandler(this.btnasigrutin_Click);
            // 
            // btnregistrarrutina
            // 
            this.btnregistrarrutina.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnregistrarrutina.Location = new System.Drawing.Point(159, 54);
            this.btnregistrarrutina.Name = "btnregistrarrutina";
            this.btnregistrarrutina.Size = new System.Drawing.Size(112, 30);
            this.btnregistrarrutina.TabIndex = 16;
            this.btnregistrarrutina.Text = "Registrar rutina";
            this.btnregistrarrutina.UseVisualStyleBackColor = true;
            this.btnregistrarrutina.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboasignarrutina
            // 
            this.cboasignarrutina.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboasignarrutina.FormattingEnabled = true;
            this.cboasignarrutina.Location = new System.Drawing.Point(113, 143);
            this.cboasignarrutina.Name = "cboasignarrutina";
            this.cboasignarrutina.Size = new System.Drawing.Size(126, 23);
            this.cboasignarrutina.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(44, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rutina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(31, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Máquina:";
            // 
            // cbomaquina
            // 
            this.cbomaquina.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbomaquina.FormattingEnabled = true;
            this.cbomaquina.Items.AddRange(new object[] {
            "Pecho",
            "Espalda",
            "Biceps",
            "Triceps",
            "Hombro",
            "Pierna"});
            this.cbomaquina.Location = new System.Drawing.Point(113, 180);
            this.cbomaquina.Name = "cbomaquina";
            this.cbomaquina.Size = new System.Drawing.Size(126, 23);
            this.cbomaquina.TabIndex = 22;
            // 
            // lstmaquinas
            // 
            this.lstmaquinas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstmaquinas.FormattingEnabled = true;
            this.lstmaquinas.ItemHeight = 15;
            this.lstmaquinas.Location = new System.Drawing.Point(62, 223);
            this.lstmaquinas.Name = "lstmaquinas";
            this.lstmaquinas.Size = new System.Drawing.Size(155, 139);
            this.lstmaquinas.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstmaquinas);
            this.groupBox1.Controls.Add(this.cbomaquina);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboasignarrutina);
            this.groupBox1.Controls.Add(this.btnregistrarrutina);
            this.groupBox1.Controls.Add(this.btnasigrutin);
            this.groupBox1.Controls.Add(this.cborutina2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.cborutina1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(448, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 415);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutina y máquina";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnselectra);
            this.groupBox2.Controls.Add(this.txtalumselec);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboTrainerselec);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 415);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trainer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 74);
            this.panel1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trainer";
            // 
            // Formtrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formtrainer";
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.Formtrainer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox cboTrainerselec;
        private Label label2;
        private TextBox txtalumselec;
        private Button btnselectra;
        private Label label3;
        private Label label4;
        private ComboBox cborutina1;
        private TextBox txtDNI;
        private Label label5;
        private ComboBox cborutina2;
        private Button btnasigrutin;
        private Button btnregistrarrutina;
        private ComboBox cboasignarrutina;
        private Label label6;
        private Label label7;
        private ComboBox cbomaquina;
        private ListBox lstmaquinas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label8;
    }
}