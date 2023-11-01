using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratoshenovo_sito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                if (N <= 1)
                {
                    MessageBox.Show("Nebyla nalezena žádná prvočísla!");
                }
                else
                {
                    bool[] prvocisla = new bool[N + 1];

                    for (int i = 2; i <= N; i++)
                    {
                        prvocisla[i] = true;
                    }

                    for (int a = 2; a * a <= N; a++)
                    {
                        if (prvocisla[a] == true)
                        {
                            for (int i = a * a; i <= N; i += a)
                            {
                                prvocisla[i] = false;
                            }
                        }
                    }

                    for (int i = 2; i <= N; i++)
                    {
                        if (prvocisla[i] == true)
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }

            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }
    }
}
