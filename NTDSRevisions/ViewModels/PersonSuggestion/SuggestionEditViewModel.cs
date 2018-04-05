using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AcsAptify;
using App.Infrastructure;
using App.Models.PersonSuggestion;
using AutoMapper;
using Data;
using DataRepository;

namespace App.ViewModels.PersonSuggestion
{
    public class SuggestionEditViewModel : BaseViewModel
    {
        private readonly IRepositoryChapter _repositoryChapter;
        private readonly IRepositoryVersion _repositoryVersion;
        private readonly IRepositoryField _repositoryField;
        private readonly IRepositoryProgram _repositoryProgram;
        private readonly IRepositoryPersonSuggestion _repositoryPersonSuggestion;
        private readonly IRepositoryAppendix _repositoryAppendix;
        private readonly IMappingEngine _mappingEngine;
        public int ID { get; set; }
        public string Clickbutton { get; set; }
        public string ActionName { get; set; }
        public string EditNewInstructions { get; set; }
        public int InternalStatusNewEntry { get; set; }
        public int InternalStatusNewEntryField { get; set; }
        public bool IsAppendix { get; set; }
        public int NtdsFieldTypeId { get; set; }
        public IEnumerable<SelectListItem> VersionsList { get; set; }
        public IEnumerable<SelectListItem> ChapterList { get; set; }
        public IEnumerable<SelectListItem> FieldList { get; set; }
        public PersonSuggestionModel PersonSuggestionModels { get; set; }
        public IList<ChapterModel> ChapterModels { get; set; }
        public IList<vwACSNtdsFieldType> AppendixList { get; set; }

        public SuggestionEditViewModel(IMappingEngine mappingEngine, IRepositoryVersion repositoryVersion, IRepositoryChapter repositoryChapter, IRepositoryField repositoryField, IRepositoryPersonSuggestion repositoryPersonSuggestion, IRepositoryProgram repositoryProgram, IRepositoryAppendix repositoryAppendix)
        {
            _mappingEngine = mappingEngine;
            _repositoryVersion = repositoryVersion;
            _repositoryChapter = repositoryChapter;
            _repositoryField = repositoryField;
            _repositoryProgram = repositoryProgram;
            _repositoryPersonSuggestion = repositoryPersonSuggestion;
            _repositoryAppendix = repositoryAppendix;
        }

        public override void Load()
        {
            base.Load();
            var record = _repositoryProgram.GetCurrentActive();
            //ChapterList = (from y in _repositoryChapter.GetAll() select new SelectListItem { Value = y.ID.ToString(), Text = y.ChapterName });
            //VersionsList = (from x in _repositoryVersion.getByAcceptsEdits() select new SelectListItem { Value = x.ID.ToString(), Text = x.Name });
            //FieldList = new List<SelectListItem>();
            AppendixList = _repositoryAppendix.GetAll();
            InternalStatusNewEntry = Constants.NtdsStatusType.InternalStatusNewEntry;
            InternalStatusNewEntryField = Constants.NtdsStatusType.InternalStatusNewEntryField;
            if (PersonSuggestionModels == null)
            {
                PersonSuggestionModels = _mappingEngine.Map<vwACSNtdsPersonSuggestions, PersonSuggestionModel>(_repositoryPersonSuggestion.GetById(ID).FirstOrDefault());
            }
            EditNewInstructions = record.EditSuggestion;
            ViewName = PersonSuggestionModels.IsAppendix == true ? MVC.PersonSuggestion.Views.SuggestionAppendixEdit : MVC.PersonSuggestion.Views.SuggestionEdit;
        }

        public void Save()
        {
            SaveResults = new List<SaveResults>();
            DataSaveClass dataSave = new DataSaveClass();
            PersonSuggestionUpdateModel personSuggestionModel =
                _mappingEngine.Map<PersonSuggestionModel, PersonSuggestionUpdateModel>(PersonSuggestionModels);
            dataSave.DataCollection.Add(personSuggestionModel);
            SaveResults = AptifyEntity.Save(dataSave);
            ViewName = MVC.PersonSuggestion.Views.SuggestionEdit;
        }

    }
}