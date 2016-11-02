using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //Check whether the file exists. If not fire an exception
            if(!fi.Exists)
                throw new FileNotFoundException("csv file does not exists under the give path!");

            List<User> users = new List<User>();
            var allLines = File.ReadAllLines(_filePath);

            //Enumerate through all lines. Omit the first line as its the header
            for (var i = 1; i < allLines.Length; i++)
            {
                //Split the line by delimiter
                var parts = allLines[i].Split(new char[] {','});
                if(parts.Length < 4)
                    continue;

                //Extract addrss data
                var addressParts = Regex.Split(parts[2], "([0-9]+)");

                //Create and add user object
                users.Add(new User
                {
                    FirstName = parts[0],
                    LastName = parts[1],
                    Address = new Address
                    {
                        Number = Convert.ToInt32(addressParts[1]),
                        Street = addressParts[2]
                    },
                    PhoneNumber = Convert.ToInt64(parts[3])
                });
            }

            return users;
        }

        #endregion Interface Methods
    }
}
