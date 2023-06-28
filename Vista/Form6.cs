using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
         public Label getr1() { return this.lblr1; }
         public Label getr2() { return this.lblr2; }
         public Label getr3() { return this.lblr3; }
         public Label getr4() { return this.lblr4; }
         public Label getr5() { return this.lblr5; }
         public Label getr6() { return this.lblr6; }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }
    }
}
