using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace dame_un_sonrisa
{
    class Camisa : Ropa
    {
        string talla;


        public string Talla
        {
            get 
            {
                return talla;
            }
            set
            {
                talla = value;
            }
        }

        public Camisa(string color, string marca, string talla ) : base( color, marca)
        {

            this.talla = talla;
        }

        public Camisa()
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Talla" + talla;
        }


    }
}
