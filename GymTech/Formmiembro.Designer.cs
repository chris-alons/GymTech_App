namespace Administrador
{
    partial class Formmiembro
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
            this.txtmiembromostrar = new System.Windows.Forms.TextBox();
            this.txtdniconsultado = new System.Windows.Forms.TextBox();
            this.btnfechamembresia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsultartrainer = new System.Windows.Forms.Button();
            this.btnconsultarrutina = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmiembromostrar
            // 
            this.txtmiembromostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtmiembromostrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmiembromostrar.Location = new System.Drawing.Point(12, 222);
            this.txtmiembromostrar.Multiline = true;
            this.txtmiembromostrar.Name = "txtmiembromostrar";
            this.txtmiembromostrar.Size = new System.Drawing.Size(617, 24);
            this.txtmiembromostrar.TabIndex = 0;
            // 
            // txtdniconsultado
            // 
            this.txtdniconsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdniconsultado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdniconsultado.Location = new System.Drawing.Point(240, 102);
            this.txtdniconsultado.Name = "txtdniconsultado";
            this.txtdniconsultado.Size = new System.Drawing.Size(155, 21);
            this.txtdniconsultado.TabIndex = 1;
            // 
            // btnfechamembresia
            // 
            this.btnfechamembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfechamembresia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnfechamembresia.Location = new System.Drawing.Point(33, 142);
            this.btnfechamembresia.Name = "btnfechamembresia";
            this.btnfechamembresia.Size = new System.Drawing.Size(159, 50);
            this.btnfechamembresia.TabIndex = 2;
            this.btnfechamembresia.Text = "Consultar tipo y fecha de membresía";
            this.btnfechamembresia.UseVisualStyleBackColor = true;
            this.btnfechamembresia.Click += new System.EventHandler(this.btnfechamembresia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(157, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI:";
            // 
            // btnconsultartrainer
            // 
            this.btnconsultartrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnconsultartrainer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnconsultartrainer.Location = new System.Drawing.Point(250, 142);
            this.btnconsultartrainer.Name = "btnconsultartrainer";
            this.btnconsultartrainer.Size = new System.Drawing.Size(133, 50);
            this.btnconsultartrainer.TabIndex = 5;
            this.btnconsultartrainer.Text = "Consultar trainer";
            this.btnconsultartrainer.UseVisualStyleBackColor = true;
            this.btnconsultartrainer.Click += new System.EventHandler(this.btnconsultartrainer_Click);
            // 
            // btnconsultarrutina
            // 
            this.btnconsultarrutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnconsultarrutina.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnconsultarrutina.Location = new System.Drawing.Point(460, 142);
            this.btnconsultarrutina.Name = "btnconsultarrutina";
            this.btnconsultarrutina.Size = new System.Drawing.Size(133, 50);
            this.btnconsultarrutina.TabIndex = 6;
            this.btnconsultarrutina.Text = "Consultar rutina";
            this.btnconsultarrutina.UseVisualStyleBackColor = true;
            this.btnconsultarrutina.Click += new System.EventHandler(this.btnconsultarrutina_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 79);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // Formmiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconsultarrutina);
            this.Controls.Add(this.btnconsultartrainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfechamembresia);
            this.Controls.Add(this.txtdniconsultado);
            this.Controls.Add(this.txtmiembromostrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Formmiembro";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Formmiembro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtmiembromostrar;
        private TextBox txtdniconsultado;
        private Button btnfechamembresia;
        private Label label1;
        private Button btnconsultartrainer;
        private Button btnconsultarrutina;
        private Panel panel1;
        private Label label2;
    }
}