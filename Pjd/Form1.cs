namespace Pjd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4,nf ;
            string a, r;

            if ((textBox1.Text == "")) {
                MessageBox.Show("No se aceptan espacios");
                textBox1.Focus();

            } else if (textBox2.Text == "")
            {
                MessageBox.Show("No se aceptan espacios");
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No se aceptan espacios");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("No se aceptan espacios");
                textBox4.Focus();

            }
            else if ((textBox1.Text == ""&& textBox2.Text == "")&& (textBox3.Text == "" && textBox4.Text == ""))
            {
                MessageBox.Show("No se aceptan espacios");
                
            

        }else
            {
                n1=Convert.ToInt32(textBox1.Text);
                n2=Convert.ToInt32(textBox2.Text);
                n3=Convert.ToInt32(textBox3.Text);
                n4=Convert.ToInt32(textBox4.Text);
                if(n1<0 || n1 > 25)
                {
                    MessageBox.Show("Error, no se aceptan numeros negativos ni mayor a 25");
                    textBox1.Text = "";
                    textBox1.Focus();
                }else if(n2<0 || n2 > 25)
                {
                    MessageBox.Show("Error, no se aceptan numeros negativos ni mayor a 25");
                    textBox2.Text = "";
                    textBox2.Focus();
                }else if(n3 < 0 || n3 > 25)
                {
                    MessageBox.Show("Error, no se aceptan numeros negativos ni mayor a 25");
                    textBox3.Text = "";
                    textBox3.Focus();
                }else if(n4 < 0 || n4 > 25)
                {
                    MessageBox.Show("Error, no se aceptan numeros negativos ni mayor a 25");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else
                {
                    nf = n1 + n2 + n3 + n4;
                    textBox5.Text = nf.ToString();
                    if (nf < 60)
                    {
                        r = "REPROVADO";
                        textBox6.Text = r.ToString();
                    }
                    else
                    {
                        a = "APROVADO";
                        textBox6.Text = a.ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r=MessageBox.Show("Esta seguro que desea salir del programa?","NOTAS",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
}