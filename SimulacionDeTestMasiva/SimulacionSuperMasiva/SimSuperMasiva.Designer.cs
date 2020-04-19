namespace SimulacionSuperMasiva
{
    partial class SimSuperMasiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimSuperMasiva));
            this.button_iniciar_simulacion = new System.Windows.Forms.Button();
            this.numericUpDown_infectados_por_millon_supuesto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_numero_de_simulaciones = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.numericUpDown_primera_etapa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_segunda_etapa = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_resultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_multiplicacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_tercera_etapa = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_efectividad_de_test_estandar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_efectividad_de_mezcla_primera_etapa = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown_repeticiones_primera_etapa = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown_repeticiones_segunda_etapa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_infectados_por_millon_supuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero_de_simulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_primera_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segunda_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tercera_etapa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_test_estandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_mezcla_primera_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_mezcla_segunda_etapa)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_repeticiones_primera_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_repeticiones_segunda_etapa)).BeginInit();
            this.SuspendLayout();
            // 
            // button_iniciar_simulacion
            // 
            this.button_iniciar_simulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar_simulacion.Location = new System.Drawing.Point(3, 604);
            this.button_iniciar_simulacion.Name = "button_iniciar_simulacion";
            this.button_iniciar_simulacion.Size = new System.Drawing.Size(1082, 49);
            this.button_iniciar_simulacion.TabIndex = 0;
            this.button_iniciar_simulacion.Text = "Iniciar simulación";
            this.button_iniciar_simulacion.UseVisualStyleBackColor = true;
            this.button_iniciar_simulacion.Click += new System.EventHandler(this.button_iniciar_simulacion_Click);
            // 
            // numericUpDown_infectados_por_millon_supuesto
            // 
            this.numericUpDown_infectados_por_millon_supuesto.DecimalPlaces = 2;
            this.numericUpDown_infectados_por_millon_supuesto.Location = new System.Drawing.Point(18, 84);
            this.numericUpDown_infectados_por_millon_supuesto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_infectados_por_millon_supuesto.Name = "numericUpDown_infectados_por_millon_supuesto";
            this.numericUpDown_infectados_por_millon_supuesto.Size = new System.Drawing.Size(188, 20);
            this.numericUpDown_infectados_por_millon_supuesto.TabIndex = 1;
            this.numericUpDown_infectados_por_millon_supuesto.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown_numero_de_simulaciones
            // 
            this.numericUpDown_numero_de_simulaciones.Location = new System.Drawing.Point(18, 26);
            this.numericUpDown_numero_de_simulaciones.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_numero_de_simulaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numero_de_simulaciones.Name = "numericUpDown_numero_de_simulaciones";
            this.numericUpDown_numero_de_simulaciones.Size = new System.Drawing.Size(188, 20);
            this.numericUpDown_numero_de_simulaciones.TabIndex = 3;
            this.numericUpDown_numero_de_simulaciones.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 659);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(571, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(580, 659);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // numericUpDown_primera_etapa
            // 
            this.numericUpDown_primera_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_primera_etapa.Location = new System.Drawing.Point(18, 53);
            this.numericUpDown_primera_etapa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.Name = "numericUpDown_primera_etapa";
            this.numericUpDown_primera_etapa.Size = new System.Drawing.Size(185, 31);
            this.numericUpDown_primera_etapa.TabIndex = 7;
            this.numericUpDown_primera_etapa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.ValueChanged += new System.EventHandler(this.numericUpDown_primera_etapa_ValueChanged);
            // 
            // numericUpDown_segunda_etapa
            // 
            this.numericUpDown_segunda_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_segunda_etapa.Location = new System.Drawing.Point(260, 53);
            this.numericUpDown_segunda_etapa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.Name = "numericUpDown_segunda_etapa";
            this.numericUpDown_segunda_etapa.Size = new System.Drawing.Size(188, 31);
            this.numericUpDown_segunda_etapa.TabIndex = 8;
            this.numericUpDown_segunda_etapa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.ValueChanged += new System.EventHandler(this.numericUpDown_segunda_etapa_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Primera etapa de multiplicación de test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Segunda etapa de multiplicación de test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(703, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado, que es la cantidad de test promedio que fueron necesarios para descubr" +
    "ir todos los infectados";
            // 
            // textBox1_resultado
            // 
            this.textBox1_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_resultado.ForeColor = System.Drawing.Color.Blue;
            this.textBox1_resultado.Location = new System.Drawing.Point(3, 708);
            this.textBox1_resultado.Multiline = true;
            this.textBox1_resultado.Name = "textBox1_resultado";
            this.textBox1_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1_resultado.Size = new System.Drawing.Size(1082, 179);
            this.textBox1_resultado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(718, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "=";
            // 
            // label_multiplicacion
            // 
            this.label_multiplicacion.AutoSize = true;
            this.label_multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multiplicacion.Location = new System.Drawing.Point(758, 56);
            this.label_multiplicacion.Name = "label_multiplicacion";
            this.label_multiplicacion.Size = new System.Drawing.Size(54, 24);
            this.label_multiplicacion.TabIndex = 15;
            this.label_multiplicacion.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Ivory;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(793, 52);
            this.label8.TabIndex = 16;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(843, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Es la muestra elegida, que depende \r\nde las etapas de multiplicación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(826, 80);
            this.label10.TabIndex = 18;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(467, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "X";
            // 
            // numericUpDown_tercera_etapa
            // 
            this.numericUpDown_tercera_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tercera_etapa.Location = new System.Drawing.Point(508, 52);
            this.numericUpDown_tercera_etapa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_tercera_etapa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_tercera_etapa.Name = "numericUpDown_tercera_etapa";
            this.numericUpDown_tercera_etapa.Size = new System.Drawing.Size(188, 31);
            this.numericUpDown_tercera_etapa.TabIndex = 20;
            this.numericUpDown_tercera_etapa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_tercera_etapa.ValueChanged += new System.EventHandler(this.numericUpDown_tercera_etapa_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tercera etapa de multiplicación de test";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown_infectados_por_millon_supuesto);
            this.groupBox1.Location = new System.Drawing.Point(7, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 119);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de infectados por millón de habitantes que se supone (ésta cifra irá cam" +
    "biando a lo largo de los días)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.numericUpDown_numero_de_simulaciones);
            this.groupBox2.Location = new System.Drawing.Point(7, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número de simulaciones (poner un número grande puede afectar el rendimiento)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MintCream;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown_primera_etapa);
            this.groupBox3.Controls.Add(this.numericUpDown_segunda_etapa);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown_tercera_etapa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_multiplicacion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(7, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1078, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Etapas de multiplicación";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MintCream;
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.numericUpDown_efectividad_de_mezcla_segunda_etapa);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.numericUpDown_efectividad_de_mezcla_primera_etapa);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown_efectividad_de_test_estandar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(7, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1078, 184);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Efectividad de cada tipo de test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectividad de los test estándar";
            // 
            // numericUpDown_efectividad_de_test_estandar
            // 
            this.numericUpDown_efectividad_de_test_estandar.DecimalPlaces = 2;
            this.numericUpDown_efectividad_de_test_estandar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_efectividad_de_test_estandar.Location = new System.Drawing.Point(18, 45);
            this.numericUpDown_efectividad_de_test_estandar.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown_efectividad_de_test_estandar.Name = "numericUpDown_efectividad_de_test_estandar";
            this.numericUpDown_efectividad_de_test_estandar.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_efectividad_de_test_estandar.TabIndex = 1;
            this.numericUpDown_efectividad_de_test_estandar.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efectividad de las mezcla de test en la primera etapa de multiplicación";
            // 
            // numericUpDown_efectividad_de_mezcla_primera_etapa
            // 
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.DecimalPlaces = 2;
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Location = new System.Drawing.Point(18, 97);
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Name = "numericUpDown_efectividad_de_mezcla_primera_etapa";
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.TabIndex = 3;
            this.numericUpDown_efectividad_de_mezcla_primera_etapa.Value = new decimal(new int[] {
            94,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Ivory;
            this.label13.Location = new System.Drawing.Point(129, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(814, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Éste parámetro se puede determinar con experimentación, e indica la efectividad d" +
    "e mescalar los diferentes test en la primera etapa, por ejemplo al combinar 1000" +
    " muestras";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Ivory;
            this.label14.Location = new System.Drawing.Point(129, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Es la efectividad de los test que se realizan actualmente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Ivory;
            this.label15.Location = new System.Drawing.Point(129, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(815, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Éste parámetro se puede determinar con experimentación, e indica la efectividad d" +
    "e mescalar los diferentes test en la segunda etapa, por ejemplo al combinar 100 " +
    "muestras";
            // 
            // numericUpDown_efectividad_de_mezcla_segunda_etapa
            // 
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.DecimalPlaces = 2;
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Location = new System.Drawing.Point(18, 154);
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Name = "numericUpDown_efectividad_de_mezcla_segunda_etapa";
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.TabIndex = 7;
            this.numericUpDown_efectividad_de_mezcla_segunda_etapa.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(343, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Efectividad de las mezcla de test en la segunda etapa de multiplicación";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.MintCream;
            this.groupBox5.Controls.Add(this.numericUpDown_repeticiones_segunda_etapa);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.numericUpDown_repeticiones_primera_etapa);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(420, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(665, 60);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Repeticiones de etapas (Dos repeticiones aumenta significativamente la probabilid" +
    "ad de encontrar más infectados)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Primera etapa (Ej. 1000 test)";
            // 
            // numericUpDown_repeticiones_primera_etapa
            // 
            this.numericUpDown_repeticiones_primera_etapa.Location = new System.Drawing.Point(169, 26);
            this.numericUpDown_repeticiones_primera_etapa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_repeticiones_primera_etapa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_repeticiones_primera_etapa.Name = "numericUpDown_repeticiones_primera_etapa";
            this.numericUpDown_repeticiones_primera_etapa.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_repeticiones_primera_etapa.TabIndex = 1;
            this.numericUpDown_repeticiones_primera_etapa.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(270, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Segunda etapa (Ej. 100 test)";
            // 
            // numericUpDown_repeticiones_segunda_etapa
            // 
            this.numericUpDown_repeticiones_segunda_etapa.Location = new System.Drawing.Point(418, 26);
            this.numericUpDown_repeticiones_segunda_etapa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_repeticiones_segunda_etapa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_repeticiones_segunda_etapa.Name = "numericUpDown_repeticiones_segunda_etapa";
            this.numericUpDown_repeticiones_segunda_etapa.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_repeticiones_segunda_etapa.TabIndex = 3;
            this.numericUpDown_repeticiones_segunda_etapa.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SimOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 885);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_iniciar_simulacion);
            this.MaximizeBox = false;
            this.Name = "SimOT";
            this.Text = "Simulación para la aplicación masiva de test para el Covid-19 (de tres etapas)";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_infectados_por_millon_supuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero_de_simulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_primera_etapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segunda_etapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tercera_etapa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_test_estandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_mezcla_primera_etapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_efectividad_de_mezcla_segunda_etapa)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_repeticiones_primera_etapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_repeticiones_segunda_etapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_iniciar_simulacion;
        private System.Windows.Forms.NumericUpDown numericUpDown_infectados_por_millon_supuesto;
        private System.Windows.Forms.NumericUpDown numericUpDown_numero_de_simulaciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.NumericUpDown numericUpDown_primera_etapa;
        private System.Windows.Forms.NumericUpDown numericUpDown_segunda_etapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_resultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_multiplicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_tercera_etapa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown_efectividad_de_mezcla_segunda_etapa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_efectividad_de_mezcla_primera_etapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_efectividad_de_test_estandar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown_repeticiones_segunda_etapa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown_repeticiones_primera_etapa;
        private System.Windows.Forms.Label label17;
    }
}

