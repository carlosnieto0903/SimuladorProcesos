using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txttiempo.Enabled= false;
            txtnuevo.Enabled = false;
            txtlisto.Enabled = false;
            txtejecutando.Enabled = false;
            txtbloqueado.Enabled = false;
            txtterminado.Enabled = false;
            listproc.Enabled = false;
            
        }

        public TextBox getNuevo() { return this.txtnuevo; }
        public TextBox getProcesos() { return this.listproc; }
        public Button getButton() { return this.btncrear; }
        public TextBox getRand() { return this.txttiempo; }
        public Button getEjec() { return this.btnejecutar; }
        public TextBox getListo() { return this.txtlisto; }
        public TextBox getEjecu() { return this.txtejecutando; }
        public Label getlbltam0() { return this.lbltam0; }
        public Label getlbltam() { return this.lbltam; }
        public Label getlbltam1() { return this.lbltam1; }
        public Label getlblproc0() { return this.lbltpr0; }
        public Label getlblproc() { return this.lbltpr; }
        public Label getlblproc1() { return this.lbltpr1; }
        public TextBox getRec() { return this.txtrecursos; }
        public TextBox getTerminado() { return this.txtterminado; }
        public Label getCantP() { return this.lblcant; }
        public TextBox getBloq() { return this.txtbloqueado; }
       
        // public DataGridView getDatos() { return this.TablaDatos; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void listproc_TextChanged(object sender, EventArgs e)
        {
//??
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
