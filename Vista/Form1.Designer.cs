namespace WindowsFormsApp1
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
            this.txtnuevo = new System.Windows.Forms.TextBox();
            this.listproc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlisto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbloqueado = new System.Windows.Forms.TextBox();
            this.txtejecutando = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtterminado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtrecursos = new System.Windows.Forms.TextBox();
            this.lbltam0 = new System.Windows.Forms.Label();
            this.lbltam1 = new System.Windows.Forms.Label();
            this.lbltam = new System.Windows.Forms.Label();
            this.lbltpr = new System.Windows.Forms.Label();
            this.lbltpr1 = new System.Windows.Forms.Label();
            this.lbltpr0 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnuevo
            // 
            this.txtnuevo.Location = new System.Drawing.Point(21, 82);
            this.txtnuevo.Multiline = true;
            this.txtnuevo.Name = "txtnuevo";
            this.txtnuevo.Size = new System.Drawing.Size(109, 56);
            this.txtnuevo.TabIndex = 0;
            // 
            // listproc
            // 
            this.listproc.Location = new System.Drawing.Point(54, 297);
            this.listproc.Multiline = true;
            this.listproc.Name = "listproc";
            this.listproc.Size = new System.Drawing.Size(457, 79);
            this.listproc.TabIndex = 2;
            this.listproc.TextChanged += new System.EventHandler(this.listproc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUEVO";
            // 
            // txtlisto
            // 
            this.txtlisto.Location = new System.Drawing.Point(169, 82);
            this.txtlisto.Multiline = true;
            this.txtlisto.Name = "txtlisto";
            this.txtlisto.Size = new System.Drawing.Size(109, 56);
            this.txtlisto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "LISTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "BLOQUEADO";
            // 
            // txtbloqueado
            // 
            this.txtbloqueado.Location = new System.Drawing.Point(169, 203);
            this.txtbloqueado.Multiline = true;
            this.txtbloqueado.Name = "txtbloqueado";
            this.txtbloqueado.Size = new System.Drawing.Size(109, 56);
            this.txtbloqueado.TabIndex = 7;
            // 
            // txtejecutando
            // 
            this.txtejecutando.Location = new System.Drawing.Point(318, 82);
            this.txtejecutando.Multiline = true;
            this.txtejecutando.Name = "txtejecutando";
            this.txtejecutando.Size = new System.Drawing.Size(109, 56);
            this.txtejecutando.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "EJECUTANDO";
            // 
            // txtterminado
            // 
            this.txtterminado.Location = new System.Drawing.Point(466, 82);
            this.txtterminado.Multiline = true;
            this.txtterminado.Name = "txtterminado";
            this.txtterminado.Size = new System.Drawing.Size(109, 56);
            this.txtterminado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "TERMINADO";
            // 
            // btnejecutar
            // 
            this.btnejecutar.BackColor = System.Drawing.Color.Lime;
            this.btnejecutar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutar.Location = new System.Drawing.Point(636, 134);
            this.btnejecutar.Margin = new System.Windows.Forms.Padding(0);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(95, 31);
            this.btnejecutar.TabIndex = 15;
            this.btnejecutar.Text = "Ejecutar";
            this.btnejecutar.UseVisualStyleBackColor = false;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(310, 20);
            this.txttiempo.Multiline = true;
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Random:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "NOMBRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "TAMAÑO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(291, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "ESTADO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "RECURSOS";
            // 
            // txtrecursos
            // 
            this.txtrecursos.Location = new System.Drawing.Point(585, 257);
            this.txtrecursos.Multiline = true;
            this.txtrecursos.Name = "txtrecursos";
            this.txtrecursos.Size = new System.Drawing.Size(180, 119);
            this.txtrecursos.TabIndex = 30;
            // 
            // lbltam0
            // 
            this.lbltam0.AutoSize = true;
            this.lbltam0.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltam0.ForeColor = System.Drawing.Color.Blue;
            this.lbltam0.Location = new System.Drawing.Point(590, 23);
            this.lbltam0.Name = "lbltam0";
            this.lbltam0.Size = new System.Drawing.Size(88, 17);
            this.lbltam0.TabIndex = 31;
            this.lbltam0.Text = "Tamaño Disp. :";
            // 
            // lbltam1
            // 
            this.lbltam1.AutoSize = true;
            this.lbltam1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltam1.ForeColor = System.Drawing.Color.Blue;
            this.lbltam1.Location = new System.Drawing.Point(714, 25);
            this.lbltam1.Name = "lbltam1";
            this.lbltam1.Size = new System.Drawing.Size(68, 17);
            this.lbltam1.TabIndex = 32;
            this.lbltam1.Text = "/   1000 kb";
            // 
            // lbltam
            // 
            this.lbltam.AutoSize = true;
            this.lbltam.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltam.ForeColor = System.Drawing.Color.Blue;
            this.lbltam.Location = new System.Drawing.Point(680, 25);
            this.lbltam.Name = "lbltam";
            this.lbltam.Size = new System.Drawing.Size(34, 17);
            this.lbltam.TabIndex = 33;
            this.lbltam.Text = "1000";
            // 
            // lbltpr
            // 
            this.lbltpr.AutoSize = true;
            this.lbltpr.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpr.ForeColor = System.Drawing.Color.Red;
            this.lbltpr.Location = new System.Drawing.Point(691, 52);
            this.lbltpr.Name = "lbltpr";
            this.lbltpr.Size = new System.Drawing.Size(19, 17);
            this.lbltpr.TabIndex = 36;
            this.lbltpr.Text = "P1";
            this.lbltpr.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbltpr1
            // 
            this.lbltpr1.AutoSize = true;
            this.lbltpr1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpr1.ForeColor = System.Drawing.Color.Red;
            this.lbltpr1.Location = new System.Drawing.Point(717, 52);
            this.lbltpr1.Name = "lbltpr1";
            this.lbltpr1.Size = new System.Drawing.Size(48, 17);
            this.lbltpr1.TabIndex = 35;
            this.lbltpr1.Text = "=  1000";
            this.lbltpr1.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbltpr0
            // 
            this.lbltpr0.AutoSize = true;
            this.lbltpr0.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltpr0.ForeColor = System.Drawing.Color.Red;
            this.lbltpr0.Location = new System.Drawing.Point(594, 50);
            this.lbltpr0.Name = "lbltpr0";
            this.lbltpr0.Size = new System.Drawing.Size(98, 17);
            this.lbltpr0.TabIndex = 34;
            this.lbltpr0.Text = "Tamaño Proceso:";
            this.lbltpr0.Click += new System.EventHandler(this.label14_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.Yellow;
            this.btncrear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Location = new System.Drawing.Point(623, 168);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(121, 36);
            this.btncrear.TabIndex = 37;
            this.btncrear.Text = "Agregar Proceso";
            this.btncrear.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(607, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cantidad Procesos:";
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant.ForeColor = System.Drawing.Color.Green;
            this.lblcant.Location = new System.Drawing.Point(724, 80);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(20, 17);
            this.lblcant.TabIndex = 39;
            this.lblcant.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "----->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "----->";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "----->";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(217, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 26);
            this.label16.TabIndex = 43;
            this.label16.Text = "^\r\n |";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(817, 406);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.lbltpr);
            this.Controls.Add(this.lbltpr1);
            this.Controls.Add(this.lbltpr0);
            this.Controls.Add(this.lbltam);
            this.Controls.Add(this.lbltam1);
            this.Controls.Add(this.lbltam0);
            this.Controls.Add(this.txtrecursos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtterminado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtejecutando);
            this.Controls.Add(this.txtbloqueado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlisto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listproc);
            this.Controls.Add(this.txtnuevo);
            this.Name = "Form1";
            this.Text = "SIMULADOR PROCESOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtnuevo;
        private System.Windows.Forms.TextBox listproc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbloqueado;
        private System.Windows.Forms.TextBox txtejecutando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtterminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrecursos;
        private System.Windows.Forms.Label lbltam0;
        private System.Windows.Forms.Label lbltam1;
        private System.Windows.Forms.Label lbltam;
        private System.Windows.Forms.Label lbltpr;
        private System.Windows.Forms.Label lbltpr1;
        private System.Windows.Forms.Label lbltpr0;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

