using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dame_un_sonrisa
{
    class Ropa
    {
        //variables

        protected string color;
        protected string marca;


        
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }


        //constructores
        public Ropa()
        {
            color = "";
            marca = "";

        }
        public Ropa(string color, string marca)
        {
            this.color = color;
            this.marca = marca;

        }

        public override string ToString()
        {
            return "Color" + color + "Marca" + marca;
        }

    }
}
