namespace Calcular_promedio
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PtbTop = new System.Windows.Forms.PictureBox();
            this.BtnWorker = new System.Windows.Forms.Button();
            this.LblTittle = new System.Windows.Forms.Label();
            this.LblN1 = new System.Windows.Forms.Label();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.LblN2 = new System.Windows.Forms.Label();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.LblN3 = new System.Windows.Forms.Label();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.LblAverage = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnAverage = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTop)).BeginInit();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PtbTop
            // 
            this.PtbTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.PtbTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PtbTop.Location = new System.Drawing.Point(0, 0);
            this.PtbTop.Name = "PtbTop";
            this.PtbTop.Size = new System.Drawing.Size(400, 5);
            this.PtbTop.TabIndex = 0;
            this.PtbTop.TabStop = false;
            // 
            // BtnWorker
            // 
            this.BtnWorker.BackColor = System.Drawing.Color.White;
            this.BtnWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.BtnWorker.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWorker.Location = new System.Drawing.Point(12, 380);
            this.BtnWorker.Name = "BtnWorker";
            this.BtnWorker.Size = new System.Drawing.Size(94, 28);
            this.BtnWorker.TabIndex = 14;
            this.BtnWorker.Text = "Trabajador";
            this.BtnWorker.UseVisualStyleBackColor = false;
            // 
            // LblTittle
            // 
            this.LblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTittle.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.LblTittle.Location = new System.Drawing.Point(0, 33);
            this.LblTittle.Name = "LblTittle";
            this.LblTittle.Size = new System.Drawing.Size(400, 42);
            this.LblTittle.TabIndex = 2;
            this.LblTittle.Text = "Nota promedio";
            this.LblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblN1
            // 
            this.LblN1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN1.Location = new System.Drawing.Point(29, 102);
            this.LblN1.Name = "LblN1";
            this.LblN1.Size = new System.Drawing.Size(160, 30);
            this.LblN1.TabIndex = 3;
            this.LblN1.Text = "Nota no. 1:";
            this.LblN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtN1
            // 
            this.TxtN1.Location = new System.Drawing.Point(195, 102);
            this.TxtN1.Multiline = true;
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(160, 30);
            this.TxtN1.TabIndex = 4;
            this.TxtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblN2
            // 
            this.LblN2.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN2.Location = new System.Drawing.Point(29, 155);
            this.LblN2.Name = "LblN2";
            this.LblN2.Size = new System.Drawing.Size(160, 30);
            this.LblN2.TabIndex = 5;
            this.LblN2.Text = "Nota no. 2:";
            this.LblN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtN2
            // 
            this.TxtN2.Location = new System.Drawing.Point(195, 155);
            this.TxtN2.Multiline = true;
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(160, 30);
            this.TxtN2.TabIndex = 6;
            this.TxtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblN3
            // 
            this.LblN3.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN3.Location = new System.Drawing.Point(29, 215);
            this.LblN3.Name = "LblN3";
            this.LblN3.Size = new System.Drawing.Size(160, 30);
            this.LblN3.TabIndex = 7;
            this.LblN3.Text = "Nota no. 3:";
            this.LblN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtN3
            // 
            this.TxtN3.Location = new System.Drawing.Point(195, 215);
            this.TxtN3.Multiline = true;
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(160, 30);
            this.TxtN3.TabIndex = 8;
            this.TxtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAverage
            // 
            this.LblAverage.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAverage.Location = new System.Drawing.Point(29, 327);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(160, 30);
            this.LblAverage.TabIndex = 9;
            this.LblAverage.Text = "Nota promedio:";
            this.LblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(195, 327);
            this.TxtAverage.Multiline = true;
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(160, 30);
            this.TxtAverage.TabIndex = 10;
            this.TxtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Leelawadee UI", 7.8F);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.LblName.Location = new System.Drawing.Point(225, 378);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(160, 30);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Aarón Flores Pasos";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BtnAverage
            // 
            this.BtnAverage.BackColor = System.Drawing.Color.White;
            this.BtnAverage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.BtnAverage.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAverage.Location = new System.Drawing.Point(48, 273);
            this.BtnAverage.Name = "BtnAverage";
            this.BtnAverage.Size = new System.Drawing.Size(94, 28);
            this.BtnAverage.TabIndex = 2;
            this.BtnAverage.Text = "Promedio";
            this.BtnAverage.UseVisualStyleBackColor = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.White;
            this.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.BtnReset.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(160, 273);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(94, 28);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reinicio";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnLeave
            // 
            this.BtnLeave.BackColor = System.Drawing.Color.White;
            this.BtnLeave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.BtnLeave.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeave.Location = new System.Drawing.Point(272, 273);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(94, 28);
            this.BtnLeave.TabIndex = 13;
            this.BtnLeave.Text = "Salir";
            this.BtnLeave.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::Calcular_promedio.Properties.Resources.Close;
            this.BtnClose.Location = new System.Drawing.Point(366, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 28);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Image = global::Calcular_promedio.Properties.Resources.Min;
            this.BtnMin.Location = new System.Drawing.Point(334, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(28, 28);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.UseVisualStyleBackColor = true;
            // 
            // PnlTop
            // 
            this.PnlTop.Controls.Add(this.BtnMin);
            this.PnlTop.Controls.Add(this.BtnClose);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 5);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(400, 28);
            this.PnlTop.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.BtnWorker);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAverage);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.TxtN3);
            this.Controls.Add(this.LblN3);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.LblN2);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.LblN1);
            this.Controls.Add(this.LblTittle);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.PtbTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PtbTop)).EndInit();
            this.PnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbTop;
        private System.Windows.Forms.Button BtnWorker;
        private System.Windows.Forms.Label LblTittle;
        private System.Windows.Forms.Label LblN1;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label LblN2;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.Label LblN3;
        private System.Windows.Forms.TextBox TxtN3;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnAverage;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnLeave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Panel PnlTop;
    }
}

