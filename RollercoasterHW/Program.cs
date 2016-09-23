using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollercoasterHW
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string rollercoaster = "To be, or not to be: that is the question.\nWhether 'tis nobler in the mind to suffer.\nThe slings and arrows of outrageous fortune.\nOr to take arms against a sea of troubles.\nAnd by opposing end them, to die: to sleep.";

            char[] upAndDown = rollercoaster.ToCharArray();

            for (int i =0 ; i<upAndDown.Length; i +=2)
            {
                char up = upAndDown[i];
                
                if (char.IsLower(up))
                {
                    upAndDown[i] = char.ToUpper(up);
                }
                else if (upAndDown[i] == ' ')
                {
                    upAndDown[i] = ' ';
                }
                else if (upAndDown[i] == ',')
                {
                    upAndDown[i] = ',';
                }
                else if (upAndDown[i] == ':')
                {
                    upAndDown[i] = ':';
                }
                else
                {
                    upAndDown[i] = char.ToUpper(up);
                }

            }
            string results = new string(upAndDown);
            Console.WriteLine(results);


        }
    }
}