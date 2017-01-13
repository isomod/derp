using System;
using System.Collections.Generic;
using C_SHARP_POC.Data;

namespace C_SHARP_POC.Submit
{
    public class SubmitDataForBilling
    {
        public SubmitDataForBilling(List<dbUserData> pUserData, List<dbClientData> pClientData)
        {
            // lazy at this point
            // loop for data
            Console.WriteLine(pUserData[0].dbUserName);
            Console.WriteLine(pUserData[1].dbUserName);
            Console.WriteLine(pClientData[0].dbClientName);
            Console.WriteLine(pClientData[1].dbClientName);
            // run conditions on data etc etc
            Console.WriteLine("");
        }


    }// SubmitDataForBilling
}
