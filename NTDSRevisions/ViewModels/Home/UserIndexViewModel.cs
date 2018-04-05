using App.Infrastructure;
using System;
using System.Collections.Generic;
using App.Models.Home;
using App.Models.PersonSuggestion;
using AutoMapper;
using Data;
using DataRepository;

namespace App.ViewModels.Home
{
    public class UserIndexViewModel : BaseViewModel
    {
        private readonly IMappingEngine _mappingEngine;
        private readonly IRepositoryUserInfo _repositoryUserInfo;
      
        public UserIndexViewModel(IMappingEngine mappingEngine, IRepositoryUserInfo repositoryUserInfo)
        {
            _mappingEngine = mappingEngine;
            _repositoryUserInfo = repositoryUserInfo;
        }

        public override void Load()
        {
            base.Load();
            var NewUserrecord = _repositoryUserInfo.GetByPersonId(CurrentPersonId);
            if (NewUserrecord == null)
            {
                NewUser = true;
            }
            ViewName = MVC.Home.Views.LandingPage;
        }
    }

}