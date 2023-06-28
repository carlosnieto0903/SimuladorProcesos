using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public TextBox getIdP() { return this.txtid; }
        public TextBox getNom() { return this.txtnombre; }
        public TextBox getTam() { return this.txttamaño; }
        public Button getButton1() { return this.btnlisto; }
        public CheckedListBox getRec() { return this.listrecursos; }
        public Button getVerificar() { return this.btnverificar; }
        public Label getInfoVer() { return this.lblverificacion; }
        private void label6_Click(object sender, EventArgs e)
        {

        }



        

    }

}
