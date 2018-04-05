using System;

namespace App.Models.PersonSuggestion
{
    public class VersionModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Year { get; set; }
        public string Revision { get; set; }
        public bool AcceptsEdits { get; set; }

    }
}