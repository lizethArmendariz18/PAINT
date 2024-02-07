namespace NuevoPrint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PicColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPaleta = new System.Windows.Forms.PictureBox();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPincel = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPaleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCargarImg);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.colorPaleta);
            this.panel1.Controls.Add(this.btnLinea);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnCuadrado);
            this.panel1.Controls.Add(this.btnCirculo);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnPincel);
            this.panel1.Controls.Add(this.btnPintar);
            this.panel1.Controls.Add(this.PicColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 99);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(791, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 24);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(791, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 24);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PicColor
            // 
            this.PicColor.Location = new System.Drawing.Point(140, 37);
            this.PicColor.Name = "PicColor";
            this.PicColor.Size = new System.Drawing.Size(37, 30);
            this.PicColor.TabIndex = 0;
            this.PicColor.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(183, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 78);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCargarImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargarImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarImg.Location = new System.Drawing.Point(791, 70);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(89, 24);
            this.btnCargarImg.TabIndex = 10;
            this.btnCargarImg.Text = "Cargar IMG";
            this.btnCargarImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarImg.UseVisualStyleBackColor = false;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 99);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(885, 374);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(757, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "lizeth Armendariz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorPaleta
            // 
            this.colorPaleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPaleta.Image = global::NuevoPrint.Properties.Resources.colores__1_;
            this.colorPaleta.Location = new System.Drawing.Point(3, 3);
            this.colorPaleta.Name = "colorPaleta";
            this.colorPaleta.Size = new System.Drawing.Size(131, 94);
            this.colorPaleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPaleta.TabIndex = 3;
            this.colorPaleta.TabStop = false;
            this.colorPaleta.Click += new System.EventHandler(this.colorPaleta_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLinea.Image = global::NuevoPrint.Properties.Resources.linea_diagonal;
            this.btnLinea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLinea.Location = new System.Drawing.Point(695, 26);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(77, 53);
            this.btnLinea.TabIndex = 7;
            this.btnLinea.Text = "Linea";
            this.btnLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Image = global::NuevoPrint.Properties.Resources.paleta_de_color__1_;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColor.Location = new System.Drawing.Point(194, 26);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(77, 53);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuadrado.Image = global::NuevoPrint.Properties.Resources.cuadrado;
            this.btnCuadrado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuadrado.Location = new System.Drawing.Point(609, 26);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(77, 53);
            this.btnCuadrado.TabIndex = 5;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCirculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCirculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCirculo.Image = global::NuevoPrint.Properties.Resources.oval;
            this.btnCirculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCirculo.Location = new System.Drawing.Point(526, 26);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(77, 53);
            this.btnCirculo.TabIndex = 4;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Image = global::NuevoPrint.Properties.Resources.borrador;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(443, 26);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(77, 53);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPincel
            // 
            this.btnPincel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPincel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPincel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPincel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPincel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPincel.Image = global::NuevoPrint.Properties.Resources.cepillo_de_pintura;
            this.btnPincel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPincel.Location = new System.Drawing.Point(360, 26);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(77, 53);
            this.btnPincel.TabIndex = 2;
            this.btnPincel.Text = "Pincel";
            this.btnPincel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPincel.UseVisualStyleBackColor = true;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPintar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnPintar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnPintar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPintar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPintar.Image = global::NuevoPrint.Properties.Resources.lapices_de_colores;
            this.btnPintar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPintar.Location = new System.Drawing.Point(277, 26);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(77, 53);
            this.btnPintar.TabIndex = 1;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NuevoPrint.Properties.Resources.aguila;
            this.pictureBox1.Location = new System.Drawing.Point(841, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNOLOGICO DELICIAS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPaleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Button PicColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPincel;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox colorPaleta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargarImg;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

