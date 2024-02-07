using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevoPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm=new Bitmap(pic.Width,pic.Height);
            g=Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p=new Pen(Color.Black, 1);
        Pen borrar =new Pen(Color.White, 10);
        int index;
        int x,y,sX,sY,cX,cY;

        ColorDialog Cd = new ColorDialog();
        Color new_color;


        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            index = 4;   
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            index=5; 
        }

        private void colorPaleta_Click(object sender, EventArgs e)
        {

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g= e.Graphics;
            if (paint) 
            {

                if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);

            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, sX, sY);
            }
        }

    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;


        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Cd.ShowDialog();
            new_color = Cd.Color;
            PicColor.BackColor = Cd.Color;
            p.Color=Cd.Color;



        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnColor_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX=e.X; cY=e.Y;

        }

        private void btnColor_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p,px,py);
                   
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(borrar, px, py);

                    py = px;
                }
            pic.Refresh();
                x = e.X;
                y = e.Y;
                sX = e.X-cX;
                sY = e.Y-cY;


        }
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnPintar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm=bm.Clone(new Rectangle(0,0,pic.Width,pic.Height),bm.PixelFormat); 
                btm.Save(sfd.FileName,ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada con exito");


            }
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar imagen";

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    Image imagen = Image.FromFile(openFileDialog.FileName);
                    pic.Image = imagen;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                
            }
            }
        }

        private void btnColor_MouseUp(object sender, MouseEventArgs e)
        {
            paint=false;
            sX=x-cX; sY=y-cY;

            if(index==3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
                    }
            if(index==4)
            {
                g.DrawRectangle(p, cX, cY, sX,sY);

            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, sX,sY);
            }
        }
        static Point set_point (PictureBox pb,Point pt)
        {
            float pX = 1f* pb.Image.Width;
            float pY = 1f* pb.Image.Height;
            return new Point ((int)(pt.X*pX), (int)(pt.Y*pY)); 
            
        }
        private void colorPaleta_MouseClik(object sender, MouseEventArgs e) 
        { 
            Point point = set_point(colorPaleta, e.Location);
            PicColor.BackColor = ((Bitmap)colorPaleta.Image).GetPixel(point.X, point.Y);
            new_color= PicColor.BackColor;

         
        }
        private void validate (Bitmap bm ,Stack<Point> sp,int x,int y , Color old_color , Color new_color)
        {
            Color cx = bm.GetPixel(x, y);   
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);


            }
        }
        public void Fill(Bitmap bm,int x,int y,Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color != new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point) pixel.Pop();
                if (pt.X­­ > 0 && pt.Y­ > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1) ;
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X , pt.Y-1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X , pt.Y+1, old_color, new_color);

                }


            }


    }
        private void pic_MouseClick (object sender, MouseEventArgs e)
        {
            if(index==7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X,point.Y,new_color);


            }       
}
}
}





