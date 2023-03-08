using System.Data.Common;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace U2_3
{
    public partial class Form1 : Form
    {

        Graphics papel;
        Graphics FOTO;
        Bitmap SURFACE;
        //Variables donde se pinta
        Pen pen;
        SolidBrush Brocha;

        //Se inician las variables para crear el cuadrado manual
        private Point startingPoint;
        private Point endingPoint;

        private Rectangle rectangle;
        private bool drawing;
        private Point? endPoint; // Variable para guardar la posición del segundo click

        int anchoPluma;
        int x = 0, y = 0;
        bool moving;
        int R = 0;
        int G = 0;
        int B = 0;
        bool pintar = false;
        bool borrar = false;
        bool dibujar = false;
        // Declarar una lista de puntos para almacenar los trazos del Pen
        //List<Point> points = new List<Point>();

        public Form1()
        {
            InitializeComponent();
            //Asignamos nuestra propiedad Graphics a nuestro picturebox
            papel = pictureBoxPapel.CreateGraphics();
            //Cuando dibuje suaviza el trazo
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Iniciamos nuestra variable con el valor del trackbar
            anchoPluma = trackBar1.Value;
            //Inicializando nuestro RGB con los valores del textBox
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            //Inicializamos un picel con los colores y el tamaño del pincel
            pen = new Pen(Color.FromArgb(R, G, B), anchoPluma);
            //Los trazos inicien y terminen en forma ovalada
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //Se indicia una instancia con un trazo Bitmap tomando las dimensiones del PictureBox
            SURFACE = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);
            //Guardamos como graficos el trazo Bit en la foto
            FOTO = Graphics.FromImage(SURFACE);
            //Se crea un fondo Blanco limpiando el picture Box
            FOTO.Clear(Color.White);

            //Tomando en cuenta la parte del PictureBox
            pictureBoxPapel.Image = SURFACE;
            //Guardando el trasfondo del PiuctureBox
            pictureBoxPapel.BackgroundImageLayout = ImageLayout.None;
            

            //Se inicia el conteo para conocer donde estara localizado el dibujo
            
            drawing = false;

        }
        //Evento que ocurre al hacer clic al boton pintar
        private void btnPintar_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
            dibujar= false;
        }

        //Evento que se dispara al hacer clic y sostenerlo en el picture Box
        private void pictureBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            if (endPoint != null) // Si ya se hizo el segundo click, comenzar un nuevo dibujo
            {
                startingPoint = e.Location;
                endPoint = null;
                return;
            }
            if (!drawing) // Si todavía no se ha comenzado a dibujar el cuadrado
            {
                //Inicializacion de los puntos
                startingPoint = e.Location;
                //Para mostrar la posicion actual del cuadrado
                drawing = true;
                labelC.Text = $"Posición inicial: ({startingPoint.X}, {startingPoint.Y})";
            }
            else // Si ya se comenzó a dibujar el cuadrado, guardar la posición del segundo click
            {
                endPoint = e.Location;
            }

            moving = true;
            x = e.X;
            y = e.Y;
            pictureBoxPapel.Cursor = Cursors.Cross;
            //Suscribe al evento MouseDown del PictureBox para
            //comenzar a guardar los puntos al hacer clic en el PictureBox
            //pointsList.Add(e.Location);

        }

        private void pictureBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && pintar)
            {
                //Se llama la funcion para cambiar las propiedades del pincel
                cambiarValoresPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                //Empezamos a Dibujar Lineas de la posicion actual de nuestro cursor hacia donde nos movemos
                papel.DrawLine(pen, new Point(x, y), e.Location);
                //Se agrega los graficos donde se resguardara los trazos del PEN
                FOTO.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X; y = e.Y;

            }
            if (moving && borrar)
            {
                cambiarValoresPluma(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                //Se agrega los graficos donde se resguardara los trazos del PEN
                FOTO.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X; y = e.Y;

            }

            labelC.Text = $"Posición inicial: ({startingPoint.X}, {startingPoint.Y})";

            if (CBCuadradoDefinido.Checked && drawing == true && dibujar == true && endPoint == null)
            {
                int width = e.Location.X - startingPoint.X;
                int height = e.Location.Y - startingPoint.Y;

                rectangle = new Rectangle(startingPoint.X, startingPoint.Y, width, height);
                //Evita que se repitan varias veces los dibujos
                FOTO.Clear(Color.White);
                FOTO.DrawRectangle(pen, rectangle);

                pictureBoxPapel.Invalidate();


            }

            if (CBCirculoDefinido.Checked && drawing == true && dibujar == true && endPoint == null)
            {
                int width = e.Location.X - startingPoint.X;
                int height = e.Location.Y - startingPoint.Y;

                rectangle = new Rectangle(startingPoint.X, startingPoint.Y, width, height);
                FOTO.Clear(Color.White);
                FOTO.DrawEllipse(pen, rectangle);

                pictureBoxPapel.Invalidate();


            }

            if (CBLineaDefinida.Checked && drawing == true && dibujar == true && endPoint == null)
            {
                endingPoint = e.Location;
                FOTO.Clear(Color.White);
                FOTO.DrawLine (pen, startingPoint, endingPoint);

                pictureBoxPapel.Invalidate();


            }

        }

        private void pictureBoxPapel_MouseClick(object sender, MouseEventArgs e)
        {
            //Corregir
            if (dibujar == true)
            {
                cambiarValoresPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                cambiarValoresBrocha(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));

                if (e.Button == MouseButtons.Left && CBCuadrado.Checked == true)
                {
                    Point mousePos = pictureBoxPapel.PointToClient(Control.MousePosition);
                    papel.DrawRectangle(pen, mousePos.X - 5, mousePos.Y - 5, 50, 50);
                    //
                    //Se agrega los graficos donde se resguardara los trazos del PEN
                    //
                    FOTO.DrawRectangle(pen, mousePos.X - 5, mousePos.Y - 5, 50, 50);
                    x = e.X; y = e.Y;
                }
                if (e.Button == MouseButtons.Left && CBRectangulo.Checked == true)
                {
                    Point mousePos = pictureBoxPapel.PointToClient(Control.MousePosition);
                    papel.DrawRectangle(pen, mousePos.X - 5, mousePos.Y - 5, 80, 50);
                    //Se agrega los graficos donde se resguardara los trazos del PEN
                    FOTO.DrawRectangle(pen, mousePos.X - 5, mousePos.Y - 5, 80, 50);
                    x = e.X; y = e.Y;
                }
                if (e.Button == MouseButtons.Left && CBCirculo.Checked == true)
                {
                    Point mousePos = pictureBoxPapel.PointToClient(Control.MousePosition);
                    papel.DrawEllipse(pen, mousePos.X - 5, mousePos.Y - 5, 60, 60);
                    //Se agrega los graficos donde se resguardara los trazos del PEN
                    FOTO.DrawEllipse(pen, mousePos.X - 5, mousePos.Y - 5, 60, 60);
                    x = e.X; y = e.Y;
                }
                if (e.Button == MouseButtons.Left && CBCirculoR.Checked == true)
                {
                    Point mousePos = pictureBoxPapel.PointToClient(Control.MousePosition);
                    papel.FillEllipse(Brocha, mousePos.X - 5, mousePos.Y - 5, 60, 60);
                    //Se agrega los graficos donde se resguardara los trazos del PEN
                    FOTO.FillEllipse(Brocha, mousePos.X - 5, mousePos.Y - 5, 60, 60);
                    x = e.X; y = e.Y;
                }
            }
        }

        private void pictureBoxPapel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            anchoPluma = trackBar1.Value;
            lblTB.Text = trackBar1.Value.ToString();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo Guardar como y permitir al usuario seleccionar la ubicación y el nombre del archivo de imagen.
            SaveFileDialog save = new SaveFileDialog();
            //Opcion para concer en que tipo de Arhcivo se va a salvaguardar la imagen
            save.Filter = "Archivos de imagen (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";
            //De manera automatica se guardara como archivo PNG
            save.DefaultExt = "png";
            //Se agrega la extension de True para asegurarse del guardado
            save.AddExtension = true;
            //Titulo simple para la ventanilla que se genera
            save.Title = "Guardar imagen";

            // Si el usuario ha seleccionado una ubicación y un nombre de archivo válido, guardar la imagen en el disco.
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Guardar la imagen en el archivo especificado.
                SURFACE.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }



            //-----------------------------------Intento 1 Correcto------------------------------------
            /*Image Imagen = pictureBoxPapel.Image;


            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Guardar Imagen";
            save.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
            //Graphics Graficos = pictureBoxPapel.CreateGraphics();


            if (save.ShowDialog() == DialogResult.OK)
            {
                Imagen.Save(save.FileName);
                //Bitmap bitmap = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height, Graficos);
                //bitmap.Save(save.FileName, ImageFormat.Jpeg);
                //pictureBoxPapel.Image.Save("C:/Users/Dell/OneDrive/Imagenes", ImageFormat.Jpeg);

            }*/

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK) 
            {
                pictureBoxPapel.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Se crea un fondo Blanco limpiando el picture Box
            FOTO.Clear(Color.White);
            pictureBoxPapel.Invalidate();
            papel.Clear(Color.White);

        }


        //Picture Box para pasar a color negro nuestra brocha
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtR.Text = txtG.Text = txtB.Text = 0.ToString();
        }

        //PictueBox que muestra el color Dialog
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Mostramos el Color Dialog
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Asignar a los TextBox el Color Seleccionado
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void pictureBoxPapel_Click(object sender, EventArgs e)
        {
            moving = false;
        }

        private void BtnBorrador_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
            dibujar = false;

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            dibujar = true;
            borrar = false;
            pintar = false;
        }

        

        private void cambiarValoresPluma(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), anchoPluma);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
    }

        private void pictureBoxPapel_Paint_1(object sender, PaintEventArgs e)
        {
            cambiarValoresPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
            cambiarValoresBrocha(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));

            if (drawing) //&& CBCuadradoDefinido.Checked && dibujar
            {
                if (CBCuadradoDefinido.Checked)
                {
                    if (endPoint == null) // Si todavía no se hizo el segundo click, dibujar la línea de borde del cuadrado
                    {
                        e.Graphics.DrawRectangle(pen, rectangle);


                    }
                    else // Si se hizo el segundo click, dibujar el cuadrado completo
                    {
                        e.Graphics.DrawRectangle(pen, rectangle);
                    }
                }

                if (CBCirculoDefinido.Checked)
                {
                    if (endPoint == null) // Si todavía no se hizo el segundo click, dibujar la línea de borde del circulo
                    {
                        e.Graphics.DrawEllipse(pen, rectangle);


                    }
                    else // Si se hizo el segundo click, dibujar el Circulo completo
                    {
                        e.Graphics.DrawEllipse(pen, rectangle);
                    }
                }
                if (CBLineaDefinida.Checked)
                {
                    if (endPoint == null) // Si todavía no se hizo el segundo click, dibujar la línea de borde de la linea
                    {

                        e.Graphics.DrawLine(pen, startingPoint, endingPoint);


                    }
                    else // Si se hizo el segundo click, dibujar la linea completa
                    {
                        e.Graphics.DrawLine(pen, startingPoint, endingPoint);
                    }
                }
            }
        }

        private void cambiarValoresBrocha(int R, int G, int B)
        {
            Brocha = new SolidBrush(Color.FromArgb(R, G, B));
        }
    }
    //TODO: Pasar las figuras a este programa ----LISTO
    //* Plus: Dibujar un cuadrado por dos puntos
    //** Plus: Dibujar un cuadradi por dos puntos y que se vea como se va generando
    //SON TODAS LAS FIGURAS
    //TODO: Boton para Guardar el dibujo ----LISTO
}