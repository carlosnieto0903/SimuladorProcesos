namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnlisto = new System.Windows.Forms.Button();
            this.listrecursos = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblverificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Proceso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proceso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamaño Proceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recursos a Usar:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(121, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(121, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // btnlisto
            // 
            this.btnlisto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisto.Location = new System.Drawing.Point(153, 293);
            this.btnlisto.Name = "btnlisto";
            this.btnlisto.Size = new System.Drawing.Size(75, 23);
            this.btnlisto.TabIndex = 7;
            this.btnlisto.Text = "Agregar";
            this.btnlisto.UseVisualStyleBackColor = true;
            // 
            // listrecursos
            // 
            this.listrecursos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listrecursos.FormattingEnabled = true;
            this.listrecursos.Items.AddRange(new object[] {
            "R1",
            "R2",
            "R3",
            "R4",
            "R5",
            "R6"});
            this.listrecursos.Location = new System.Drawing.Point(121, 130);
            this.listrecursos.Name = "listrecursos";
            this.listrecursos.Size = new System.Drawing.Size(63, 118);
            this.listrecursos.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kb";
            // 
            // txttamaño
            // 
            this.txttamaño.Location = new System.Drawing.Point(121, 95);
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(81, 20);
            this.txttamaño.TabIndex = 10;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(39, 293);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 23);
            this.btnverificar.TabIndex = 11;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblverificacion
            // 
            this.lblverificacion.AutoSize = true;
            this.lblverificacion.ForeColor = System.Drawing.Color.Red;
            this.lblverificacion.Location = new System.Drawing.Point(42, 262);
            this.lblverificacion.Name = "lblverificacion";
            this.lblverificacion.Size = new System.Drawing.Size(171, 13);
            this.lblverificacion.TabIndex = 13;
            this.lblverificacion.Text = "Valor Incorrecto. Intente de Nuevo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(254, 330);
            this.Controls.Add(this.lblverificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txttamaño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listrecursos);
            this.Controls.Add(this.btnlisto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "AGREGAR PROCESO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnlisto;
        private System.Windows.Forms.CheckedListBox listrecursos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblverificacion;
    }
}