using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ThirdPartyTools;
using FileData;

namespace UnitTestFileData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssertFileSize1()
        {
            string[] operationArguments = { "-s", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }
        [TestMethod]
        public void AssertFileSize2()
        {
            string[] operationArguments = { "--s", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileSize3()
        {
            string[] operationArguments = { "/s", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileSize4()
        {
            string[] operationArguments = { "-size", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileSizeFail1()
        {
            string[] operationArguments = { "", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(false, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileSizeFail2()
        {
            string[] operationArguments = { " ", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(false, cresponse.Success);
        }


        [TestMethod]
        public void AssertFileVersion1()
        {
            string[] operationArguments = { "-v", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileVersion2()
        {
            string[] operationArguments = { "--v", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileVersion3()
        {
            string[] operationArguments = { "/v", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileVersion()
        {
            string[] operationArguments = { "-version", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(true, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileVersionFail()
        {
            string[] operationArguments = { "", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(false, cresponse.Success);
        }

        [TestMethod]
        public void AssertFileVersionFail2()
        {
            string[] operationArguments = { " ", "c:\test.txt" };
            IThirdPartyToolsClient client = new ThirdPartyToolsClient();
            ClientResponse cresponse = client.GetFileProperties(operationArguments);
            Assert.AreEqual(false, cresponse.Success);
        }
    }
}
