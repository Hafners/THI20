using XrmDay.MainCall;
using System;
using XrmDay.Data;

namespace XrmDay
{
    class Program
    {
        static void Main(string[] args)
        {
            
            new main_Kain().execute(); 
            //TEST VON GEPPER
            Customer_Gepper kunde_herrmann = new Customer_Gepper();
            kunde_herrmann.saveUserData();
            kunde_herrmann.ausgeben();
            //ENDE VON GEPPER
            new main_Heimbach().execute();
            new main_Erkelenz().execute();
            
            
            new Main_Verachter().execute();
            
        }
    }
}
