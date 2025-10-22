namespace GUI
{
    partial class FrmConfigurar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nudHumedadMaxima = new System.Windows.Forms.NumericUpDown();
            this.nudHumedadMinima = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPlantas = new System.Windows.Forms.TabPage();
            this.tabListadoPlantas = new System.Windows.Forms.TabPage();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumedadMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumedadMinima)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabPlantas.SuspendLayout();
            this.tabListadoPlantas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.nudHumedadMaxima);
            this.panel1.Controls.Add(this.nudHumedadMinima);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 348);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 57);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar por ID";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // nudHumedadMaxima
            // 
            this.nudHumedadMaxima.Location = new System.Drawing.Point(347, 158);
            this.nudHumedadMaxima.Name = "nudHumedadMaxima";
            this.nudHumedadMaxima.Size = new System.Drawing.Size(199, 22);
            this.nudHumedadMaxima.TabIndex = 11;
            // 
            // nudHumedadMinima
            // 
            this.nudHumedadMinima.Location = new System.Drawing.Point(347, 116);
            this.nudHumedadMinima.Name = "nudHumedadMinima";
            this.nudHumedadMinima.Size = new System.Drawing.Size(199, 22);
            this.nudHumedadMinima.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(101, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 57);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(347, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(347, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(199, 22);
            this.txtId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOTA: humedad expresada en porcentajes ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Humedad máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Humedad minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPlantas);
            this.tabControl1.Controls.Add(this.tabListadoPlantas);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(80, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 362);
            this.tabControl1.TabIndex = 2;
            // 
            // TabPlantas
            // 
            this.TabPlantas.Controls.Add(this.panel1);
            this.TabPlantas.Location = new System.Drawing.Point(4, 25);
            this.TabPlantas.Name = "TabPlantas";
            this.TabPlantas.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlantas.Size = new System.Drawing.Size(572, 333);
            this.TabPlantas.TabIndex = 0;
            this.TabPlantas.Text = "Añadir Planta";
            this.TabPlantas.UseVisualStyleBackColor = true;
            // 
            // tabListadoPlantas
            // 
            this.tabListadoPlantas.Controls.Add(this.btnSeleccionar);
            this.tabListadoPlantas.Controls.Add(this.dgvPlantas);
            this.tabListadoPlantas.Location = new System.Drawing.Point(4, 25);
            this.tabListadoPlantas.Name = "tabListadoPlantas";
            this.tabListadoPlantas.Padding = new System.Windows.Forms.Padding(3);
            this.tabListadoPlantas.Size = new System.Drawing.Size(572, 333);
            this.tabListadoPlantas.TabIndex = 1;
            this.tabListadoPlantas.Text = "Listado Plantas";
            this.tabListadoPlantas.UseVisualStyleBackColor = true;
            this.tabListadoPlantas.Enter += new System.EventHandler(this.tabListadoPlantas_Enter);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(201, 259);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(150, 45);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvPlantas
            // 
            this.dgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantas.Location = new System.Drawing.Point(0, 0);
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.RowHeadersWidth = 51;
            this.dgvPlantas.RowTemplate.Height = 24;
            this.dgvPlantas.Size = new System.Drawing.Size(571, 235);
            this.dgvPlantas.TabIndex = 0;
            this.dgvPlantas.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.nudArea);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(572, 333);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Definir Parametros";
            // 
            // nudArea
            // 
            this.nudArea.Location = new System.Drawing.Point(354, 49);
            this.nudArea.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(127, 22);
            this.nudArea.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Placeholder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "No hay nada acá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Area (m^2)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConfigurar";
            this.Text = "FrmConfigurar";
            this.Load += new System.EventHandler(this.FrmConfigurar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumedadMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumedadMinima)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabPlantas.ResumeLayout(false);
            this.TabPlantas.PerformLayout();
            this.tabListadoPlantas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPlantas;
        private System.Windows.Forms.TabPage tabListadoPlantas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.NumericUpDown nudHumedadMaxima;
        private System.Windows.Forms.NumericUpDown nudHumedadMinima;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.Button btnEliminar;
    }
}