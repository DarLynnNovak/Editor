using App.Infrastructure;
using System;
using System.Collections.Generic;
using App.Models.PersonSuggestion;
using AutoMapper;
using Data;
using DataRepository;

namespace App.ViewModels.PersonSuggestion
{
    public class IndexViewModel : BaseViewModel
    {
        private readonly IRepositoryProgram _repositoryProgram;
        private readonly IRepositoryPersonSuggestion _repositoryPersonSuggestion;
        private readonly IMappingEngine _mappingEngine;
        public string ActionName { get; set; }
        public string UserInstructions { get; set; }
        public IList<VersionModel> VersionModels { get; set; }
        public IList<PersonSuggestionModel> PersonSuggestionModels { get; set; }
        
        public IndexViewModel(IMappingEngine mappingEngine, IRepositoryProgram repositoryProgram, IRepositoryPersonSuggestion repositoryPersonSuggestion)
        {
            _mappingEngine = mappingEngine;
            _repositoryProgram = repositoryProgram;
            _repositoryPersonSuggestion = repositoryPersonSuggestion;
        }

        public override void Load()
        {
            base.Load();
            var record = _repositoryProgram.GetCurrentActive();
            PersonSuggestionModels =
                _mappingEngine.Map<IList<vwACSNtdsPersonSuggestions>, IList<PersonSuggestionModel>>(
                    _repositoryPersonSuggestion.GetByPersonId(CurrentPersonId));


            if (record == null)
            {
                ViewName = MVC.PersonSuggestion.Views.NoPrograms;
                //throw new Exception("No active programs found");
            }
                UserInstructions = record.UserPageHeader;
                ViewName = MVC.PersonSuggestion.Views.Index;

        }
    }

}