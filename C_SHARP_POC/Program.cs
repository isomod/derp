using System;
using C_SHARP_POC.Collection;
using C_SHARP_POC.Submit;

namespace C_SHARP_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwX = 0;
            Type SubmitBilling = typeof(SubmitDataForBilling);
            string[] pCollects = { "C_SHARP_PRACTICE.Collection.CollectUserData", "C_SHARP_PRACTICE.Collection.CollectClientData" };

            CollectUserData UserData = new CollectUserData();
            CollectClientData ClientData = new CollectClientData();


            // .. or you could just instantiate the class and pass the params to the constructor .. why over complicate
            foreach (string collect in pCollects)
            {
                Object obj = Activator.CreateInstance(SubmitBilling, UserData.UserDataRepo, ClientData.ClientDataRepo);
                dwX++;
            }
            

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }// Main
    }
}
