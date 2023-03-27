using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutiT_InfoTest
{
    public class CutiT_Lavoratore : CutiT_Candidato
    {
        private int cutiT_esperienze;

        public int CutiT_esperienze
        {
            get
            {
                return cutiT_esperienze;
            }
            set
            {
                if (value <= 5 && value >= 0)
                {
                    cutiT_esperienze = value;
                }
                else {
                    throw new Exception("Value exceed the maximum or is below the minimum consented");
                }

            }
        }

        public CutiT_Lavoratore()
        {
            cutiT_esperienze = 0;
        }

        public CutiT_Lavoratore(int esperienze)
        {
            CutiT_esperienze = esperienze;       
        }

        public override int punteggio()
        {
            int punti = cutiT_esperienze * 20;
            return punti;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            return false;
        }
    }
}
