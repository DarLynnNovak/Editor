using AcsAptify;
using App.Infrastructure;
using App.Models.PersonSuggestion;

namespace App.ViewModels.PersonSuggestion
{
    public class SuggestionDeleteViewModel : BaseViewModel
    {
        public PersonSuggestionModel PersonSuggestionModels { get; set; }
        public int ID { get; set; }

        public override void Load()
        {
            base.Load();
        }

        public void Save()
        {
            var dataSave = new DataSaveClass(null);
            dataSave.DataCollection.Add(new PersonSuggestionModel{ID=ID});
            SaveResults = AptifyEntity.Delete(dataSave);
        }
 
    }
}