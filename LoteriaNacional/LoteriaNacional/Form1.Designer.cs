
namespace LoteriaNacional
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
            this.cmbDecenaMillar = new System.Windows.Forms.ComboBox();
            this.cmbUnidadMillar = new System.Windows.Forms.ComboBox();
            this.cmbCentenas = new System.Windows.Forms.ComboBox();
            this.cmbDecenas = new System.Windows.Forms.ComboBox();
            this.cmbUnidades = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblMinumero = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl5digitos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1digitos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl2Digitos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl3digitos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl4Digitos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDecenaMillar
            // 
            this.cmbDecenaMillar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecenaMillar.FormattingEnabled = true;
            this.cmbDecenaMillar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbDecenaMillar.Location = new System.Drawing.Point(45, 38);
            this.cmbDecenaMillar.Name = "cmbDecenaMillar";
            this.cmbDecenaMillar.Size = new System.Drawing.Size(121, 21);
            this.cmbDecenaMillar.TabIndex = 0;
            // 
            // cmbUnidadMillar
            // 
            this.cmbUnidadMillar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMillar.FormattingEnabled = true;
            this.cmbUnidadMillar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUnidadMillar.Location = new System.Drawing.Point(205, 38);
            this.cmbUnidadMillar.Name = "cmbUnidadMillar";
            this.cmbUnidadMillar.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadMillar.TabIndex = 1;
            // 
            // cmbCentenas
            // 
            this.cmbCentenas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentenas.FormattingEnabled = true;
            this.cmbCentenas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbCentenas.Location = new System.Drawing.Point(372, 38);
            this.cmbCentenas.Name = "cmbCentenas";
            this.cmbCentenas.Size = new System.Drawing.Size(121, 21);
            this.cmbCentenas.TabIndex = 2;
            // 
            // cmbDecenas
            // 
            this.cmbDecenas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecenas.FormattingEnabled = true;
            this.cmbDecenas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbDecenas.Location = new System.Drawing.Point(533, 38);
            this.cmbDecenas.Name = "cmbDecenas";
            this.cmbDecenas.Size = new System.Drawing.Size(121, 21);
            this.cmbDecenas.TabIndex = 3;
            // 
            // cmbUnidades
            // 
            this.cmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidades.FormattingEnabled = true;
            this.cmbUnidades.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUnidades.Location = new System.Drawing.Point(685, 38);
            this.cmbUnidades.Name = "cmbUnidades";
            this.cmbUnidades.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidades.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(171, 86);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(441, 41);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMinumero
            // 
            this.lblMinumero.AutoSize = true;
            this.lblMinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinumero.Location = new System.Drawing.Point(320, 145);
            this.lblMinumero.Name = "lblMinumero";
            this.lblMinumero.Size = new System.Drawing.Size(150, 33);
            this.lblMinumero.TabIndex = 6;
            this.lblMinumero.Text = "MiNumero";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl5digitos
            // 
            this.lbl5digitos.AutoSize = true;
            this.lbl5digitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5digitos.ForeColor = System.Drawing.Color.Red;
            this.lbl5digitos.Location = new System.Drawing.Point(168, 245);
            this.lbl5digitos.Name = "lbl5digitos";
            this.lbl5digitos.Size = new System.Drawing.Size(74, 24);
            this.lbl5digitos.TabIndex = 7;
            this.lbl5digitos.Text = "5digitos";
            this.lbl5digitos.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(577, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intentos5";
            // 
            // lbl1digitos
            // 
            this.lbl1digitos.AutoSize = true;
            this.lbl1digitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1digitos.ForeColor = System.Drawing.Color.Red;
            this.lbl1digitos.Location = new System.Drawing.Point(168, 418);
            this.lbl1digitos.Name = "lbl1digitos";
            this.lbl1digitos.Size = new System.Drawing.Size(67, 24);
            this.lbl1digitos.TabIndex = 9;
            this.lbl1digitos.Text = "1Digito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(577, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intentos1";
            // 
            // lbl2Digitos
            // 
            this.lbl2Digitos.AutoSize = true;
            this.lbl2Digitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Digitos.ForeColor = System.Drawing.Color.Red;
            this.lbl2Digitos.Location = new System.Drawing.Point(168, 384);
            this.lbl2Digitos.Name = "lbl2Digitos";
            this.lbl2Digitos.Size = new System.Drawing.Size(76, 24);
            this.lbl2Digitos.TabIndex = 12;
            this.lbl2Digitos.Text = "2Digitos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(577, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Intentos2";
            // 
            // lbl3digitos
            // 
            this.lbl3digitos.AutoSize = true;
            this.lbl3digitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3digitos.ForeColor = System.Drawing.Color.Red;
            this.lbl3digitos.Location = new System.Drawing.Point(168, 348);
            this.lbl3digitos.Name = "lbl3digitos";
            this.lbl3digitos.Size = new System.Drawing.Size(76, 24);
            this.lbl3digitos.TabIndex = 14;
            this.lbl3digitos.Text = "3Digitos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(577, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Intentos3";
            // 
            // lbl4Digitos
            // 
            this.lbl4Digitos.AutoSize = true;
            this.lbl4Digitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Digitos.ForeColor = System.Drawing.Color.Red;
            this.lbl4Digitos.Location = new System.Drawing.Point(168, 307);
            this.lbl4Digitos.Name = "lbl4Digitos";
            this.lbl4Digitos.Size = new System.Drawing.Size(76, 24);
            this.lbl4Digitos.TabIndex = 16;
            this.lbl4Digitos.Text = "4Digitos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(577, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Intentos4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero Rastreado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 33);
            this.label12.TabIndex = 18;
            this.label12.Text = "Repeticiones";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 422);
            this.label2.TabIndex = 19;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl4Digitos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl3digitos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl2Digitos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl1digitos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl5digitos);
            this.Controls.Add(this.lblMinumero);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbUnidades);
            this.Controls.Add(this.cmbDecenas);
            this.Controls.Add(this.cmbCentenas);
            this.Controls.Add(this.cmbUnidadMillar);
            this.Controls.Add(this.cmbDecenaMillar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Proyecto 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDecenaMillar;
        private System.Windows.Forms.ComboBox cmbUnidadMillar;
        private System.Windows.Forms.ComboBox cmbCentenas;
        private System.Windows.Forms.ComboBox cmbDecenas;
        private System.Windows.Forms.ComboBox cmbUnidades;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblMinumero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl5digitos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1digitos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl2Digitos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl3digitos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl4Digitos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}

