using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutiT_InfoTest
{
    public partial class Form1 : Form
    {
        List<CutiT_Candidato> Lista;
        public Form1()
        {
            InitializeComponent();
            Lista = new List<CutiT_Candidato>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        public void Aggiunta(CutiT_Candidato a)
        {
            Lista.Add(a);
        }

        public string[] Visualizza(List<CutiT_Candidato> a)
        {
            string[] s = new string[999];
            int f = 0;

            foreach (CutiT_Candidato k in Lista)
            {
                s[f] = k.ToString();
                f++;
            }

            return s;
        }

        public void Modifica(string nome, int matricola)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].CutiT_matricola == matricola)
                {
                    Lista[i].CutiT_nome = nome;
                }
            }
        }

        public void Elimina(int matricola)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].CutiT_matricola == matricola)
                {
                    Lista[i] = null;
                }
            }
        }

        public void VisualizzaCandidati()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].isIdoneo() == true)
                {
                    listView1.Items.Add(Lista[i].ToString());
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
