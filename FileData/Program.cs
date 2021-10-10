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
