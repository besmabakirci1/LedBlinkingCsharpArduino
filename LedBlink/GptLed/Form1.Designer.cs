namespace GptLed
{
    partial class Form1
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
            this.btnRedOn = new System.Windows.Forms.Button();
            this.btnRedOff = new System.Windows.Forms.Button();
            this.btnGreenOn = new System.Windows.Forms.Button();
            this.btnGreenOff = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnRedOn
            // 
            this.btnRedOn.AccessibleName = "";
            this.btnRedOn.Location = new System.Drawing.Point(169, 231);
            this.btnRedOn.Name = "btnRedOn";
            this.btnRedOn.Size = new System.Drawing.Size(75, 23);
            this.btnRedOn.TabIndex = 0;
            this.btnRedOn.Text = "RedOn";
            this.btnRedOn.UseVisualStyleBackColor = true;
            this.btnRedOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRedOff
            // 
            this.btnRedOff.AccessibleName = "btnRedOff";
            this.btnRedOff.Location = new System.Drawing.Point(275, 231);
            this.btnRedOff.Name = "btnRedOff";
            this.btnRedOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRedOff.Size = new System.Drawing.Size(75, 23);
            this.btnRedOff.TabIndex = 1;
            this.btnRedOff.Text = "RedOff";
            this.btnRedOff.UseVisualStyleBackColor = true;
            this.btnRedOff.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGreenOn
            // 
            this.btnGreenOn.AccessibleName = "";
            this.btnGreenOn.Location = new System.Drawing.Point(409, 231);
            this.btnGreenOn.Name = "btnGreenOn";
            this.btnGreenOn.Size = new System.Drawing.Size(75, 23);
            this.btnGreenOn.TabIndex = 2;
            this.btnGreenOn.Text = "GreenOn";
            this.btnGreenOn.UseVisualStyleBackColor = true;
            this.btnGreenOn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGreenOff
            // 
            this.btnGreenOff.AccessibleName = "";
            this.btnGreenOff.Location = new System.Drawing.Point(511, 231);
            this.btnGreenOff.Name = "btnGreenOff";
            this.btnGreenOff.Size = new System.Drawing.Size(75, 23);
            this.btnGreenOff.TabIndex = 3;
            this.btnGreenOff.Text = "GreenOff";
            this.btnGreenOff.UseVisualStyleBackColor = true;
            this.btnGreenOff.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleDescription = "";
            this.lblStatus.AccessibleName = "";
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(315, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(124, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "durum bilgisi bekleniyor...";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGreenOff);
            this.Controls.Add(this.btnGreenOn);
            this.Controls.Add(this.btnRedOff);
            this.Controls.Add(this.btnRedOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRedOn;
        private System.Windows.Forms.Button btnRedOff;
        private System.Windows.Forms.Button btnGreenOn;
        private System.Windows.Forms.Button btnGreenOff;
        private System.Windows.Forms.Label lblStatus;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

