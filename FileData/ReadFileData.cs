using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class ReadFileData : IReadFileData
    {
        public ReadFileData()
        {

        }
        public void ReadFile(string[] arguments)
        {
            string result ;
            try
            {
                result = "";
                FileDetails fileDetails = new FileDetails();
                if (arguments.Length > 0)
                {
                    #region Task1
                    if (arguments[0] == "-v")
                    {
                        result= fileDetails.Version(arguments[arguments.Length - 1]);
                    }
                    #endregion

                    #region Task2
                    if (arguments[0] == "-v" || arguments[0] == "--v" || arguments[0] == "/v" || arguments[0] == "--version")
                    {
                        result= fileDetails.Version(arguments[arguments.Length - 1]);
                    }
                    else if (arguments[0] == "-s" || arguments[0] == "--s" || arguments[0] == "/s" || arguments[0] == "--size")
                    {
                        result= fileDetails.Size(arguments[arguments.Length - 1]).ToString();
                    }
                    #endregion
                }
                Console.WriteLine(result);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
            }

        }
    }
}
