namespace App.Models.PersonSuggestion
{
    public class ChapterModel
    {
        public int ID { get; set; }
        public int ChapterNumber { get; set; }
        public string ChapterName { get; set; }
        public string Description { get; set; }
        public int NtdsVersionId { get; set; }
        public string ChapterNumberName { get; set; }
        public int IsAppendix { get; set; }
    }
}