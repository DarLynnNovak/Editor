namespace App.Models.PersonSuggestion
{
    public class FieldModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NtdsChapterId { get; set; }
        public string NtdsChapterId_Name { get; set; }
        public int NtdsChapterId_VersionId { get; set; }
    }
}