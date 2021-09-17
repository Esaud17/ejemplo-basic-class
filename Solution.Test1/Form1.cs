using Solution.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution.Test1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelIsPrimo.Text = "";
            labelIsParOrImpar.Text = "";
        }

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    this.ShowResult();
                    break;

                case (char)8:
                    this.ClearResult();
                    break;

                case (char)27:
                    this.Dispose();
                    break;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void ClearResult()
        {
            LabelIsPrimo.Text = "";
            labelIsParOrImpar.Text = "";
            TextBoxNumber.Text = "";
        }


        private void ShowResult()
        {
            string value = TextBoxNumber.Text;
            if (!String.IsNullOrEmpty(value) && value != ".")
            {
                int number;
                int.TryParse(value, out number);

                LabelIsPrimo.Text = (Utils.IsPrime(number)) ? "SI" : "NO";
                labelIsParOrImpar.Text = (Utils.IsPar(number))? "PAR" :"IMPAR";
            }
        }



    }
}
