namespace Autos
{
    partial class frmAuto
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
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAcelerar = new System.Windows.Forms.Button();
            this.cmdFrenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVelocidad.ForeColor = System.Drawing.Color.Blue;
            this.lblVelocidad.Location = new System.Drawing.Point(56, 9);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(174, 106);
            this.lblVelocidad.TabIndex = 0;
            this.lblVelocidad.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "km/h";
            // 
            // cmdAcelerar
            // 
            this.cmdAcelerar.BackColor = System.Drawing.Color.Lime;
            this.cmdAcelerar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAcelerar.Location = new System.Drawing.Point(8, 177);
            this.cmdAcelerar.Name = "cmdAcelerar";
            this.cmdAcelerar.Size = new System.Drawing.Size(137, 50);
            this.cmdAcelerar.TabIndex = 2;
            this.cmdAcelerar.Text = "Acelerar";
            this.cmdAcelerar.UseVisualStyleBackColor = false;
            this.cmdAcelerar.Click += new System.EventHandler(this.cmdAcelerar_Click);
            // 
            // cmdFrenar
            // 
            this.cmdFrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdFrenar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdFrenar.Location = new System.Drawing.Point(151, 177);
            this.cmdFrenar.Name = "cmdFrenar";
            this.cmdFrenar.Size = new System.Drawing.Size(137, 50);
            this.cmdFrenar.TabIndex = 3;
            this.cmdFrenar.Text = "Frenar";
            this.cmdFrenar.UseVisualStyleBackColor = false;
            this.cmdFrenar.Click += new System.EventHandler(this.cmdFrenar_Click);
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 239);
            this.Controls.Add(this.cmdFrenar);
            this.Controls.Add(this.cmdAcelerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVelocidad);
            this.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "frmAuto";
            this.Text = "frmAuto";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVelocidad;
        private Label label2;
        private Button cmdAcelerar;
        private Button cmdFrenar;
    }
}