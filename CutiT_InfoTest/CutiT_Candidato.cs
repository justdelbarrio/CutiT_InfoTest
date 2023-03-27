using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutiT_InfoTest
{
   abstract public class CutiT_Candidato
    { 
        // TASK 1
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
        
        public virtual string ToString()
        {
            return "Nome: " + CutiT_nome + " Matricola: " + CutiT_matricola;
        }

        public bool Equals(CutiT_Candidato other)
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            if (!base.Equals(other))
                return false;
            else
            {
                if (this.CutiT_nome != other.CutiT_nome)
                    return false;
                if (this.CutiT_matricola != other.CutiT_matricola)
                    return false;
            }

            return true;
        }
        public int CompareTo(CutiT_Candidato a)
        {
            if (a.punteggio() > this.punteggio())
            {
                return 1;
            }
            else if (a.punteggio() == this.punteggio())
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public virtual int HashCode()
        {
            return (CutiT_matricola, CutiT_nome).GetHashCode();
        }


    }
}
