using AcsAptify;
using App.Infrastructure;
using System;
using System.Collections.Generic;
using App.Models.Home;
using AutoMapper;
using Data;
using DataRepository;
using System.Web.Mvc;
using System.Linq;


namespace App.ViewModels.Home
{
    public class UserInfoEditViewModel : BaseViewModel
    {
        private readonly IRepositoryProgram _repositoryProgram;
        private readonly IMappingEngine _mappingEngine;
        public UserInfoModel UserInfoData { get; set; }
        public SelectList UserTypeChoices { get; set; }

        public UserInfoEditViewModel(IMappingEngine mappingEngine, IRepositoryProgram repositoryProgram)
        {
            _mappingEngine = mappingEngine;
            _repositoryProgram = repositoryProgram;
        }

        public override void Load()
        {
            base.Load();
            var record = _repositoryProgram.GetCurrentActive();

            if (UserInfoData == null)
            {
                UserInfoData = new UserInfoModel { ID = -1, PersonId = CurrentPersonId };
            }

            if (record == null)
            {
                ViewName = MVC.Home.Views.NoPrograms;
                //throw new Exception("No active programs found");
            }
            else { 
                UserTypeChoices = GetUserTypesChoices();
                InstructionsText = record.InterimLoginPage;
                ViewName = MVC.Home.Views.UserInfoEdit;
            }

        }

        public void Save()
        {
            SaveResults = new List<SaveResults>();
            var lData = new DataSaveClass();
            UserInfoUpdateModel lModel = _mappingEngine.Map<UserInfoModel, UserInfoUpdateModel>(UserInfoData);
            lData.DataCollection.Add(lModel);
            SaveResults = AptifyEntity.Save(lData);
        }

        private static SelectList GetUserTypesChoices()
        {
            IEnumerable<SelectListItem> lResults = null;
            Dictionary<string, string> lDict = new Dictionary<string, string>();
            lDict.Add("NTDB", "NTDB");
            lDict.Add("TQIP", "TQIP");
            lDict.Add("Researcher", "Researcher");
            lDict.Add("Other", "Other");
            lResults = new SelectList(lDict.AsEnumerable(), "key", "value");
            return new SelectList(lResults, "Value", "Text");
        }
    }
}
