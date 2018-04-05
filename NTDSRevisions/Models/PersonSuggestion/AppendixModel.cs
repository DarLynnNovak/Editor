using System.Collections.Generic;
using Data;

namespace App.Models.PersonSuggestion
{
    public class AppendixModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        IList<vwACSNtdsFieldType> AppendixList { get; set; } 
    }
}