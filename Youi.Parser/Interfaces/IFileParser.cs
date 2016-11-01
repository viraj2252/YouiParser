using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youi.Parser.Models;

namespace Youi.Parser.Interfaces
{
    public interface IFileParser<T>
    {
        ICollection<T> ParseFile();
    }
}
