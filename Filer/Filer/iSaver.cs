using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filer
{
    public interface iSaver
    {
        void Save(string filename, iFileable callMeBackforDetails);
    }
}
