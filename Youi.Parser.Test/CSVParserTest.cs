using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Youi.Parser.FileParsers;
using Youi.Parser.Interfaces;
using Youi.Parser.Models;

namespace Youi.Parser.Test
{
    [TestClass]
    public class CSVParserTest
    {
        private IFileParser<User> _csvParser;
        private string _wrongFilePath = @"c:\wrong.csv";
        private string _correctTempPath = @"test_files\data.csv";

        [TestInitialize]
        public void TestSetup()
        {
           
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void wrong_file_path_should_fire_exception()
        {
            _csvParser = new CsvParser(_wrongFilePath);
            _csvParser.ParseFile();
        }
    }
}
