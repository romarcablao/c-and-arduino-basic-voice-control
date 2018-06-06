namespace Voice_Controller_Color_Changer_Arduino
{
    partial class frmMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bntColor = new System.Windows.Forms.Button();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.bntColor);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 550);
            this.pnlHeader.TabIndex = 0;
            // 
            // bntColor
            // 
            this.bntColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntColor.FlatAppearance.BorderSize = 0;
            this.bntColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntColor.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntColor.ForeColor = System.Drawing.Color.White;
            this.bntColor.Location = new System.Drawing.Point(0, 0);
            this.bntColor.Name = "bntColor";
            this.bntColor.Size = new System.Drawing.Size(1000, 550);
            this.bntColor.TabIndex = 0;
            this.bntColor.Text = "COLOR CHANGER";
            this.bntColor.UseVisualStyleBackColor = true;
            this.bntColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bntColor_MouseDown);
            this.bntColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bntColor_MouseMove);
            this.bntColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bntColor_MouseUp);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COLOR CHANGER";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button bntColor;
        private System.IO.Ports.SerialPort serialPortArduino;
    }
}

