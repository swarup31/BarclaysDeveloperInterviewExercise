using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                //FileDetails fileDetails = new FileDetails();
                //if (args.Length > 0)
                //{
                //    #region Task1
                //    if (args[0] == "-v")
                //    {
                //        Console.WriteLine(fileDetails.Version(args[args.Length - 1]));
                //    }
                //    #endregion

                //    #region Task2
                //    if (args[0] == "-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
                //    {
                //        Console.WriteLine(fileDetails.Version(args[args.Length - 1]));
                //    }
                //    else if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")
                //    {
                //        Console.WriteLine(fileDetails.Size(args[args.Length - 1]));
                //    }
                //    #endregion

                //}


                IReadFileData fileData = new ReadFileData();
                fileData.ReadFile(args);

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
