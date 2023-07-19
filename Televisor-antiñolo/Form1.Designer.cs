
namespace Televisor_antiñolo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnBrow = new System.Windows.Forms.Button();
            this.btnNumer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBajaCanal = new System.Windows.Forms.Button();
            this.btnSubeCanal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBajaVol = new System.Windows.Forms.Button();
            this.btnSubeVol = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.PictureBox();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblMute = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.btnBrow);
            this.panel1.Controls.Add(this.btnNumer);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnBajaCanal);
            this.panel1.Controls.Add(this.btnSubeCanal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBajaVol);
            this.panel1.Controls.Add(this.btnSubeVol);
            this.panel1.Controls.Add(this.btnPower);
            this.panel1.Location = new System.Drawing.Point(970, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 284);
            this.panel1.TabIndex = 3;
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMute.BackgroundImage")));
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMute.Enabled = false;
            this.btnMute.ForeColor = System.Drawing.Color.White;
            this.btnMute.Location = new System.Drawing.Point(57, 188);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(30, 31);
            this.btnMute.TabIndex = 11;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnBrow
            // 
            this.btnBrow.BackColor = System.Drawing.Color.White;
            this.btnBrow.Enabled = false;
            this.btnBrow.ForeColor = System.Drawing.Color.Red;
            this.btnBrow.Location = new System.Drawing.Point(35, 225);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.Size = new System.Drawing.Size(75, 23);
            this.btnBrow.TabIndex = 10;
            this.btnBrow.Text = "NETFLIX";
            this.btnBrow.UseVisualStyleBackColor = false;
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click);
            // 
            // btnNumer
            // 
            this.btnNumer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNumer.BackgroundImage")));
            this.btnNumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNumer.Enabled = false;
            this.btnNumer.Location = new System.Drawing.Point(110, 80);
            this.btnNumer.Name = "btnNumer";
            this.btnNumer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNumer.Size = new System.Drawing.Size(22, 20);
            this.btnNumer.TabIndex = 9;
            this.btnNumer.UseVisualStyleBackColor = true;
            this.btnNumer.Click += new System.EventHandler(this.btnNumer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(35, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBajaCanal
            // 
            this.btnBajaCanal.BackColor = System.Drawing.Color.LightGray;
            this.btnBajaCanal.Enabled = false;
            this.btnBajaCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaCanal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBajaCanal.Location = new System.Drawing.Point(92, 172);
            this.btnBajaCanal.Name = "btnBajaCanal";
            this.btnBajaCanal.Size = new System.Drawing.Size(27, 28);
            this.btnBajaCanal.TabIndex = 7;
            this.btnBajaCanal.Text = "-";
            this.btnBajaCanal.UseVisualStyleBackColor = false;
            this.btnBajaCanal.Click += new System.EventHandler(this.btnSubeCanal_Click);
            // 
            // btnSubeCanal
            // 
            this.btnSubeCanal.BackColor = System.Drawing.Color.LightGray;
            this.btnSubeCanal.Enabled = false;
            this.btnSubeCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubeCanal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubeCanal.Location = new System.Drawing.Point(92, 146);
            this.btnSubeCanal.Name = "btnSubeCanal";
            this.btnSubeCanal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubeCanal.Size = new System.Drawing.Size(27, 28);
            this.btnSubeCanal.TabIndex = 6;
            this.btnSubeCanal.Text = "+";
            this.btnSubeCanal.UseVisualStyleBackColor = false;
            this.btnSubeCanal.Click += new System.EventHandler(this.btnBajaCanal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(89, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Canal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volumen";
            // 
            // btnBajaVol
            // 
            this.btnBajaVol.BackColor = System.Drawing.Color.LightGray;
            this.btnBajaVol.Enabled = false;
            this.btnBajaVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBajaVol.Location = new System.Drawing.Point(24, 172);
            this.btnBajaVol.Name = "btnBajaVol";
            this.btnBajaVol.Size = new System.Drawing.Size(27, 28);
            this.btnBajaVol.TabIndex = 3;
            this.btnBajaVol.Text = "-";
            this.btnBajaVol.UseVisualStyleBackColor = false;
            this.btnBajaVol.Click += new System.EventHandler(this.btnBajaVol_Click);
            // 
            // btnSubeVol
            // 
            this.btnSubeVol.BackColor = System.Drawing.Color.LightGray;
            this.btnSubeVol.Enabled = false;
            this.btnSubeVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubeVol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubeVol.Location = new System.Drawing.Point(24, 146);
            this.btnSubeVol.Name = "btnSubeVol";
            this.btnSubeVol.Size = new System.Drawing.Size(27, 28);
            this.btnSubeVol.TabIndex = 2;
            this.btnSubeVol.Text = "+";
            this.btnSubeVol.UseVisualStyleBackColor = false;
            this.btnSubeVol.Click += new System.EventHandler(this.btnSubeVol_Click);
            // 
            // btnPower
            // 
            this.btnPower.AutoSize = true;
            this.btnPower.BackColor = System.Drawing.Color.Red;
            this.btnPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPower.BackgroundImage")));
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.ForeColor = System.Drawing.Color.Black;
            this.btnPower.Location = new System.Drawing.Point(3, 3);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(48, 46);
            this.btnPower.TabIndex = 1;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pantalla.Location = new System.Drawing.Point(460, 212);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(310, 173);
            this.pantalla.TabIndex = 2;
            this.pantalla.TabStop = false;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.BackColor = System.Drawing.Color.Gray;
            this.lblVol.ForeColor = System.Drawing.Color.Lime;
            this.lblVol.Location = new System.Drawing.Point(576, 372);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(78, 13);
            this.lblVol.TabIndex = 4;
            this.lblVol.Text = "VOLUMEN: 10";
            this.lblVol.Visible = false;
            // 
            // lblCanal
            // 
            this.lblCanal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCanal.ForeColor = System.Drawing.Color.Lime;
            this.lblCanal.Location = new System.Drawing.Point(732, 212);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(38, 26);
            this.lblCanal.TabIndex = 5;
            this.lblCanal.Text = "0";
            this.lblCanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCanal.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(461, 212);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(309, 173);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://www.netflix.com/ar/login", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // lblMute
            // 
            this.lblMute.AutoSize = true;
            this.lblMute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMute.Location = new System.Drawing.Point(594, 372);
            this.lblMute.Name = "lblMute";
            this.lblMute.Size = new System.Drawing.Size(38, 13);
            this.lblMute.TabIndex = 7;
            this.lblMute.Text = "MUTE";
            this.lblMute.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1229, 625);
            this.Controls.Add(this.lblMute);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pantalla);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnPower;
        public System.Windows.Forms.PictureBox pantalla;
        public System.Windows.Forms.Button btnBajaVol;
        public System.Windows.Forms.Button btnSubeVol;
        public System.Windows.Forms.Label lblVol;
        public System.Windows.Forms.Button btnBajaCanal;
        public System.Windows.Forms.Button btnSubeCanal;
        public System.Windows.Forms.Label lblCanal;
        public System.Windows.Forms.Button btnNumer;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Button btnBrow;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.Button btnMute;
        public System.Windows.Forms.Label lblMute;
    }
}

