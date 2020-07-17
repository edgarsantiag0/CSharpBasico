using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
   
    public enum Size : int
    {
        Small, // 0
        Normal, //1
        Large  //2
    }

    enum Size2 : int
    {
        Small = 1,  // 1
        Normal,     //2
        Large = 5  //5
    }

    enum Size3 : int
    {
        Small = 5,  // 5
        Normal,     //6
        Large = 7  //7
    }


    public class PlayEnum
    {

        public void Metodo(Size size)
        {
            if(size == Size.Large)
            {
                Console.WriteLine("es Large");
            }

            if (size == Size.Normal)
            {
                Console.WriteLine("es Normal");
            }

        }

    }


}

      

