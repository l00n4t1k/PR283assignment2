using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filer
{
    public class Converter : iConverter
    {

        private string MyCompressed;

        public string Compressed
        {
            get { return MyCompressed; }
            set { MyCompressed = value; }
        }

        private string MyExpanded;

        public string Expanded
        {
            get { return MyExpanded; }
            set { MyExpanded = value; }
        }

        public void Compress(string uncompressedLevel)
        {
            string res = "";
            int c = 1;
            int i = 0;
            char[] explode = uncompressedLevel.ToCharArray();
            do
            {
                i++;
                string t = explode[i - 1].ToString();
                try
                {
                    if (explode[i].ToString() == t)
                    {
                        c++;
                    }
                    else
                    {
                        if ( c != 1)
                        {
                            res += t + c;
                        }
                        else
                        {
                            res += t;
                        }
                        c = 1;
                    }
                } 
                catch
                {
                    if (c != 1)
                    {
                        res += t + c;
                    }
                    else
                    {
                        res += t;
                    }
                }
                
            } while (i < explode.Length);
            Compressed = res;
        }

        public void Expand(string compressedLevel)
        {
            int c = 0;
            bool x = true;
            char prev = compressedLevel[0];
            string res = "";
            foreach (char i in compressedLevel)
            {
                if (Int32.TryParse(i.ToString(), out c))
                {
                    res += new string(prev, c);
                    x = false;
                }
                else if (i != prev && !x)
                {
                    res += i;
                    x = true;
                }
                prev = i;
            }
            Expanded = res;
        }
    }
}
