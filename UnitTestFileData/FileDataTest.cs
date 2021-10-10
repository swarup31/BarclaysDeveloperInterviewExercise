using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFileData
{
    [TestClass]
    public class FileDataTest
    {
        IReadFileData fileData;

        public FileDataTest()
        {
            fileData = new ReadFileData();
        }

        [TestMethod]
        public void FileDataTestMethodforV1()
        {
            fileData.ReadFile(new string[] { "-v", "C:/test.txt" });
        }


        [TestMethod]
        public void FileDataTestMethodforV2()
        {
            fileData.ReadFile(new string[] { "--v", "C:/test.txt" });
        }

        [TestMethod]
        public void FileDataTestMethodforV3()
        {
            fileData.ReadFile(new string[] { "/v", "C:/test.txt" });
        }
        [TestMethod]
        public void FileDataTestMethodforV4()
        {
            fileData.ReadFile(new string[] { "--version", "C:/test.txt" });
        }

        [TestMethod]
        public void FileDataTestMethodfors1()
        {
            fileData.ReadFile(new string[] { "-s", "C:/test.txt" });
        }


        [TestMethod]
        public void FileDataTestMethodfors2()
        {
            fileData.ReadFile(new string[] { "--s", "C:/test.txt" });
        }

        [TestMethod]
        public void FileDataTestMethodfors3()
        {
            fileData.ReadFile(new string[] { "/s", "C:/test.txt" });
        }
        [TestMethod]
        public void FileDataTestMethodfors4()
        {
            fileData.ReadFile(new string[] { "--size", "C:/test.txt" });
        }
    }
}
