namespace GUI
{
    partial class FrmRegistroRiego
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
            this.dgvRegistroRiego = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroRiego)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroRiego
            // 
            this.dgvRegistroRiego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroRiego.Location = new System.Drawing.Point(34, 21);
            this.dgvRegistroRiego.Name = "dgvRegistroRiego";
            this.dgvRegistroRiego.RowHeadersWidth = 51;
            this.dgvRegistroRiego.RowTemplate.Height = 24;
            this.dgvRegistroRiego.Size = new System.Drawing.Size(725, 349);
            this.dgvRegistroRiego.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(330, 391);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 47);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistroRiego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dgvRegistroRiego);
            this.Name = "FrmRegistroRiego";
            this.Text = "FrmRegistroRiego";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroRiego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroRiego;
        private System.Windows.Forms.Button btnRefrescar;
    }
}