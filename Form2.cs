using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Estudos_Forms.Pessoas;


namespace Estudos_Forms
{
    public partial class Form2 : Form
    {
        public ListBox ListBox1 => listBox1;
        public CheckedListBox CheckedListBox1 => checkedListBox1;

        public void Form2_Load(object sender, EventArgs e)
        {
            Funcoes funcoes = new Funcoes(this);
            funcoes.ListarTodas();
        }
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }
       

        public void button1_Click(object sender, EventArgs e)
        {

        }
        

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
