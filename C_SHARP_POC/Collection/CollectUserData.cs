using System.Collections.Generic;
using C_SHARP_POC.Data;
using C_SHARP_POC.interfaces;

namespace C_SHARP_POC.Collection
{

    public class CollectUserData : iCollectUserData
    { 

        public List<dbUserData> UserDataRepo = new List<dbUserData>();


        public CollectUserData()
        {
            GetUserData();
        } 

        public void GetUserData()
        {
            // pretend data fetched from db
            UserDataToList();

           // Console.WriteLine(UserDataRepo[0].dbUserName);
           // Console.WriteLine(UserDataRepo[1].dbUserName);

           // return UserDataRepo;
        }


        private void UserDataToList()
        {
            // pretend data fetched from db
            // row one
            UserDataRepo.Add(new dbUserData
            {
                dbUserName = "UserOne",
                dbEmail    = "UserOne@gmail.com",
                dbPhoneNum = "4045555555",
                dbAddress  = "123 Fake st, Yukon OK, 73099"
            });

            // row two
            UserDataRepo.Add(new dbUserData
            {
                dbUserName = "UserTwo",
                dbEmail    = "UserTwo@gmail.com",
                dbPhoneNum = "4055555555",
                dbAddress  = "1234 Fake st, Yukon OK, 73099"
            });
        }

    }// CollectUserData -- 
}
