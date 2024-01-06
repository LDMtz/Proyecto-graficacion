namespace Graficacion___Leoncio_Martinez
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuPixel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCircunferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoligonoIrregular = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLados = new System.Windows.Forms.ToolStripTextBox();
            this.númeroDeLadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoligonoRegular = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLados2 = new System.Windows.Forms.ToolStripTextBox();
            this.númeroDeLadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraslacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRotacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEscalamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncrementar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecrementar = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Colores = new System.Windows.Forms.GroupBox();
            this.btnLila = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnActual = new System.Windows.Forms.Button();
            this.paleta = new System.Windows.Forms.ColorDialog();
            this.gb_Tamano = new System.Windows.Forms.GroupBox();
            this.btn_Grande = new System.Windows.Forms.Button();
            this.btn_Mediano = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.gb_Estilos = new System.Windows.Forms.GroupBox();
            this.btn_Examen1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExamenFinal = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btn_Segmento = new System.Windows.Forms.Button();
            this.btn_Continua = new System.Windows.Forms.Button();
            this.btn_Punteada = new System.Windows.Forms.Button();
            this.btnPaleta = new System.Windows.Forms.Button();
            this.ptb_Lienzo = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.gb_Colores.SuspendLayout();
            this.gb_Tamano.SuspendLayout();
            this.gb_Estilos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Lienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPixel,
            this.menuRecta,
            this.menuCircunferencia,
            this.menuPoligonoIrregular,
            this.menuPoligonoRegular,
            this.menuElipse,
            this.menuTraslacion,
            this.menuRotacion,
            this.menuEscalamiento});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuPixel
            // 
            this.menuPixel.ForeColor = System.Drawing.Color.White;
            this.menuPixel.Name = "menuPixel";
            this.menuPixel.Size = new System.Drawing.Size(44, 20);
            this.menuPixel.Text = "Pixel";
            this.menuPixel.Click += new System.EventHandler(this.menuPixel_Click);
            // 
            // menuRecta
            // 
            this.menuRecta.ForeColor = System.Drawing.Color.White;
            this.menuRecta.Name = "menuRecta";
            this.menuRecta.Size = new System.Drawing.Size(48, 20);
            this.menuRecta.Text = "Recta";
            this.menuRecta.Click += new System.EventHandler(this.menuRecta_Click);
            // 
            // menuCircunferencia
            // 
            this.menuCircunferencia.ForeColor = System.Drawing.Color.White;
            this.menuCircunferencia.Name = "menuCircunferencia";
            this.menuCircunferencia.Size = new System.Drawing.Size(96, 20);
            this.menuCircunferencia.Text = "Circunferencia";
            this.menuCircunferencia.Click += new System.EventHandler(this.menuCircunferencia_Click);
            // 
            // menuPoligonoIrregular
            // 
            this.menuPoligonoIrregular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLados,
            this.númeroDeLadosToolStripMenuItem});
            this.menuPoligonoIrregular.ForeColor = System.Drawing.Color.White;
            this.menuPoligonoIrregular.Name = "menuPoligonoIrregular";
            this.menuPoligonoIrregular.Size = new System.Drawing.Size(114, 20);
            this.menuPoligonoIrregular.Text = "Poligono Irregular";
            this.menuPoligonoIrregular.Click += new System.EventHandler(this.menuPoligonoIrregular_Click);
            // 
            // toolStripLados
            // 
            this.toolStripLados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripLados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLados.Name = "toolStripLados";
            this.toolStripLados.Size = new System.Drawing.Size(100, 23);
            this.toolStripLados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripLados_KeyPress);
            // 
            // númeroDeLadosToolStripMenuItem
            // 
            this.númeroDeLadosToolStripMenuItem.Name = "númeroDeLadosToolStripMenuItem";
            this.númeroDeLadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.númeroDeLadosToolStripMenuItem.Text = "¿Número de lados ?";
            // 
            // menuPoligonoRegular
            // 
            this.menuPoligonoRegular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.pentagonoToolStripMenuItem,
            this.hexagonoToolStripMenuItem,
            this.toolStripLados2,
            this.númeroDeLadosToolStripMenuItem1});
            this.menuPoligonoRegular.ForeColor = System.Drawing.Color.White;
            this.menuPoligonoRegular.Name = "menuPoligonoRegular";
            this.menuPoligonoRegular.Size = new System.Drawing.Size(110, 20);
            this.menuPoligonoRegular.Text = "Poligono Regular";
            this.menuPoligonoRegular.Click += new System.EventHandler(this.menuPoligonoRegular_Click);
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click);
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pentagonoToolStripMenuItem.Text = "Pentagono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // hexagonoToolStripMenuItem
            // 
            this.hexagonoToolStripMenuItem.Name = "hexagonoToolStripMenuItem";
            this.hexagonoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.hexagonoToolStripMenuItem.Text = "Hexagono";
            this.hexagonoToolStripMenuItem.Click += new System.EventHandler(this.hexagonoToolStripMenuItem_Click);
            // 
            // toolStripLados2
            // 
            this.toolStripLados2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripLados2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripLados2.Name = "toolStripLados2";
            this.toolStripLados2.Size = new System.Drawing.Size(100, 23);
            this.toolStripLados2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripLados2_KeyPress);
            // 
            // númeroDeLadosToolStripMenuItem1
            // 
            this.númeroDeLadosToolStripMenuItem1.Name = "númeroDeLadosToolStripMenuItem1";
            this.númeroDeLadosToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.númeroDeLadosToolStripMenuItem1.Text = "¿Número de lados?";
            // 
            // menuElipse
            // 
            this.menuElipse.ForeColor = System.Drawing.Color.White;
            this.menuElipse.Name = "menuElipse";
            this.menuElipse.Size = new System.Drawing.Size(49, 20);
            this.menuElipse.Text = "Elipse";
            this.menuElipse.Click += new System.EventHandler(this.menuElipse_Click);
            // 
            // menuTraslacion
            // 
            this.menuTraslacion.ForeColor = System.Drawing.Color.White;
            this.menuTraslacion.Name = "menuTraslacion";
            this.menuTraslacion.Size = new System.Drawing.Size(71, 20);
            this.menuTraslacion.Text = "Traslacion";
            this.menuTraslacion.Click += new System.EventHandler(this.menuTraslacion_Click);
            // 
            // menuRotacion
            // 
            this.menuRotacion.ForeColor = System.Drawing.Color.White;
            this.menuRotacion.Name = "menuRotacion";
            this.menuRotacion.Size = new System.Drawing.Size(66, 20);
            this.menuRotacion.Text = "Rotación";
            this.menuRotacion.Click += new System.EventHandler(this.menuRotacion_Click);
            // 
            // menuEscalamiento
            // 
            this.menuEscalamiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIncrementar,
            this.menuDecrementar});
            this.menuEscalamiento.ForeColor = System.Drawing.Color.White;
            this.menuEscalamiento.Name = "menuEscalamiento";
            this.menuEscalamiento.Size = new System.Drawing.Size(89, 20);
            this.menuEscalamiento.Text = "Escalamiento";
            this.menuEscalamiento.Click += new System.EventHandler(this.menuEscalamiento_Click);
            // 
            // menuIncrementar
            // 
            this.menuIncrementar.Name = "menuIncrementar";
            this.menuIncrementar.Size = new System.Drawing.Size(142, 22);
            this.menuIncrementar.Text = "Incrementar";
            this.menuIncrementar.Click += new System.EventHandler(this.menuIncrementar_Click);
            // 
            // menuDecrementar
            // 
            this.menuDecrementar.Name = "menuDecrementar";
            this.menuDecrementar.Size = new System.Drawing.Size(142, 22);
            this.menuDecrementar.Text = "Decrementar";
            this.menuDecrementar.Click += new System.EventHandler(this.menuDecrementar_Click);
            // 
            // gb_Colores
            // 
            this.gb_Colores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Colores.Controls.Add(this.btnPaleta);
            this.gb_Colores.Controls.Add(this.btnLila);
            this.gb_Colores.Controls.Add(this.btnAzul);
            this.gb_Colores.Controls.Add(this.btnRojo);
            this.gb_Colores.Controls.Add(this.btnNaranja);
            this.gb_Colores.Controls.Add(this.btnVerde);
            this.gb_Colores.Controls.Add(this.btnNegro);
            this.gb_Colores.Controls.Add(this.btnActual);
            this.gb_Colores.ForeColor = System.Drawing.Color.White;
            this.gb_Colores.Location = new System.Drawing.Point(303, 34);
            this.gb_Colores.Name = "gb_Colores";
            this.gb_Colores.Size = new System.Drawing.Size(161, 65);
            this.gb_Colores.TabIndex = 2;
            this.gb_Colores.TabStop = false;
            this.gb_Colores.Text = "COLORES";
            // 
            // btnLila
            // 
            this.btnLila.BackColor = System.Drawing.Color.Purple;
            this.btnLila.Location = new System.Drawing.Point(94, 40);
            this.btnLila.Name = "btnLila";
            this.btnLila.Size = new System.Drawing.Size(16, 16);
            this.btnLila.TabIndex = 6;
            this.btnLila.UseVisualStyleBackColor = false;
            this.btnLila.Click += new System.EventHandler(this.btnLila_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(94, 19);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(16, 16);
            this.btnAzul.TabIndex = 5;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(72, 19);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(16, 16);
            this.btnRojo.TabIndex = 4;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.Orange;
            this.btnNaranja.Location = new System.Drawing.Point(72, 41);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(16, 16);
            this.btnNaranja.TabIndex = 3;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Location = new System.Drawing.Point(50, 40);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(16, 16);
            this.btnVerde.TabIndex = 2;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Black;
            this.btnNegro.Location = new System.Drawing.Point(50, 19);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(16, 16);
            this.btnNegro.TabIndex = 1;
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnActual
            // 
            this.btnActual.BackColor = System.Drawing.Color.Black;
            this.btnActual.Location = new System.Drawing.Point(6, 18);
            this.btnActual.Name = "btnActual";
            this.btnActual.Size = new System.Drawing.Size(38, 39);
            this.btnActual.TabIndex = 0;
            this.btnActual.UseVisualStyleBackColor = false;
            // 
            // gb_Tamano
            // 
            this.gb_Tamano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Tamano.Controls.Add(this.btn_Grande);
            this.gb_Tamano.Controls.Add(this.btn_Mediano);
            this.gb_Tamano.Controls.Add(this.btn_Normal);
            this.gb_Tamano.ForeColor = System.Drawing.Color.White;
            this.gb_Tamano.Location = new System.Drawing.Point(196, 34);
            this.gb_Tamano.Name = "gb_Tamano";
            this.gb_Tamano.Size = new System.Drawing.Size(101, 65);
            this.gb_Tamano.TabIndex = 8;
            this.gb_Tamano.TabStop = false;
            this.gb_Tamano.Text = "TAMAÑO";
            // 
            // btn_Grande
            // 
            this.btn_Grande.BackColor = System.Drawing.Color.Black;
            this.btn_Grande.Location = new System.Drawing.Point(63, 19);
            this.btn_Grande.Name = "btn_Grande";
            this.btn_Grande.Size = new System.Drawing.Size(32, 34);
            this.btn_Grande.TabIndex = 3;
            this.btn_Grande.UseVisualStyleBackColor = false;
            this.btn_Grande.Click += new System.EventHandler(this.btn_Grande_Click);
            // 
            // btn_Mediano
            // 
            this.btn_Mediano.BackColor = System.Drawing.Color.Black;
            this.btn_Mediano.Location = new System.Drawing.Point(32, 24);
            this.btn_Mediano.Name = "btn_Mediano";
            this.btn_Mediano.Size = new System.Drawing.Size(25, 26);
            this.btn_Mediano.TabIndex = 2;
            this.btn_Mediano.UseVisualStyleBackColor = false;
            this.btn_Mediano.Click += new System.EventHandler(this.btn_Mediano_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.BackColor = System.Drawing.Color.Black;
            this.btn_Normal.Location = new System.Drawing.Point(7, 27);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(19, 20);
            this.btn_Normal.TabIndex = 0;
            this.btn_Normal.UseVisualStyleBackColor = false;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // gb_Estilos
            // 
            this.gb_Estilos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Estilos.Controls.Add(this.btn_Segmento);
            this.gb_Estilos.Controls.Add(this.btn_Continua);
            this.gb_Estilos.Controls.Add(this.btn_Punteada);
            this.gb_Estilos.ForeColor = System.Drawing.Color.White;
            this.gb_Estilos.Location = new System.Drawing.Point(55, 34);
            this.gb_Estilos.Name = "gb_Estilos";
            this.gb_Estilos.Size = new System.Drawing.Size(135, 65);
            this.gb_Estilos.TabIndex = 9;
            this.gb_Estilos.TabStop = false;
            this.gb_Estilos.Text = "ESTILOS";
            // 
            // btn_Examen1
            // 
            this.btn_Examen1.ForeColor = System.Drawing.Color.Black;
            this.btn_Examen1.Location = new System.Drawing.Point(140, 17);
            this.btn_Examen1.Name = "btn_Examen1";
            this.btn_Examen1.Size = new System.Drawing.Size(66, 39);
            this.btn_Examen1.TabIndex = 10;
            this.btn_Examen1.Text = "Examen 1";
            this.btn_Examen1.UseVisualStyleBackColor = true;
            this.btn_Examen1.Click += new System.EventHandler(this.btn_Examen1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnManual);
            this.groupBox1.Controls.Add(this.btnExamenFinal);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btn_Examen1);
            this.groupBox1.Controls.Add(this.btnRelleno);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(470, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOTONES SECUNDARIOS";
            // 
            // btnExamenFinal
            // 
            this.btnExamenFinal.ForeColor = System.Drawing.Color.Black;
            this.btnExamenFinal.Location = new System.Drawing.Point(212, 17);
            this.btnExamenFinal.Name = "btnExamenFinal";
            this.btnExamenFinal.Size = new System.Drawing.Size(62, 39);
            this.btnExamenFinal.TabIndex = 11;
            this.btnExamenFinal.Text = "Examen Final";
            this.btnExamenFinal.UseVisualStyleBackColor = true;
            this.btnExamenFinal.Click += new System.EventHandler(this.btnExamenFinal_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.Black;
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.info;
            this.btnManual.Location = new System.Drawing.Point(96, 17);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(38, 39);
            this.btnManual.TabIndex = 12;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.borrar;
            this.btnBorrar.Location = new System.Drawing.Point(52, 17);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(38, 39);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.BackColor = System.Drawing.Color.Black;
            this.btnRelleno.ForeColor = System.Drawing.Color.White;
            this.btnRelleno.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.relleno;
            this.btnRelleno.Location = new System.Drawing.Point(8, 18);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(38, 39);
            this.btnRelleno.TabIndex = 8;
            this.btnRelleno.UseVisualStyleBackColor = false;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // btn_Segmento
            // 
            this.btn_Segmento.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.segemtada;
            this.btn_Segmento.Location = new System.Drawing.Point(5, 44);
            this.btn_Segmento.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Segmento.Name = "btn_Segmento";
            this.btn_Segmento.Size = new System.Drawing.Size(125, 16);
            this.btn_Segmento.TabIndex = 2;
            this.btn_Segmento.UseVisualStyleBackColor = true;
            this.btn_Segmento.Click += new System.EventHandler(this.btn_Segmento_Click);
            // 
            // btn_Continua
            // 
            this.btn_Continua.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.continua;
            this.btn_Continua.Location = new System.Drawing.Point(5, 14);
            this.btn_Continua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Continua.Name = "btn_Continua";
            this.btn_Continua.Size = new System.Drawing.Size(125, 16);
            this.btn_Continua.TabIndex = 0;
            this.btn_Continua.UseVisualStyleBackColor = true;
            this.btn_Continua.Click += new System.EventHandler(this.btn_Continua_Click);
            // 
            // btn_Punteada
            // 
            this.btn_Punteada.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.punteada;
            this.btn_Punteada.Location = new System.Drawing.Point(5, 29);
            this.btn_Punteada.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Punteada.Name = "btn_Punteada";
            this.btn_Punteada.Size = new System.Drawing.Size(125, 16);
            this.btn_Punteada.TabIndex = 1;
            this.btn_Punteada.UseVisualStyleBackColor = true;
            this.btn_Punteada.Click += new System.EventHandler(this.btn_Punteada_Click);
            // 
            // btnPaleta
            // 
            this.btnPaleta.BackColor = System.Drawing.Color.Black;
            this.btnPaleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaleta.BackgroundImage")));
            this.btnPaleta.Image = global::Graficacion___Leoncio_Martinez.Properties.Resources.paleta_img;
            this.btnPaleta.Location = new System.Drawing.Point(116, 18);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(38, 39);
            this.btnPaleta.TabIndex = 7;
            this.btnPaleta.UseVisualStyleBackColor = false;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // ptb_Lienzo
            // 
            this.ptb_Lienzo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_Lienzo.BackColor = System.Drawing.Color.White;
            this.ptb_Lienzo.Location = new System.Drawing.Point(42, 105);
            this.ptb_Lienzo.Name = "ptb_Lienzo";
            this.ptb_Lienzo.Size = new System.Drawing.Size(708, 308);
            this.ptb_Lienzo.TabIndex = 0;
            this.ptb_Lienzo.TabStop = false;
            this.ptb_Lienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptb_Lienzo_MouseClick);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Estilos);
            this.Controls.Add(this.gb_Tamano);
            this.Controls.Add(this.gb_Colores);
            this.Controls.Add(this.ptb_Lienzo);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "VentanaPrincipal";
            this.Text = "Elaborado por: Leoncio Martinez";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gb_Colores.ResumeLayout(false);
            this.gb_Tamano.ResumeLayout(false);
            this.gb_Estilos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Lienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Lienzo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuPixel;
        private System.Windows.Forms.ToolStripMenuItem menuRecta;
        private System.Windows.Forms.ToolStripMenuItem menuCircunferencia;
        private System.Windows.Forms.GroupBox gb_Colores;
        private System.Windows.Forms.Button btnActual;
        private System.Windows.Forms.Button btnLila;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.ColorDialog paleta;
        private System.Windows.Forms.GroupBox gb_Tamano;
        private System.Windows.Forms.Button btn_Mediano;
        private System.Windows.Forms.Button btn_Normal;
        private System.Windows.Forms.Button btn_Grande;
        private System.Windows.Forms.GroupBox gb_Estilos;
        private System.Windows.Forms.Button btn_Continua;
        private System.Windows.Forms.Button btn_Segmento;
        private System.Windows.Forms.Button btn_Punteada;
        private System.Windows.Forms.Button btn_Examen1;
        private System.Windows.Forms.ToolStripMenuItem menuPoligonoIrregular;
        private System.Windows.Forms.ToolStripMenuItem menuPoligonoRegular;
        private System.Windows.Forms.ToolStripTextBox toolStripLados;
        private System.Windows.Forms.ToolStripMenuItem númeroDeLadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripLados2;
        private System.Windows.Forms.ToolStripMenuItem númeroDeLadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuElipse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.ToolStripMenuItem menuTraslacion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ToolStripMenuItem menuRotacion;
        private System.Windows.Forms.ToolStripMenuItem menuEscalamiento;
        private System.Windows.Forms.ToolStripMenuItem menuIncrementar;
        private System.Windows.Forms.ToolStripMenuItem menuDecrementar;
        private System.Windows.Forms.Button btnExamenFinal;
        private System.Windows.Forms.Button btnManual;
    }
}

