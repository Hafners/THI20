using System;
using System.Collections.Generic;
using System.Text;


namespace XrmDay.Data
{
	class ContactPerson_Gepper
	{
		public int Id { get; set; } = 0;

		public string Firstname { get; set; } = string.Empty;

		public string Lastname { get; set; } = string.Empty;

		//todo
		public int Date { get; set; } = 0;

		public void saveUserData()
        {
			Console.WriteLine("To-Do");
        }
	}
}