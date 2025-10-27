using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Wrappers;
using TitaniumAS.Opc.Client.Interop.Da;

namespace OPCDATest2
{
    class ClsOPCDA
    {
        private OpcDaServer _server;

        public OpcDaServer Server { get => _server; set => _server = value; }

        public ClsOPCDA()
        {

        }

        public void TestInitialize()
        {
            //_server = new OpcDaServer(UrlBuilder.Build("Matrikon.OPC.Simulation.1"));
            _server = new OpcDaServer("Matrikon.OPC.Simulation.1", "192.168.117.247");
            _server.Connect();
        }

        public void TestCleanup()
        {
            _server.Dispose();
        }

        public void Test_Connect_Disconnect()
        {
            var serv = new OpcDaServer(UrlBuilder.Build("Matrikon.OPC.Simulation.1"));
            serv.Connect();
            if( !serv.IsConnected)
                serv.Disconnect();
            System.Threading.Thread.Sleep(100);
            serv.Connect();
            if (!serv.IsConnected)
                serv.Disconnect();

        }

        public string Test_GetStatus()
        {
            OpcDaServerStatus status = _server.GetStatus();
            if (status.ServerState == OpcDaServerState.Running)
                return "running";
            else if (status.ServerState == OpcDaServerState.Failed)
                return "failed";
            else
                return null;
        }

        public void Test_AddressSpaceBrowser()
        {
            _server.As<OpcBrowseServerAddressSpace>();
        }

        public void Test_Browser()
        {
            _server.As<OpcBrowse>();
        }
    }
}
