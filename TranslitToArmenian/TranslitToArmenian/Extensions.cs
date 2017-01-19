using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslitToArmenian
{
    public static class Extensions
    {
        public static string IsValidEmail(this string input)
        {
            StringBuilder temp = new StringBuilder();
            int length = input.Length;
            Dictionary<string, string> letters = new Dictionary<string, string>();

            letters["a"] = "ա";
            letters["b"] = "բ";
            letters["c"] = "ց";
            letters["d"] = "դ";
            letters["e"] = "ե";
            letters["f"] = "ֆ";
            letters["g"] = "գ";
            letters["h"] = "հ";
            letters["i"] = "ի";
            letters["j"] = "ջ";
            letters["k"] = "կ";
            letters["l"] = "լ";
            letters["m"] = "մ";
            letters["n"] = "ն";
            letters["o"] = "ո";
            letters["p"] = "պ";
            letters["q"] = "ք";
            letters["r"] = "ր";
            letters["s"] = "ս";
            letters["t"] = "տ";
            letters["u"] = "ու";
            letters["v"] = "վ";
            letters["w"] = "վ";
            letters["x"] = "խ";
            letters["y"] = "յ";
            letters["z"] = "զ";

            letters["ch"] = "չ";
            letters["sh"] = "շ";
            letters["dz"] = "ձ";
            letters["ts"] = "ց";
            letters[" o"] = " օ";
            letters[" ov "] = "ով";
            letters[" ovker "] = "ովքեր";
            letters[" vo"] = " ո";
            letters["gh"] = "ղ";
            letters["zh"] = "ժ";
            letters["@"] = "ը";
            letters[":)"] = "\u263B";

            for (int i = 0; i < length; i++)
            {
                if (letters.ContainsKey(input[i].ToString()))
                {
                    switch (input[i])
                    {
                        case 'c':
                            {
                               if (i + 1 < length && input[i + 1] == 'h')
                                   temp.Append('չ');
                            }
                            break;
                        case 's':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                    temp.Append('շ');
                            }
                            break;
                        case 'd':
                            {
                                if (i + 1 < length && input[i + 1] == 'z')
                                    temp.Append('ձ');
                            }
                            break;
                        case 't':
                            {
                                if (i + 1 < length && input[i + 1] == 's')
                                    temp.Append('v');
                            }
                            break;
                        case ' ':
                            {
                                if (i + 1 < length && input[i + 1] == 'o')
                                    if (i + 2 < length && input[i + 2] == 'v')
                                    {
                                        if (i + 5 < length && input[i + 2] == 'v')
                                    }
                            }
                            break;
                        case 'g':
                        case 'z':
                        case ':':
                            {



                            }
                            break;
                        default:
                            break;    
                    }

                }
                else
                    temp.Append(input[i]);


            }


            return temp.ToString();
        }

    }
}
