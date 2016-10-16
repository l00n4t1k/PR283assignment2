using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filer
{
    public class Saver : iSaver
    {
        private Filer MyFiler;

        public Saver(Filer theFiler)
        {
            MyFiler = theFiler;
        }
        public void Save(string filename/*, iFileable callMeBackforDetails*/)
        {
            StringBuilder sb = new StringBuilder();

            foreach(string level in MyFiler.MyLevels)
                sb.Append(level);

            using (StreamWriter outfile = new StreamWriter(filename))
            {
                outfile.Write(sb.ToString());
            }
        }
    }
}
