using System.Collections.Generic;
using C_SHARP_POC.Data;
using C_SHARP_POC.interfaces;

namespace C_SHARP_POC.Collection
{

    public class CollectClientData : iCollectClientData
    {

        public List<dbClientData> ClientDataRepo = new List<dbClientData>();


        public CollectClientData()
        {
            GetClientData();
        }

        public void GetClientData()
        {
            // pretend data fetched from db
            ClientDataToList();

            // Console.WriteLine(ClientDataRepo[0].dbClientName);
            // Console.WriteLine(ClientDataRepo[1].dbClientName);

            // return UserDataRepo;
        }


        private void ClientDataToList()
        {
            // pretend data fetched from db
            // row one
            ClientDataRepo.Add(new dbClientData
            {
                dbClientName     = "ClientOne",
                dbClientEmail    = "ClientOne@ClientOne.com",
                dbClientPhoneNum = "4045555555",
                dbClientAddress  = "123 Fake st, Yukon OK, 73099"
            });

            // row two
            ClientDataRepo.Add(new dbClientData
            {
                dbClientName     = "ClientTwo",
                dbClientEmail    = "ClientTwo@ClientTwo.com",
                dbClientPhoneNum = "4055555555",
                dbClientAddress  = "1234 Fake st, Yukon OK, 73099"
            });
        }

    }// CollectClientData -- 
}
