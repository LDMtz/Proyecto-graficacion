using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Graficacion___Leoncio_Martinez
{
    public partial class VentanaPrincipal : Form
    {
        //Variables Globales
        Color color, CFondo;
        Bitmap Lienzo;
        int Tamaño, i, j, Contador, radio, Lados, Rx, Ry, Xc, Yc, Tx, Ty, Angulo, Auxiliar;
        Double Sx, Sy;
        string Opcion, Estilo, Id;
        List<Point> Puntos;
        List<Point> Aux, Aux2, Aux3, PixelesTG, TPixeles;

        //Lista de puntos para el examen 1
        List<Point> PuntosExamen;

        //Variable para la figura navideña
        bool FinalizoBorrado;
        int RadioFiguraNavideña;

        public VentanaPrincipal()
        {
            InitializeComponent();
            color = Color.Black;
            CFondo = Color.FromArgb(0, 0, 0, 0);
            Tamaño = 0;
            Id = "Pixel";
            Opcion = "Pixel";
            Estilo = "Continua";
            radio = 100;
            Rx = 100;
            Ry = 150;
            Angulo = 45;
            Puntos = new List<Point>();
            Aux = new List<Point>();
            Aux2 = new List<Point>();
            Aux3 = new List<Point>();
            PixelesTG = new List<Point>();
            TPixeles = new List<Point>();

            //Inicializando la lista del examen
            PuntosExamen = new List<Point>();

            //Para la figura navideña
            FinalizoBorrado = false;
            RadioFiguraNavideña = 15;
        }


        //Cargar bitmap maximizado
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            Lienzo = new Bitmap(ptb_Lienzo.Width, ptb_Lienzo.Height);
        }


        // ****** BOTONES DE COLORES ***** \\

        private void btnNegro_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            btnActual.BackColor = color;
        }
        private void btnRojo_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            btnActual.BackColor = color;
        }
        private void btnAzul_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            btnActual.BackColor = color;
        }
        private void btnVerde_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            btnActual.BackColor = color;
        }
        private void btnNaranja_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
            btnActual.BackColor = color;
        }
        private void btnLila_Click(object sender, EventArgs e)
        {
            color = Color.Purple;
            btnActual.BackColor = color;
        }



        // ****** BOTONES DEL TAMAÑO ***** \\

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            Tamaño = 0;
        }
        private void btn_Mediano_Click(object sender, EventArgs e)
        {
            Tamaño = 1;
        }
        private void btn_Grande_Click(object sender, EventArgs e)
        {
            Tamaño = 2;
        }



        // ****** CONFIGURACION DEL MENU ***** \\

        private void menuPixel_Click(object sender, EventArgs e)
        {
            Opcion = "Pixel";
        }
        private void menuRecta_Click(object sender, EventArgs e)
        {
            Opcion = "Recta";
        }
        private void menuCircunferencia_Click(object sender, EventArgs e)
        {
            Opcion = "Circunferencia";
        }
        private void menuPoligonoRegular_Click(object sender, EventArgs e)
        {
            Opcion = "Poligono Regular";
        }
        private void menuPoligonoIrregular_Click(object sender, EventArgs e)
        {
            Opcion = "Poligono Irregular";
        }
        private void menuElipse_Click(object sender, EventArgs e)
        {
            Opcion = "Elipse";
        }
        private void menuTraslacion_Click(object sender, EventArgs e)
        {
            Opcion = "Traslacion";
        }
        private void menuRotacion_Click(object sender, EventArgs e)
        {
            Opcion = "Rotacion";
        }
        private void menuEscalamiento_Click(object sender, EventArgs e)
        {
            Opcion = "Escalamiento";
        }
        private void menuIncrementar_Click(object sender, EventArgs e)
        {
            Sx = 1.1;
            Sy = 1.1;
        }
        private void menuDecrementar_Click(object sender, EventArgs e)
        {
            Sx = 0.9;
            Sy = 0.9;
        }


        // ****** BOTONES SECUNDARIOS ***** \\

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (paleta.ShowDialog() == DialogResult.OK)
            {
                color = paleta.Color;
                btnActual.BackColor = paleta.Color;
            }
        }

        //Boton relleno
        private void btnRelleno_Click(object sender, EventArgs e)
        {
            Opcion = "Relleno";
        }
        //Boton borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Lienzo = new Bitmap(ptb_Lienzo.Width, ptb_Lienzo.Height);
            ptb_Lienzo.Image = Lienzo;

            RadioFiguraNavideña = 15;
        }
        //Boton manual de usuario
        private void btnManual_Click(object sender, EventArgs e)
        {
            ManualUsuario ventanaManual = new ManualUsuario();
            ventanaManual.Show();
        }

        //Boton del examen 1
        private void btn_Examen1_Click(object sender, EventArgs e)
        {
            try
            {
                //Paso 2
                Estilo = "Continua";
                Tamaño = 1;
                color = Color.Red;
                Recta(new List<Point> { PuntosExamen[0], PuntosExamen[1] }, color);

                //Paso 3
                Estilo = "Punteada";
                Tamaño = 2;
                color = Color.Blue;
                Recta(new List<Point> { PuntosExamen[1], PuntosExamen[2] }, color);

                //Paso 4
                Estilo = "Segmentada";
                Tamaño = 0;
                color = Color.Blue;
                Recta(new List<Point> { PuntosExamen[2], PuntosExamen[3] }, color);

                //Paso 5
                Estilo = "Punteada";
                Tamaño = 2;
                color = Color.Blue;
                Recta(new List<Point> { PuntosExamen[3], PuntosExamen[4] }, color);

                ptb_Lienzo.Image = Lienzo;
            }
            catch
            {
                MessageBox.Show("Primero debes dibujar los 5 puntos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Boton examen final
        private void btnExamenFinal_Click(object sender, EventArgs e)
        {
            Opcion = "FiguraNavidad";
        }



        // ****** CONFIGURACION DE ESTILOS ***** \\
        private void btn_Continua_Click(object sender, EventArgs e)
        {
            Estilo = "Continua";
        }

        private void btn_Punteada_Click(object sender, EventArgs e)
        {
            Estilo = "Punteada";
        }
        private void btn_Segmento_Click(object sender, EventArgs e)
        {
            Estilo = "Segmentada";
        }



        // ****** EVENTOS ***** \\
        //Mouse click Lienzo
        private void ptb_Lienzo_MouseClick(object sender, MouseEventArgs e)
        {
            switch (Opcion)
            {
                case "Pixel":

                    //Lista para el examen 1
                    PuntosExamen.Add(new Point(e.X, e.Y));

                    Pixeles(e.X, e.Y, color);
                    break;

                case "Recta":
                    Pixeles(e.X, e.Y, color);
                    Puntos.Add(new Point(e.X, e.Y));
                    if (Puntos.Count == 2)
                    {
                        Recta(Puntos, color);
                        Id = "Recta";
                        Xc = (Puntos[0].X + Puntos[1].X) / 2;
                        Yc = (Puntos[0].Y + Puntos[1].Y) / 2;
                        PixelesTG = new List<Point>(Puntos);
                        Puntos.Clear();
                    }
                    break;

                case "Circunferencia":
                    Puntos.Add(new Point(e.X, e.Y));
                    Circunferencia(Puntos, color);
                    Id = "Circunferencia";
                    Xc = e.X;
                    Yc = e.Y;
                    PixelesTG = new List<Point>(Puntos);
                    Puntos.Clear();
                    break;

                case "Poligono Irregular":
                    if (toolStripLados.Text == "")
                    {
                        MessageBox.Show("Debes ingresar una cantidad de lados para el poligono irregular", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Convert.ToInt32(toolStripLados.Text) < 3)
                    {
                        MessageBox.Show("Solo se permiten números > 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Pixeles(e.X, e.Y, color);
                    Puntos.Add(new Point(e.X, e.Y));
                    if (Puntos.Count == Convert.ToInt32(toolStripLados.Text))
                    {
                        PoligonoIrregular(Puntos, color);
                        Id = "PoligonoIrregular";
                        Xc = (Puntos.Min(Point => Point.X) + Puntos.Max(Point => Point.X)) / 2;
                        Yc = (Puntos.Min(Point => Point.Y) + Puntos.Max(Point => Point.Y)) / 2;
                        PixelesTG = new List<Point>(Puntos);
                        Puntos.Clear();
                    }
                    break;

                case "Poligono Regular":
                    if (toolStripLados2.Text != "")
                    {
                        if (Convert.ToInt32(toolStripLados2.Text) < 7)
                        {
                            MessageBox.Show("Solo se permiten números > 6", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            Lados = Convert.ToInt32(toolStripLados2.Text);
                        }
                    }
                    Puntos.Add(new Point(e.X, e.Y));
                    PoligonoRegular(Puntos, color);
                    Id = "PoligonoRegular";
                    Xc = e.X;
                    Yc = e.Y;
                    PixelesTG = new List<Point>(Puntos);
                    Puntos.Clear();
                    break;

                case "Elipse":
                    Puntos.Add(new Point(e.X, e.Y));
                    Elipse(Puntos, color);
                    Id = "Elipse";
                    Xc = e.X;
                    Yc = e.Y;
                    PixelesTG = new List<Point>(Puntos);
                    Puntos.Clear();
                    break;

                case "Relleno":
                    Relleno(e.X, e.Y, color);
                    break;

                case "Traslacion":
                    Tx = e.X - Xc;
                    Ty = e.Y - Yc;
                    Traslacion(PixelesTG, Tx, Ty, color);
                    Xc = e.X;
                    Yc = e.Y;
                    Puntos.Clear();
                    break;

                case "Rotacion":
                    Rotacion(PixelesTG, Angulo, color);
                    break;

                case "Escalamiento":
                    Escalamiento(PixelesTG, Sx, Sy, color);
                    break;
                case "FiguraNavidad":
                    //Mi figura navideña es un gorro de Navidad

                    //Para el circulo
                    Puntos.Add(new Point(e.X, e.Y));

                    //Para el rectangulo
                    Puntos.Add(new Point(e.X - 45, e.Y + 75));
                    Puntos.Add(new Point(e.X - 45, e.Y + 90));
                    Puntos.Add(new Point(e.X + 45, e.Y + 90));
                    Puntos.Add(new Point(e.X + 45, e.Y + 75));

                    //Para el triangulo 
                    Puntos.Add(new Point(e.X, e.Y + 15));
                    Puntos.Add(new Point(e.X - 40, e.Y + 75));
                    Puntos.Add(new Point(e.X + 40, e.Y + 75));

                    FiguraNavidad(Puntos, color);
                    Id = "FiguraNavidad";
                    Xc = e.X;
                    Yc = e.Y;
                    PixelesTG = new List<Point>(Puntos);
                    Puntos.Clear();

                    break;

            }
            ptb_Lienzo.Image = Lienzo;

        }

        //txtBoxLados Poligono Irregular
        private void toolStripLados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //Menu Opciones: Poligono Regular
        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lados = 3;
        }
        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lados = 4;
        }
        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lados = 5;
        }


        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lados = 6;
        }
        //txtBoxLados Poligono regular
        private void toolStripLados2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                return;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        // ****** METODOS ***** \\
        public void Pixeles(int X, int Y, Color micolor)
        {
            for (i = -Tamaño; i <= Tamaño; i++)
            {
                for (j = -Tamaño; j <= Tamaño; j++)
                {
                    if (X + i > 0 && X + i < ptb_Lienzo.Width && Y + j > 0 && Y + j < ptb_Lienzo.Height)
                    {
                        Lienzo.SetPixel(X + i, Y + j, micolor);
                    }

                }
            }
        }

        //Algortimo de Bresenham
        public void Recta(List<Point> plista, Color Micolor)
        {
            int DX, DY, X, Y, IncX, IncY, e;
            DX = plista[1].X - plista[0].X;
            DY = plista[1].Y - plista[0].Y;
            if (DX < 0)
            {
                IncX = -1;
                DX = -DX;
            }
            else
            {
                IncX = 1;
            }
            if (DY < 0)
            {
                DY = -DY;
                IncY = -1;
            }
            else
            {
                IncY = 1;
            }
            X = plista[0].X;
            Y = plista[0].Y;
            Pixeles(X, Y, Micolor);
            if (DX > DY)
            {
                e = 2 * DY - DX;
                Contador = 0;
                while (X != plista[1].X)
                {
                    X = X + IncX;
                    if (e < 0)
                    {
                        e = e + 2 * DY;
                    }
                    else
                    {
                        Y = Y + IncY;
                        e = e + 2 * (DY - DX);
                    }
                    switch (Estilo)
                    {
                        case "Continua":
                            Pixeles(X, Y, Micolor);
                            break;
                        case "Punteada":
                            if (Contador % (4 * Tamaño + 2) == 0)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            break;
                        case "Segmentada":
                            if (Tamaño == 0 && Contador % 5 != 0)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            if (Tamaño != 0 && Contador % 10 == Contador % 20)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            break;
                    }
                    Contador++;
                }
            }
            else
            {
                e = 2 * DX - DY;
                Contador = 0;
                while (Y != plista[1].Y)
                {
                    Y = Y + IncY;
                    if (e < 0)
                    {
                        e = e + 2 * DX;
                    }
                    else
                    {
                        X = X + IncX;
                        e = e + 2 * (DX - DY);
                    }
                    switch (Estilo)
                    {
                        case "Continua":
                            Pixeles(X, Y, Micolor);
                            break;
                        case "Punteada":
                            if (Contador % (4 * Tamaño + 2) == 0)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            break;
                        case "Segmentada":
                            if (Tamaño == 0 && Contador % 5 != 0)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            if (Tamaño != 0 && Contador % 10 == Contador % 20)
                            {
                                Pixeles(X, Y, Micolor);
                            }
                            break;
                    }
                    Contador++;
                }
            }

        }

        //Algoritmo de Bresenham para Circunferencia
        public void Circunferencia(List<Point> Puntos, Color Micolor)
        {
            int x, y, e;
            x = radio; y = 0; e = 0;
            if (Id == "FiguraNavidad")
            {
                x = RadioFiguraNavideña;
            }
            while (y <= x)
            {
                Pixeles(Puntos[0].X + x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X + x, Puntos[0].Y - y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y - y, Micolor);
                Pixeles(Puntos[0].X + y, Puntos[0].Y + x, Micolor);
                Pixeles(Puntos[0].X - y, Puntos[0].Y + x, Micolor);
                Pixeles(Puntos[0].X + y, Puntos[0].Y - x, Micolor);
                Pixeles(Puntos[0].X - y, Puntos[0].Y - x, Micolor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
        }

        //Algoritmo Poligono Irregular
        public void PoligonoIrregular(List<Point> Puntos, Color Micolor)
        {
            for (int i = 0; i < Puntos.Count - 1; i++)
            {
                Aux.Add(new Point(Puntos[i].X, Puntos[i].Y));
                Aux.Add(new Point(Puntos[i + 1].X, Puntos[i + 1].Y));
                Recta(Aux, Micolor);
                Aux.Clear();
            }
            Aux.Add(new Point(Puntos[0].X, Puntos[0].Y));
            Aux.Add(new Point(Puntos[Puntos.Count - 1].X, Puntos[Puntos.Count - 1].Y));
            Recta(Aux, Micolor);
            Aux.Clear();
        }

        //Algoritmo Poligono Regular
        public void PoligonoRegular(List<Point> Puntos, Color Micolor)
        {
            double angulo, X, Y, i;
            angulo = 360 / Lados;
            for (i = 0; i < 360; i = i + angulo)
            {
                X = Puntos[0].X + radio * Math.Cos((i + 90 * (Lados - 2) / Lados) * Math.PI / 180);
                Y = Puntos[0].Y + radio * Math.Sin((i + 90 * (Lados - 2) / Lados) * Math.PI / 180);
                Aux2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Aux2, Micolor);
            Aux3 = new List<Point>(Aux2);
            Aux2.Clear();
        }

        //Elipse
        public void Elipse(List<Point> Puntos, Color Micolor)
        {
            int x, y, e;
            x = 0;
            y = Ry;
            e = 2 * Ry * Ry + (1 - 2 * Ry) * (Rx * Rx);
            while (Ry * Ry * x <= Rx * Rx * y)
            {
                Pixeles(Puntos[0].X + x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X + x, Puntos[0].Y - y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y - y, Micolor);
                x = x + 1;
                if (e >= 0)
                {
                    e = e + 4 * Rx * Rx * (1 - y);
                    y = y - 1;
                }
                e = e + Ry * Ry * (4 * x + 6);
            }
            y = 0;
            x = Rx;
            e = 2 * Rx * Rx + (1 - 2 * Rx) * (Ry * Ry);
            while (Rx * Rx * y <= Ry * Ry * x)
            {
                Pixeles(Puntos[0].X + x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X + x, Puntos[0].Y - y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y + y, Micolor);
                Pixeles(Puntos[0].X - x, Puntos[0].Y - y, Micolor);
                y = y + 1;
                if (e >= 0)
                {
                    e = e + 4 * Ry * Ry * (1 - x);
                    x = x - 1;
                }
                e = e + Rx * Rx * (4 * y + 6);
            }
        }

        //Relleno
        public void Relleno(int X, int Y, Color CRelleno)
        {
            Color CFondo = Lienzo.GetPixel(X, Y);
            Stack<Point> Vecinos = new Stack<Point>();
            Vecinos.Push(new Point(X, Y));
            while (Vecinos.Count != 0)
            {
                Point p = Vecinos.Pop();
                if (p.X > 0 && p.X < ptb_Lienzo.Width && p.Y > 0 && p.Y < ptb_Lienzo.Height)
                {
                    if (Lienzo.GetPixel(p.X, p.Y) != CRelleno && Lienzo.GetPixel(p.X, p.Y) == CFondo)
                    {
                        Lienzo.SetPixel(p.X, p.Y, CRelleno);
                        Vecinos.Push(new Point(p.X + 1, p.Y));
                        Vecinos.Push(new Point(p.X - 1, p.Y));
                        Vecinos.Push(new Point(p.X, p.Y + 1));
                        Vecinos.Push(new Point(p.X, p.Y - 1));
                    }
                }

            }
        }

        //Traslacion
        public void Traslacion(List<Point> PixelesTG, int Tx, int Ty, Color micolor)
        {
            for (int i = 0; i < PixelesTG.Count; i++)
            {
                TPixeles.Add(new Point(PixelesTG[i].X + Tx, PixelesTG[i].Y + Ty));
            }
            switch (Id)
            {
                case "Recta":
                    Recta(PixelesTG, CFondo);
                    Recta(TPixeles, micolor);
                    break;
                case "PoligonoIrregular":
                    PoligonoIrregular(PixelesTG, CFondo);
                    PoligonoIrregular(TPixeles, micolor);
                    break;
                case "PoligonoRegular":
                    PoligonoRegular(PixelesTG, CFondo);
                    PoligonoRegular(TPixeles, micolor);
                    break;
                case "Circunferencia":
                    Circunferencia(PixelesTG, CFondo);
                    Circunferencia(TPixeles, micolor);
                    break;
                case "Elipse":
                    Elipse(PixelesTG, CFondo);
                    Elipse(TPixeles, micolor);
                    break;
                case "FiguraNavidad":
                    FinalizoBorrado = false;
                    FiguraNavidad(PixelesTG, CFondo);
                    FinalizoBorrado = true;
                    FiguraNavidad(TPixeles, micolor);
                    break;

            }
            for (int j = 0; j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            TPixeles.Clear();

        }

        //Rotacion
        public void Rotacion(List<Point> PixelesTG, int Angulo, Color micolor)
        {
            if (Id == "PoligonoRegular")
            {
                PixelesTG = new List<Point>(Aux3);
            }
            for (int i = 0; i < PixelesTG.Count; i++)
            {
                int Xr = Convert.ToInt32(Xc + (PixelesTG[i].X - Xc) * Math.Cos(Angulo * Math.PI / 180) - (PixelesTG[i].Y - Yc) * Math.Sin(Angulo * Math.PI / 180));
                int Yr = Convert.ToInt32(Yc + (PixelesTG[i].X - Xc) * Math.Sin(Angulo * Math.PI / 180) + (PixelesTG[i].Y - Yc) * Math.Cos(Angulo * Math.PI / 180));
                TPixeles.Add(new Point(Xr, Yr));
            }
            switch (Id)
            {
                case "Recta":
                    Recta(PixelesTG, CFondo);
                    Recta(TPixeles, micolor);
                    break;
                case "PoligonoIrregular":
                    PoligonoIrregular(PixelesTG, CFondo);
                    PoligonoIrregular(TPixeles, micolor);
                    break;
                case "PoligonoRegular":
                    PoligonoIrregular(PixelesTG, CFondo);
                    PoligonoIrregular(TPixeles, micolor);
                    break;
                case "Elipse":
                    Elipse(PixelesTG, CFondo);
                    Auxiliar = Rx;
                    Rx = Ry;
                    Ry = Auxiliar;
                    Elipse(TPixeles, micolor);
                    break;
                case "FiguraNavidad":
                    FinalizoBorrado = false;
                    FiguraNavidad(PixelesTG, CFondo);
                    FinalizoBorrado = true;
                    FiguraNavidad(TPixeles, micolor);
                    break;

            }
            for (int j = 0; j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            Aux3 = new List<Point>(TPixeles);
            TPixeles.Clear();
        }

        //Escalamiento
        public void Escalamiento(List<Point> PixelesTG, Double Sx, Double Sy, Color micolor)
        {
            if (Id == "PoligonoRegular")
            {
                PixelesTG = new List<Point>(Aux3);
            }
            for (int i = 0; i < PixelesTG.Count; i++)
            {
                int Xs = Convert.ToInt32(Xc + Sx * (PixelesTG[i].X - Xc));
                int Ys = Convert.ToInt32(Yc + Sy * (PixelesTG[i].Y - Yc));
                TPixeles.Add(new Point(Xs, Ys));
            }
            switch (Id)
            {
                case "Recta":
                    Recta(PixelesTG, CFondo);
                    Recta(TPixeles, micolor);
                    break;
                case "PoligonoIrregular":
                    PoligonoIrregular(PixelesTG, CFondo);
                    PoligonoIrregular(TPixeles, micolor);
                    break;
                case "PoligonoRegular":
                    PoligonoIrregular(PixelesTG, CFondo);
                    PoligonoIrregular(TPixeles, micolor);
                    break;
                case "Circunferencia":
                    Circunferencia(PixelesTG, CFondo);
                    radio = Convert.ToInt32(Sx * radio);
                    Circunferencia(TPixeles, micolor);
                    break;

                case "Elipse":
                    Elipse(PixelesTG, CFondo);
                    Auxiliar = Rx;
                    Rx = Convert.ToInt32(Sx * Rx);
                    Ry = Convert.ToInt32(Sy * Ry);
                    Elipse(TPixeles, micolor);
                    break;
                case "FiguraNavidad":
                    FinalizoBorrado = false;
                    FiguraNavidad(PixelesTG, CFondo);
                    FinalizoBorrado = true;
                    FiguraNavidad(TPixeles, micolor);
                    break;

            }
            for (int j = 0; j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            Aux3 = new List<Point>(TPixeles);
            TPixeles.Clear();
        }

        // Figura Navideña
        public void FiguraNavidad(List<Point> Puntos, Color Micolor)
        {
            //LA FIGURA NAVIEÑA ES UN GORRO DE NAVIDAD
            radio = 15;
            if (Opcion == "Escalamiento" && FinalizoBorrado == true)
            {
                RadioFiguraNavideña = Convert.ToInt32(Sx * RadioFiguraNavideña);
            }
            Circunferencia(new List<Point> { new Point(Puntos[0].X, Puntos[0].Y) }, Micolor);
            radio = 40;
            Lados = 3;
            PoligonoIrregular(new List<Point> {
                    new Point(Puntos[1].X, Puntos[1].Y),
                    new Point(Puntos[2].X, Puntos[2].Y),
                    new Point(Puntos[3].X, Puntos[3].Y),
                    new Point(Puntos[4].X, Puntos[4].Y),
                }, Micolor);
            PoligonoIrregular(new List<Point> {
                    new Point(Puntos[5].X, Puntos[5].Y),
                    new Point(Puntos[6].X, Puntos[6].Y),
                    new Point(Puntos[7].X, Puntos[7].Y),
                }, Micolor);

            //Relleno de la figura
            if (Opcion != "Traslacion" && Opcion != "Rotacion" && Opcion != "Escalamiento")
            {
                Point puntoMedio = new Point((Puntos[5].X + Puntos[6].X + Puntos[7].X) / 3, (Puntos[5].Y + Puntos[6].Y + Puntos[7].Y) / 3);
                Relleno(puntoMedio.X, puntoMedio.Y, Color.Red);
            }
            else
            {
                if (FinalizoBorrado)
                    Micolor = Color.Red;

                Point puntoMedio = new Point((Puntos[5].X + Puntos[6].X + Puntos[7].X) / 3, (Puntos[5].Y + Puntos[6].Y + Puntos[7].Y) / 3);
                Relleno(puntoMedio.X, puntoMedio.Y, Micolor);
            }


            //Volviendo a los valores normales
            radio = 100;
            Lados = 0;

        }

    }
}