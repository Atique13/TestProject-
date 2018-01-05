using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ThirdPartyTools;

namespace FileData
{
    public class ThirdPartyToolsClient : IThirdPartyToolsClient
    {
        static string[] OperationVersionArguments= { "-v", "--v", "/v", "--version" };
        static string[] OperationSizeArguments = { "-s", "--s", "/s", "--size" };

        public ClientResponse GetFileProperties(string[] args)
        {


            ClientResponse clientResposne = new ClientResponse();
            string operation = "", filePath ="";
            if (args.Length < 2)
            {
                clientResposne.Message = "Insufficient number of arguments provided";
                return clientResposne;
            }

            operation = args[0];
            filePath = args[1];

            if (string.IsNullOrEmpty(filePath))
            {
                clientResposne.Message = "File path is null!!";
                return clientResposne;
            }
            
            if (OperationVersionArguments.Any(operation.ToLower().Contains))
            {
                clientResposne = GetFileVersion(filePath);
            }
            else if (OperationSizeArguments.Any(operation.ToLower().Contains))
            {

                clientResposne = GetFileSize(filePath);
                
            }
            else
            {
                clientResposne.Message = "Unknown arguments provided!!";
                return clientResposne;
            }

            return clientResposne;
        }
        
        private ClientResponse GetFileSize(string FilePath)
        {
            ClientResponse clientResposne = new ClientResponse();
            FileDetails fileDetails = new FileDetails();
            try
            {
                clientResposne.FileSize = fileDetails.Size(FilePath);
                clientResposne.Success = true;
                clientResposne.Message = clientResposne.FileSize.ToString() + " bytes";
            }

            catch
            {
                //for error handling
            }
            return clientResposne;
        }

        private ClientResponse GetFileVersion(string FilePath)
        {
            ClientResponse clientResposne = new ClientResponse();
            FileDetails fileDetails = new FileDetails();
            try
            {
                clientResposne.FileVersion = fileDetails.Version(FilePath);
                clientResposne.Success = true;
                clientResposne.Message = "version:" +  clientResposne.FileVersion ;
            }

            catch
            {
                //for error handling
            }
            return clientResposne;
        }
    }
}
