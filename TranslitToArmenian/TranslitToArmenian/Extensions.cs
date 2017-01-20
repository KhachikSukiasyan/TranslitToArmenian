using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslitToArmenian
{
    public static class Extensions
    {

        static Dictionary<string, string> letters = new Dictionary<string, string>();


        static Extensions()
        {
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
            letters["@"] = "ը";

            //letters["ch"] = "չ";
            //letters["sh"] = "շ";
            //letters["dz"] = "ձ";
            //letters["ts"] = "ծ";
            //letters["ov "] = "ով ";
            //letters["ovker "] = "ովքեր ";
            //letters["vo"] = "ո";
            //letters["gh"] = "ղ";
            //letters["zh"] = "ժ";
            //letters[":)"] = "\u263B";

        }

        public static string Translate(this string input)
        {
            StringBuilder temp = new StringBuilder();
            int length = input.Length;


            for (int i = 0; i < length; i++)
            {
                if (letters.ContainsKey(input[i].ToString()))
                {
                    switch (input[i])
                    {
                        case 'k':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                {
                                    temp.Append('խ');
                                    i++;
                                }
                                else
                                    temp.Append('կ');
                            }
                            break;
                        case 'c':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                {
                                    temp.Append('չ');
                                    i++;
                                }
                                else
                                    temp.Append('ց');
                            }
                            break;
                        case 's':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                {
                                    temp.Append('շ');
                                    i++;
                                }
                                else
                                    temp.Append('ս');
                            }
                            break;
                        case 'd':
                            {
                                if (i + 1 < length && input[i + 1] == 'z')
                                {
                                    temp.Append('ձ');
                                    i++;
                                }
                                else
                                    temp.Append('դ');
                            }
                            break;
                        case 't':
                            {
                                if (i + 1 < length && input[i + 1] == 's')
                                {
                                    temp.Append('ծ');
                                    i++;
                                }
                                else
                                    temp.Append('տ');
                            }
                            break;
                        case 'o':
                            {
                                if (i + 2 < length && input[i + 1] == 'v' && input[i + 2] == ' ')
                                {
                                    temp.Append("ով ");
                                    i += 2;
                                }
                                else
                                    if (i + 5 < length && input[i + 1] == 'v' && input[i + 2] == 'k'
                                    && input[i + 3] == 'e' && input[i + 2] == 'r' && input[i + 2] == ' ')
                                    {
                                        temp.Append("ովքեր ");
                                        i += 5;
                                    }
                                    else
                                    temp.Append('ո');

                            }
                            break;

                        case 'v':
                            {
                                if (i + 1 < length && input[i + 1] == 'o')
                                {
                                    temp.Append('ո');
                                    i++;
                                }
                                else
                                    temp.Append('վ');
                            }
                            break;
                        case 'g':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                {
                                    temp.Append('ղ');
                                    i++;
                                }
                                else
                                    temp.Append('գ');
                            }
                            break;
                        case 'z':
                            {
                                if (i + 1 < length && input[i + 1] == 'h')
                                {
                                    temp.Append('ժ');
                                    i++;
                                }
                                else
                                    temp.Append('զ');
                            }
                            break;
                        case ':':
                            {
                                if (i + 1 < length && input[i + 1] == ')')
                                {
                                    temp.Append("\u263B");
                                    i++;
                                }
                                else
                                    temp.Append(':');
                            }
                            break;
                        default:
                            temp.Append(letters[input[i].ToString()]);
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
