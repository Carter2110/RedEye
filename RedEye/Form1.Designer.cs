namespace RedEye
{
    partial class Main
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
            this.lblBTConfig = new System.Windows.Forms.Label();
            this.lblAvailPorts = new System.Windows.Forms.Label();
            this.btnPair = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.serialPortx = new System.IO.Ports.SerialPort(this.components);
            this.portBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBTConfig
            // 
            this.lblBTConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBTConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTConfig.Location = new System.Drawing.Point(0, 0);
            this.lblBTConfig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBTConfig.Name = "lblBTConfig";
            this.lblBTConfig.Size = new System.Drawing.Size(402, 36);
            this.lblBTConfig.TabIndex = 0;
            this.lblBTConfig.Text = "Bluetooth Configuration";
            this.lblBTConfig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAvailPorts
            // 
            this.lblAvailPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailPorts.Location = new System.Drawing.Point(0, 87);
            this.lblAvailPorts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailPorts.Name = "lblAvailPorts";
            this.lblAvailPorts.Size = new System.Drawing.Size(402, 23);
            this.lblAvailPorts.TabIndex = 1;
            this.lblAvailPorts.Text = "Available Ports:";
            this.lblAvailPorts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPair
            // 
            this.btnPair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPair.Location = new System.Drawing.Point(124, 352);
            this.btnPair.Margin = new System.Windows.Forms.Padding(2);
            this.btnPair.Name = "btnPair";
            this.btnPair.Size = new System.Drawing.Size(150, 50);
            this.btnPair.TabIndex = 17;
            this.btnPair.Text = "Pair";
            this.btnPair.UseVisualStyleBackColor = false;
            this.btnPair.Click += new System.EventHandler(this.btnPair_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 469);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(218, 0, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(402, 0);
            this.flowLayoutPanel2.TabIndex = 18;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // serialPortx
            // 
            this.serialPortx.PortName = "COM3";
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(137, 113);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 21);
            this.portBox.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(402, 469);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblAvailPorts);
            this.Controls.Add(this.lblBTConfig);
            this.Controls.Add(this.btnPair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Daedelus";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBTConfig;
        private System.Windows.Forms.Label lblAvailPorts;
        private System.Windows.Forms.Button btnPair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.IO.Ports.SerialPort serialPortx;
        private System.Windows.Forms.ComboBox portBox;
    }
}

