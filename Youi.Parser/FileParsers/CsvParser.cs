using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youi.Parser.Interfaces;
using Youi.Parser.Models;

namespace Youi.Parser.FileParsers
{
    public class CsvParser: IFileParser<User>
    {
        #region Members

        private string _filePath;

        #endregion Members

        #region Constructors
        public CsvParser(string filePath)
        {
            _filePath = filePath;
        }

        #endregion Constructors

        #region Interface Methods

        public ICollection<User> ParseFile()
        {
            FileInfo fi = new FileInfo(_filePath);

            if(!fi.Exists)
                throw new FileNotFoundException("csv file does not exists under the give path!");

            return null;
        }

        #endregion Interface Methods
    }
}
