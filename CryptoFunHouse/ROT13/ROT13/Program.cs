using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROT13
{

    class Program
    {
        static void Main()
        {
            //string value = "There was a cute dog in 2008. (Zamborine)";
            string value = "Url gurer, pbqr crrcre! Lbh zhfg or n erny areq! Gb fubj bhe fhccbeg," 
                        + "hfr pbqr VFNJLBHEFBHEPR ng purpxbhg sbe 10% bss lbhe arkg beqre. Qba'g gryy nalbar,"
                        + "jr jnag gb fnir guvf fcrpvny pbqr sbe fcrpvny crbcyr jub ivrj fbhepr :) Unir n avpr ivfvg!";
            //Console.WriteLine(value);

            value = Rot13.Transform(value);
            Console.WriteLine(value);

            //value = Rot13.Transform(value);
            //Console.WriteLine(value);
            Console.Read();
        }

        static class Rot13
        {
            /// <summary>
            /// Performs the ROT13 character rotation.
            /// </summary>
            public static string Transform(string value)
            {
                char[] array = value.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'a' && number <= 'z')
                    {
                        if (number > 'm')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    else if (number >= 'A' && number <= 'Z')
                    {
                        if (number > 'M')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    array[i] = (char)number;
                }
                return new string(array);
            }
        }
    }
}