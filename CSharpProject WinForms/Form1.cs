using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            unitSelection1.SelectedIndex = 0;
            unitSelection2.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal initialValue = decimal.Parse(inputUnitBox.Text);

            switch(unitSelection1.SelectedItem.ToString())
            {
                case "Nm":
                    initialValue = initialValue / 1000000;
                    break;
                case "μm":
                        initialValue = initialValue / 1000;
                    break;
                case "Cm":
                    initialValue = initialValue * 10;
                    break;
                case "M":
                    initialValue = initialValue * 1000;
                    break;
                case "Km":
                    initialValue = initialValue * 1000000;
                    break;
            }

            switch(unitSelection2.SelectedItem.ToString())
            {
                case "Nm":
                    initialValue = initialValue * 1000000;
                        break;
                case "μm":
                    initialValue = initialValue * 1000;
                    break;
                case "Cm":
                    initialValue = initialValue / 10;
                    break;
                case "M":
                    initialValue = initialValue / 1000;
                    break;
                case "Km":
                    initialValue = initialValue / 1000000;
                    break;
            }

            outputUnitBox.Text = initialValue.ToString();
        }
    }
}
