using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{


    public class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }



        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar");
        }

        public virtual void Area()
        {
           
        }







    }




    class Criculo : Forma
    {


        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhou um circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine($"Area do circulo: {area}");
        }



    }


}
