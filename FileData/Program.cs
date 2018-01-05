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
            ThirdPartyToolsClient toolClient = new ThirdPartyToolsClient();
            ClientResponse response = toolClient.GetFileProperties(args);


            if (response.Success)
            {
                Console.WriteLine(string.Format(" Result of operation is '{0}' ", response.Message));
            }
            else
            {
                Console.WriteLine(string.Format(" Operation failed with message: '{0}' ", response.Message));
            }
        }
    }
}
