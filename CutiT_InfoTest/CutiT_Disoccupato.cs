using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutiT_InfoTest
{
    public class CutiT_Disoccupato : CutiT_Candidato
    {
        private int cutiT_voto;
        private bool cutiT_Lode;

        public int CutiT_voto
        { 
            get { 
                return cutiT_voto; 
            }

            set { 
                if (value <= 110)
                { 
                    cutiT_voto = value;
                }      
                else if (value < 0)
                {
                    throw new Exception("The grade cannot be under 0");
                }
                else if(value>110){ 
                    throw new Exception("The selected grade exceeds the maximum allowed"); 
                } 
            }
        }
        
        public bool CutiT_Lode
        {
            get
            {
                return cutiT_Lode;
            }
            set
            {
                if (cutiT_voto == 110)
                {
                    cutiT_Lode = true;
                }
                else
                {
                    cutiT_Lode = false;
                }
            }
        }

        public CutiT_Disoccupato()
        {
            cutiT_Lode = false;
            cutiT_voto = 0;
        }

        public CutiT_Disoccupato(int voto, bool Lode)
        {
            cutiT_voto = voto;
            cutiT_Lode = Lode;           
        }

        public override int punteggio()
        {
            if (cutiT_voto == 110)
            {
                cutiT_Lode = true;

                int voto = (100 * cutiT_voto) / 110;
                voto+=5;
                return voto;
            }
            else
            {
                int voto = (100 * cutiT_voto) / 110;
                return voto;
            }
        }

        public override bool isIdoneo()
        {
            
            if (punteggio() >= 72)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return "Voto: " + CutiT_voto + " Lode: " + CutiT_Lode + " Nome: " + CutiT_nome + " Matricola: " + CutiT_matricola; 
        }
        public bool Equals(CutiT_Disoccupato other)
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            if (!base.Equals(other))
                return false;
            else
            {
                if (this.CutiT_voto != other.CutiT_voto)
                    return false;
                if (this.CutiT_Lode != other.CutiT_Lode)
                    return false;
            }

            return true;
        }
        public int CompareTo(CutiT_Disoccupato a)
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
       
    }
}

