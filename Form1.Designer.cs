namespace Calculadora_de_Areas2
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
            rdbquadrado = new RadioButton();
            rdbretangulo = new RadioButton();
            rdbtriangulo = new RadioButton();
            rdbcirculo = new RadioButton();
            rdbtrapezio = new RadioButton();
            lbltitulo = new Label();
            label5 = new Label();
            label4 = new Label();
            lblexpressao = new Label();
            lblresultado = new Label();
            btncalcular = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            lbldescricaoformula = new Label();
            lblformula = new Label();
            imgarea = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgarea).BeginInit();
            SuspendLayout();
            // 
            // rdbquadrado
            // 
            rdbquadrado.AutoSize = true;
            rdbquadrado.Location = new Point(37, 62);
            rdbquadrado.Name = "rdbquadrado";
            rdbquadrado.Size = new Size(120, 19);
            rdbquadrado.TabIndex = 0;
            rdbquadrado.TabStop = true;
            rdbquadrado.Text = "Area do quadrado";
            rdbquadrado.UseVisualStyleBackColor = true;
            rdbquadrado.CheckedChanged += rdbquadrado_CheckedChanged;
            // 
            // rdbretangulo
            // 
            rdbretangulo.AutoSize = true;
            rdbretangulo.Location = new Point(37, 107);
            rdbretangulo.Name = "rdbretangulo";
            rdbretangulo.Size = new Size(118, 19);
            rdbretangulo.TabIndex = 1;
            rdbretangulo.TabStop = true;
            rdbretangulo.Text = "area do retangulo";
            rdbretangulo.UseVisualStyleBackColor = true;
            rdbretangulo.CheckedChanged += rdbretangulo_CheckedChanged;
            // 
            // rdbtriangulo
            // 
            rdbtriangulo.AutoSize = true;
            rdbtriangulo.Location = new Point(37, 154);
            rdbtriangulo.Name = "rdbtriangulo";
            rdbtriangulo.Size = new Size(115, 19);
            rdbtriangulo.TabIndex = 2;
            rdbtriangulo.TabStop = true;
            rdbtriangulo.Text = "area do triangulo";
            rdbtriangulo.UseVisualStyleBackColor = true;
            rdbtriangulo.CheckedChanged += rdbtriangulo_CheckedChanged;
            // 
            // rdbcirculo
            // 
            rdbcirculo.AutoSize = true;
            rdbcirculo.Location = new Point(37, 199);
            rdbcirculo.Name = "rdbcirculo";
            rdbcirculo.Size = new Size(103, 19);
            rdbcirculo.TabIndex = 3;
            rdbcirculo.TabStop = true;
            rdbcirculo.Text = "area do circulo";
            rdbcirculo.UseVisualStyleBackColor = true;
            rdbcirculo.CheckedChanged += rdbcirculo_CheckedChanged;
            // 
            // rdbtrapezio
            // 
            rdbtrapezio.AutoSize = true;
            rdbtrapezio.Location = new Point(37, 239);
            rdbtrapezio.Name = "rdbtrapezio";
            rdbtrapezio.Size = new Size(109, 19);
            rdbtrapezio.TabIndex = 4;
            rdbtrapezio.TabStop = true;
            rdbtrapezio.Text = "area do trapezio";
            rdbtrapezio.UseVisualStyleBackColor = true;
            rdbtrapezio.CheckedChanged += rdbtrapezio_CheckedChanged;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.Location = new Point(69, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(82, 37);
            lbltitulo.TabIndex = 5;
            lbltitulo.Text = "Areas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 340);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 340);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Expressão";
            // 
            // lblexpressao
            // 
            lblexpressao.AutoSize = true;
            lblexpressao.Location = new Point(119, 355);
            lblexpressao.Name = "lblexpressao";
            lblexpressao.Size = new Size(38, 15);
            lblexpressao.TabIndex = 8;
            lblexpressao.Text = "label1";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(300, 355);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(38, 15);
            lblresultado.TabIndex = 9;
            lblresultado.Text = "label2";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(627, 405);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 10;
            btncalcular.Text = "&Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(178, 288);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 11;
            lbl1.Text = "label3";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(313, 288);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 12;
            lbl2.Text = "label4";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(448, 288);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(38, 15);
            lbl3.TabIndex = 13;
            lbl3.Text = "label5";
            // 
            // txt1
            // 
            txt1.Location = new Point(178, 306);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 14;
            // 
            // txt2
            // 
            txt2.Location = new Point(313, 306);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 15;
            // 
            // txt3
            // 
            txt3.Location = new Point(448, 306);
            txt3.Name = "txt3";
            txt3.Size = new Size(100, 23);
            txt3.TabIndex = 16;
            // 
            // lbldescricaoformula
            // 
            lbldescricaoformula.AutoSize = true;
            lbldescricaoformula.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbldescricaoformula.Location = new Point(540, 175);
            lbldescricaoformula.Name = "lbldescricaoformula";
            lbldescricaoformula.Size = new Size(84, 28);
            lbldescricaoformula.TabIndex = 17;
            lbldescricaoformula.Text = "Formula";
            // 
            // lblformula
            // 
            lblformula.AutoSize = true;
            lblformula.Location = new Point(540, 203);
            lblformula.Name = "lblformula";
            lblformula.Size = new Size(38, 15);
            lblformula.TabIndex = 18;
            lblformula.Text = "label7";
            // 
            // imgarea
            // 
            imgarea.Image = Properties.Resources.circulo;
            imgarea.Location = new Point(220, 12);
            imgarea.Name = "imgarea";
            imgarea.Size = new Size(314, 218);
            imgarea.SizeMode = PictureBoxSizeMode.StretchImage;
            imgarea.TabIndex = 19;
            imgarea.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgarea);
            Controls.Add(lblformula);
            Controls.Add(lbldescricaoformula);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btncalcular);
            Controls.Add(lblresultado);
            Controls.Add(lblexpressao);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lbltitulo);
            Controls.Add(rdbtrapezio);
            Controls.Add(rdbcirculo);
            Controls.Add(rdbtriangulo);
            Controls.Add(rdbretangulo);
            Controls.Add(rdbquadrado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbquadrado;
        private RadioButton rdbretangulo;
        private RadioButton rdbtriangulo;
        private RadioButton rdbcirculo;
        private RadioButton rdbtrapezio;
        private Label lbltitulo;
        private Label label5;
        private Label label4;
        private Label lblexpressao;
        private Label lblresultado;
        private Button btncalcular;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Label lbldescricaoformula;
        private Label lblformula;
        private PictureBox imgarea;
    }
}