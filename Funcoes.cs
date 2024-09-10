using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudos_Forms
{
    public class Funcoes
    {
        private Form2 _form2;
        
        
        public Funcoes(Form2 form2)
        {
            _form2 = form2;
        }

        public void ListarTodas()
        {
            Pessoas pessoas = new Pessoas();
           
            _form2.listBox1.Items.Clear();

            foreach (var pessoa in pessoas.pessoas)
            {
                if (!string.IsNullOrEmpty(pessoa.Nome))
                {
                    string item = $"ID {pessoa.ID}: Nome: {pessoa.Nome}";
                    form2.listBox1.Items.Add(item);
                    form2.checkedListBox1.Items.Add(item.ToUpper());
                }
            }
        }
    }
}
