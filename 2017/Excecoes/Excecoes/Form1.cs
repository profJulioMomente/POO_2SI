using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            try
            {
                int v1 = Convert.ToInt32(textBox1.Text);
                int v2 = Convert.ToInt32(textBox2.Text);

                
                int res = v1 / v2;

                textBox3.Text = res.ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch(DivideByZeroException de)
            {
                MessageBox.Show(de.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
