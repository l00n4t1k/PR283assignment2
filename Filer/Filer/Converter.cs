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
            throw new NotImplementedException();
        }

        public void Expand(string uncompressedLevel)
        {
            throw new NotImplementedException();
        }
    }
}
