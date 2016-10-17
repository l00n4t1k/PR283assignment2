using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanFiler
{
    interface iFiler
    {
        void Save(string filename/*, iFileable theFile*/);
        string Load(string filename);
    }
}
