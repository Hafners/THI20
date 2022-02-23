using System;
using XrmDay.MainCall;
using XrmDay.Data;

namespace XrmDay
{
    class Program
    {
        static void Main(string[] args)
        {
            new main_Kain().execute();

            main_Gepper kunde_herrmann = new main_Gepper();
            kunde_herrmann.saveUserData();
            kunde_herrmann.ausgeben();

            new main_Heimbach().execute();
            new main_Erkelenz().execute();
            new main_schweizer().Execute();
        }
    }
}
