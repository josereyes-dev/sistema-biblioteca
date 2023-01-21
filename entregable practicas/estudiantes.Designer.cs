
namespace entregable_practicas
{
    partial class estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estudiantes));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxestado = new System.Windows.Forms.ComboBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarprestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nomprestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxrol = new System.Windows.Forms.ComboBox();
            this.comboBoxgrado = new System.Windows.Forms.ComboBox();
            this.codprestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxobra = new System.Windows.Forms.ComboBox();
            this.fecha1txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "PRESTAMO DE LIBROS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "ESTADO";
            // 
            // comboBoxestado
            // 
            this.comboBoxestado.FormattingEnabled = true;
            this.comboBoxestado.Items.AddRange(new object[] {
            "ENTREGADO",
            "PENDIENTE"});
            this.comboBoxestado.Location = new System.Drawing.Point(305, 340);
            this.comboBoxestado.Name = "comboBoxestado";
            this.comboBoxestado.Size = new System.Drawing.Size(198, 21);
            this.comboBoxestado.TabIndex = 72;
            this.comboBoxestado.SelectedIndexChanged += new System.EventHandler(this.comboBoxestado_SelectedIndexChanged);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(305, 214);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(198, 20);
            this.telefono.TabIndex = 69;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "GRADO";
            // 
            // buscarprestamo
            // 
            this.buscarprestamo.Location = new System.Drawing.Point(107, 420);
            this.buscarprestamo.Name = "buscarprestamo";
            this.buscarprestamo.Size = new System.Drawing.Size(329, 20);
            this.buscarprestamo.TabIndex = 65;
            this.buscarprestamo.TextChanged += new System.EventHandler(this.buscarlibro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "BUSCAR";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(258, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 63;
            this.button5.Text = "EDITAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(163, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "BORRAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(10, 458);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(862, 114);
            this.dataGridView4.TabIndex = 61;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomprestamo
            // 
            this.nomprestamo.Location = new System.Drawing.Point(305, 148);
            this.nomprestamo.Name = "nomprestamo";
            this.nomprestamo.Size = new System.Drawing.Size(347, 20);
            this.nomprestamo.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "NOMBRE";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(797, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 74;
            this.button3.Text = "VOLVER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(305, 115);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(347, 20);
            this.idtxt.TabIndex = 76;
            this.idtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idtxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "N° DE IDENTIFICACIÓN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "NOMBRE OBRA";
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(305, 276);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(93, 20);
            this.cantidadtxt.TabIndex = 84;
            this.cantidadtxt.TextChanged += new System.EventHandler(this.cantidadtxt_TextChanged);
            this.cantidadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadtxt_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(285, 20);
            this.label14.TabIndex = 83;
            this.label14.Text = "CANTIDAD DE LIBROS PRESTADOS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 20);
            this.label15.TabIndex = 85;
            this.label15.Text = "FECHA DEL PRESTAMO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "ROL";
            // 
            // comboBoxrol
            // 
            this.comboBoxrol.FormattingEnabled = true;
            this.comboBoxrol.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "DOCENTE",
            "ADMINISTRATIVO"});
            this.comboBoxrol.Location = new System.Drawing.Point(305, 81);
            this.comboBoxrol.Name = "comboBoxrol";
            this.comboBoxrol.Size = new System.Drawing.Size(198, 21);
            this.comboBoxrol.TabIndex = 89;
            // 
            // comboBoxgrado
            // 
            this.comboBoxgrado.FormattingEnabled = true;
            this.comboBoxgrado.Items.AddRange(new object[] {
            "6-1",
            "6-2",
            "7-1",
            "7-2",
            "8-1",
            "8-2",
            "9-1",
            "9-2",
            "10-1",
            "10-2",
            "11-1",
            "11-2"});
            this.comboBoxgrado.Location = new System.Drawing.Point(305, 181);
            this.comboBoxgrado.Name = "comboBoxgrado";
            this.comboBoxgrado.Size = new System.Drawing.Size(198, 21);
            this.comboBoxgrado.TabIndex = 91;
            // 
            // codprestamo
            // 
            this.codprestamo.Enabled = false;
            this.codprestamo.Location = new System.Drawing.Point(305, 51);
            this.codprestamo.Name = "codprestamo";
            this.codprestamo.Size = new System.Drawing.Size(100, 20);
            this.codprestamo.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "CODIGO";
            // 
            // comboBoxobra
            // 
            this.comboBoxobra.FormattingEnabled = true;
            this.comboBoxobra.Location = new System.Drawing.Point(305, 246);
            this.comboBoxobra.Name = "comboBoxobra";
            this.comboBoxobra.Size = new System.Drawing.Size(347, 21);
            this.comboBoxobra.TabIndex = 94;
            // 
            // fecha1txt
            // 
            this.fecha1txt.Location = new System.Drawing.Point(305, 309);
            this.fecha1txt.Name = "fecha1txt";
            this.fecha1txt.Size = new System.Drawing.Size(198, 20);
            this.fecha1txt.TabIndex = 95;
            // 
            // estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 584);
            this.Controls.Add(this.fecha1txt);
            this.Controls.Add(this.comboBoxobra);
            this.Controls.Add(this.codprestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxgrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxrol);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxestado);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarprestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomprestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.AutoSizeChanged += new System.EventHandler(this.estudiantes_Load);
            this.Load += new System.EventHandler(this.estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxestado;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buscarprestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomprestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxrol;
        private System.Windows.Forms.ComboBox comboBoxgrado;
        private System.Windows.Forms.TextBox codprestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxobra;
        private System.Windows.Forms.TextBox fecha1txt;
    }
}