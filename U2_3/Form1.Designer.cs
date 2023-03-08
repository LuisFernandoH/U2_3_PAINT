namespace U2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPapel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.BtnBorrador = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CBCuadrado = new System.Windows.Forms.CheckBox();
            this.CBRectangulo = new System.Windows.Forms.CheckBox();
            this.CBCirculo = new System.Windows.Forms.CheckBox();
            this.CBCirculoR = new System.Windows.Forms.CheckBox();
            this.CBCuadradoDefinido = new System.Windows.Forms.CheckBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.labelC = new System.Windows.Forms.Label();
            this.CBCirculoDefinido = new System.Windows.Forms.CheckBox();
            this.CBLineaDefinida = new System.Windows.Forms.CheckBox();
            this.TXTFIGURAS = new System.Windows.Forms.Label();
            this.TXTFIGDETERMINADAS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPapel
            // 
            this.pictureBoxPapel.Location = new System.Drawing.Point(259, 12);
            this.pictureBoxPapel.Name = "pictureBoxPapel";
            this.pictureBoxPapel.Size = new System.Drawing.Size(529, 426);
            this.pictureBoxPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPapel.TabIndex = 0;
            this.pictureBoxPapel.TabStop = false;
            this.pictureBoxPapel.Click += new System.EventHandler(this.pictureBoxPapel_Click);
            this.pictureBoxPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPapel_Paint_1);
            this.pictureBoxPapel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPapel_MouseClick);
            this.pictureBoxPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPapel_MouseDown);
            this.pictureBoxPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPapel_MouseMove);
            this.pictureBoxPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(12, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox3.Location = new System.Drawing.Point(56, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(32, 72);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(32, 122);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(30, 23);
            this.txtR.TabIndex = 4;
            this.txtR.Text = "0";
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(32, 151);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(30, 23);
            this.txtG.TabIndex = 5;
            this.txtG.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(32, 184);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(30, 23);
            this.txtB.TabIndex = 6;
            this.txtB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "B:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(8, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(89, 373);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(170, 373);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(100, 33);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(75, 23);
            this.btnPintar.TabIndex = 17;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // BtnBorrador
            // 
            this.BtnBorrador.Location = new System.Drawing.Point(178, 33);
            this.BtnBorrador.Name = "BtnBorrador";
            this.BtnBorrador.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrador.TabIndex = 18;
            this.BtnBorrador.Text = "Borador";
            this.BtnBorrador.UseVisualStyleBackColor = true;
            this.BtnBorrador.Click += new System.EventHandler(this.BtnBorrador_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(25, 72);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(0, 15);
            this.lblTB.TabIndex = 19;
            // 
            // CBCuadrado
            // 
            this.CBCuadrado.AutoSize = true;
            this.CBCuadrado.Location = new System.Drawing.Point(86, 132);
            this.CBCuadrado.Name = "CBCuadrado";
            this.CBCuadrado.Size = new System.Drawing.Size(78, 19);
            this.CBCuadrado.TabIndex = 20;
            this.CBCuadrado.Text = "Cuadrado";
            this.CBCuadrado.UseVisualStyleBackColor = true;
            // 
            // CBRectangulo
            // 
            this.CBRectangulo.AutoSize = true;
            this.CBRectangulo.Location = new System.Drawing.Point(86, 152);
            this.CBRectangulo.Name = "CBRectangulo";
            this.CBRectangulo.Size = new System.Drawing.Size(86, 19);
            this.CBRectangulo.TabIndex = 21;
            this.CBRectangulo.Text = "Rectangulo";
            this.CBRectangulo.UseVisualStyleBackColor = true;
            // 
            // CBCirculo
            // 
            this.CBCirculo.AutoSize = true;
            this.CBCirculo.Location = new System.Drawing.Point(86, 171);
            this.CBCirculo.Name = "CBCirculo";
            this.CBCirculo.Size = new System.Drawing.Size(64, 19);
            this.CBCirculo.TabIndex = 22;
            this.CBCirculo.Text = "Circulo";
            this.CBCirculo.UseVisualStyleBackColor = true;
            // 
            // CBCirculoR
            // 
            this.CBCirculoR.AutoSize = true;
            this.CBCirculoR.Location = new System.Drawing.Point(86, 191);
            this.CBCirculoR.Name = "CBCirculoR";
            this.CBCirculoR.Size = new System.Drawing.Size(106, 19);
            this.CBCirculoR.TabIndex = 23;
            this.CBCirculoR.Text = "Circulo Relleno";
            this.CBCirculoR.UseVisualStyleBackColor = true;
            // 
            // CBCuadradoDefinido
            // 
            this.CBCuadradoDefinido.AutoSize = true;
            this.CBCuadradoDefinido.Location = new System.Drawing.Point(86, 240);
            this.CBCuadradoDefinido.Name = "CBCuadradoDefinido";
            this.CBCuadradoDefinido.Size = new System.Drawing.Size(126, 19);
            this.CBCuadradoDefinido.TabIndex = 24;
            this.CBCuadradoDefinido.Text = "Cuadrado Definido";
            this.CBCuadradoDefinido.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(117, 322);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 25;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(271, 29);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 15);
            this.labelC.TabIndex = 26;
            // 
            // CBCirculoDefinido
            // 
            this.CBCirculoDefinido.AutoSize = true;
            this.CBCirculoDefinido.Location = new System.Drawing.Point(86, 265);
            this.CBCirculoDefinido.Name = "CBCirculoDefinido";
            this.CBCirculoDefinido.Size = new System.Drawing.Size(112, 19);
            this.CBCirculoDefinido.TabIndex = 27;
            this.CBCirculoDefinido.Text = "Circulo Definido";
            this.CBCirculoDefinido.UseVisualStyleBackColor = true;
            // 
            // CBLineaDefinida
            // 
            this.CBLineaDefinida.AutoSize = true;
            this.CBLineaDefinida.Location = new System.Drawing.Point(86, 290);
            this.CBLineaDefinida.Name = "CBLineaDefinida";
            this.CBLineaDefinida.Size = new System.Drawing.Size(101, 19);
            this.CBLineaDefinida.TabIndex = 28;
            this.CBLineaDefinida.Text = "Linea Definida";
            this.CBLineaDefinida.UseVisualStyleBackColor = true;
            // 
            // TXTFIGURAS
            // 
            this.TXTFIGURAS.AutoSize = true;
            this.TXTFIGURAS.Location = new System.Drawing.Point(86, 114);
            this.TXTFIGURAS.Name = "TXTFIGURAS";
            this.TXTFIGURAS.Size = new System.Drawing.Size(56, 15);
            this.TXTFIGURAS.TabIndex = 29;
            this.TXTFIGURAS.Text = "FIGURAS:";
            // 
            // TXTFIGDETERMINADAS
            // 
            this.TXTFIGDETERMINADAS.AutoSize = true;
            this.TXTFIGDETERMINADAS.Location = new System.Drawing.Point(86, 222);
            this.TXTFIGDETERMINADAS.Name = "TXTFIGDETERMINADAS";
            this.TXTFIGDETERMINADAS.Size = new System.Drawing.Size(145, 15);
            this.TXTFIGDETERMINADAS.TabIndex = 30;
            this.TXTFIGDETERMINADAS.Text = "FIGURAS DETERMINADAS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTFIGDETERMINADAS);
            this.Controls.Add(this.TXTFIGURAS);
            this.Controls.Add(this.CBLineaDefinida);
            this.Controls.Add(this.CBCirculoDefinido);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.CBCuadradoDefinido);
            this.Controls.Add(this.CBCirculoR);
            this.Controls.Add(this.CBCirculo);
            this.Controls.Add(this.CBRectangulo);
            this.Controls.Add(this.CBCuadrado);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.BtnBorrador);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxPapel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxPapel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TrackBar trackBar1;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private OpenFileDialog openFileDialog1;
        private Button btnBorrar;
        private Button btnSeleccionar;
        private Button btnPintar;
        private Button BtnBorrador;
        private Label lblTB;
        private ColorDialog colorDialog1;
        private CheckBox CBCuadrado;
        private CheckBox CBRectangulo;
        private CheckBox CBCirculo;
        private CheckBox CBCirculoR;
        private CheckBox CBCuadradoDefinido;
        private Button btnDibujar;
        private Label labelC;
        private CheckBox CBCirculoDefinido;
        private CheckBox CBLineaDefinida;
        private Label TXTFIGURAS;
        private Label TXTFIGDETERMINADAS;
    }
}