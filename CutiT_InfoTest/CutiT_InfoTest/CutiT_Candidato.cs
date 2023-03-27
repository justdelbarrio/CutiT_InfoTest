using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutiT_InfoTest
{
   abstract public class CutiT_Candidato
    {
       private int cutiT_matricola;
       private string cutiT_nome;


       public int CutiT_matricola { get { return cutiT_matricola; } set { cutiT_matricola = value; } }
       public string CutiT_nome { get { return cutiT_nome; } set { cutiT_nome = value; } } 
   

       public CutiT_Candidato()
        {
            cutiT_matricola = 0;
            cutiT_nome = null;
        }

        public CutiT_Candidato(int matricola)
        {
            cutiT_matricola = matricola;
            cutiT_nome = null;
        }
        public CutiT_Candidato(string nome)
        {
            cutiT_matricola = 0;
            cutiT_nome = nome;
        }
        public CutiT_Candidato(int matricola, string nome)
        {
            cutiT_nome = nome;
            cutiT_matricola = matricola;
        }   

        public virtual bool isIdoneo()
        {
            return true;
        }

        public virtual int punteggio()
        {
            int a = 0;
            return a;
        }
    }
}
