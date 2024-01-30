using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNew_textBox.Text = "Add a new task";
            addNew_textBox.ForeColor = Color.LightGray;
        }

        private void addNew_textBox_Enter(object sender, EventArgs e)
        {
            if (addNew_textBox.Text == "Add a new task")
            {
                addNew_textBox.Text = "";
                addNew_textBox.ForeColor = Color.Black;
            }
        }

        private void addNew_textBox_Leave(object sender, EventArgs e)
        {
            if (addNew_textBox.Text == "")
            {
                addNew_textBox.Text = "Add a new task";
                addNew_textBox.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox box;
            box = new CheckBox();
            box.Text = addNew_textBox.Text;
            box.AutoSize = true;
            box.Location = new Point(30, 280);
            box.ForeColor = Color.Black;
            box.Font = new Font(box.Font.FontFamily, 12);

            this.Controls.Add(box);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.DarkGray;
                checkBox1.Font = new Font(checkBox1.Font, FontStyle.Strikeout);
            } else
            {
                checkBox1.ForeColor = Color.Black;
                checkBox1.Font = new Font(checkBox1.Font, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.ForeColor = Color.DarkGray;
                checkBox2.Font = new Font(checkBox2.Font, FontStyle.Strikeout);
            }
            else
            {
                checkBox2.ForeColor = Color.Black;
                checkBox2.Font = new Font(checkBox2.Font, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.ForeColor = Color.DarkGray;
                checkBox3.Font = new Font(checkBox3.Font, FontStyle.Strikeout);
            }
            else
            {
                checkBox3.ForeColor = Color.Black;
                checkBox3.Font = new Font(checkBox3.Font, FontStyle.Regular);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.ForeColor = Color.DarkGray;
                checkBox4.Font = new Font(checkBox4.Font, FontStyle.Strikeout);
            }
            else
            {
                checkBox4.ForeColor = Color.Black;
                checkBox4.Font = new Font(checkBox4.Font, FontStyle.Regular);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.ForeColor = Color.DarkGray;
                checkBox5.Font = new Font(checkBox5.Font, FontStyle.Strikeout);
            }
            else
            {
                checkBox5.ForeColor = Color.Black;
                checkBox5.Font = new Font(checkBox5.Font, FontStyle.Regular);
            }
        }
    }
}
