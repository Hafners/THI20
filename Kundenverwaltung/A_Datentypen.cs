using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Kundenverwaltung
{
    internal class A_Datentypen
    {
        // Zeichenkette
        string userStringInput = string.Empty;

        // Integer
        int userIntInput = 0;
        int? userIntNullInput = null;

        // decimal 
        decimal userDecimalInput = 0;
        decimal? userDecimalNullInput = null;

        // DateTime 
        DateTime userDateInput = DateTime.MinValue;
        DateTime? userDateNullInput = null;

        // Ja/Nein
        bool userBoolInput = false;
        bool? userBoolNullInput = null;

        // Array
        string[] userStringArray = new string[1];

        // List
        List<string> userStringList = new List<string>();
        IEnumerable<string> userStringEnumerable = new List<string>();
        ObservableCollection<string> userStringUiList = new ObservableCollection<string>();

    }
    
}
