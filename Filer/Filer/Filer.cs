using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filer
{
    public class Filer : iFiler, iLoader, iSaver
    {

        protected iLoader Loader;
        protected iSaver Saver;
        protected iConverter Converter;

        public Filer(iLoader theLoader, iSaver theSaver, iConverter theConverter)
        {
            Loader = theLoader;
            Saver = theSaver;
            Converter = theConverter;
        }

        public string Load(string filename)
        {
            /*steps for loading...
             * 1. open file
             * 2. read file to variable
             * 3. uncompress level
             * 4. return uncompressed level
             * */
            throw new NotImplementedException();
        }

        public void Save(string filename, iFileable theFile)
        {
            /*steps for saving...
             * 1. take level string and compress
             * 2. open file
             * 3. write compressed level string to file
             * */
            throw new NotImplementedException();
        }
    }
}
