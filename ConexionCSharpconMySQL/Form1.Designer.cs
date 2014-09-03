namespace ConexionCSharpconMySQL
{
    partial class Conexion
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
            this.lblOfficeID = new System.Windows.Forms.Label();
            this.lbl2OfficeName = new System.Windows.Forms.Label();
            this.lbl3DirectorId = new System.Windows.Forms.Label();
            this.TxtOfficeId = new System.Windows.Forms.TextBox();
            this.txtOfficeName = new System.Windows.Forms.TextBox();
            this.txtDirectorID = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOfficeID
            // 
            this.lblOfficeID.AutoSize = true;
            this.lblOfficeID.Location = new System.Drawing.Point(24, 55);
            this.lblOfficeID.Name = "lblOfficeID";
            this.lblOfficeID.Size = new System.Drawing.Size(46, 13);
            this.lblOfficeID.TabIndex = 0;
            this.lblOfficeID.Text = "OfficeID";
            // 
            // lbl2OfficeName
            // 
            this.lbl2OfficeName.AutoSize = true;
            this.lbl2OfficeName.Location = new System.Drawing.Point(27, 101);
            this.lbl2OfficeName.Name = "lbl2OfficeName";
            this.lbl2OfficeName.Size = new System.Drawing.Size(63, 13);
            this.lbl2OfficeName.TabIndex = 1;
            this.lbl2OfficeName.Text = "OfficeName";
            // 
            // lbl3DirectorId
            // 
            this.lbl3DirectorId.AutoSize = true;
            this.lbl3DirectorId.Location = new System.Drawing.Point(27, 141);
            this.lbl3DirectorId.Name = "lbl3DirectorId";
            this.lbl3DirectorId.Size = new System.Drawing.Size(55, 13);
            this.lbl3DirectorId.TabIndex = 2;
            this.lbl3DirectorId.Text = "DirectorID";
            // 
            // TxtOfficeId
            // 
            this.TxtOfficeId.Location = new System.Drawing.Point(115, 55);
            this.TxtOfficeId.Name = "TxtOfficeId";
            this.TxtOfficeId.Size = new System.Drawing.Size(100, 20);
            this.TxtOfficeId.TabIndex = 3;
            // 
            // txtOfficeName
            // 
            this.txtOfficeName.Location = new System.Drawing.Point(115, 93);
            this.txtOfficeName.Name = "txtOfficeName";
            this.txtOfficeName.Size = new System.Drawing.Size(100, 20);
            this.txtOfficeName.TabIndex = 4;
            // 
            // txtDirectorID
            // 
            this.txtDirectorID.Location = new System.Drawing.Point(115, 138);
            this.txtDirectorID.Name = "txtDirectorID";
            this.txtDirectorID.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorID.TabIndex = 5;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(83, 196);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtDirectorID);
            this.Controls.Add(this.txtOfficeName);
            this.Controls.Add(this.TxtOfficeId);
            this.Controls.Add(this.lbl3DirectorId);
            this.Controls.Add(this.lbl2OfficeName);
            this.Controls.Add(this.lblOfficeID);
            this.Name = "Conexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfficeID;
        private System.Windows.Forms.Label lbl2OfficeName;
        private System.Windows.Forms.Label lbl3DirectorId;
        private System.Windows.Forms.TextBox TxtOfficeId;
        private System.Windows.Forms.TextBox txtOfficeName;
        private System.Windows.Forms.TextBox txtDirectorID;
        private System.Windows.Forms.Button btnConectar;
    }
}

