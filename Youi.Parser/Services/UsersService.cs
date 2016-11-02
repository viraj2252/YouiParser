using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youi.Parser.Interfaces;
using Youi.Parser.Models;

namespace Youi.Parser.Services
{
    public class UsersService : IUsersService
    {
        private IFileParser<User> _fileParser;

        public UsersService(IFileParser<User> parser)
        {
            _fileParser = parser;
        }
        public void GenerateUserList(string outputFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
