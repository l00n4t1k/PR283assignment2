using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filer
{
    public class Filer : iFiler
    {

        protected iLoader MyLoader;
        protected iSaver MySaver;
        protected iConverter MyConverter;

        public Filer()
        {
            MyLoader = new Loader(this);
            MySaver = new Saver(this);
            MyConverter = new Converter();
        }

        private int curLevelIndex;

        public int myCurLevelIndex
        {
            get { return curLevelIndex; }
            set { curLevelIndex = value; }
        }

        private string filepath;

        public string MyFilePath
        {
            get { return filepath; }
            set { filepath = value; }
        }

        private string[] allLevels;

        public string[] MyLevels
        {
            get { return allLevels; }
            set { allLevels = value; }
        }

        private bool HasLoaded;

        public bool MyHasLoaded
        {
            get { return HasLoaded; }
            set { HasLoaded = value; }
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

        public void Save(string filename/*, iFileable theFile*/)
        {
            /*steps for saving...
             * 1. take level string and compress
             * 2. open file
             * 3. write compressed level string to file
             * */
            MySaver.Save(filename);
        }
    }
}
