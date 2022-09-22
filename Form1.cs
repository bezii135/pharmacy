using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace c_assignment_5._1
{
    public partial class Form1 : Form
    {
        private object txt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBox5.Text;
            dataGridView1.Rows[n].Cells[5].Value = textBox6.Text;
            List<Products> product = new List<Products>();


            Products p = new  Products();


            MessageBox.Show( $"NUMBER is ADDED { p.number}");
            MessageBox.Show($" DATE is ADDED {p.Date}");
            MessageBox.Show($" modiffied {p.modifier}");
            MessageBox.Show($"ITemnumber is ADDED{p.Itemname}");
           MessageBox.Show($"counted {p.count}");
           MessageBox.Show($" price is ADDED {p.price}");
           /* foreach(var item in product)
            {
             Products card  p = new Products card();
            card.number = item.number; 
                p.click t =(object d. eventages e)={
                    detailpage d = new detailpage
                        d.show()
                        }
                FlowDirection layoutcontrol addO()
            }
            
            */


        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lablemodify_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}