using App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Web.Configuration;
using System.Web;
using App.Models.Home;
using App.Models.PersonSuggestion;
using Aptify.Framework.Messaging;
using AutoMapper;
using Data;
using DataRepository;

namespace App.ViewModels.Home
{
    public class IndexViewModel : BaseViewModel
    {
        private readonly IRepositoryProgram _repositoryProgram;
        private readonly IMappingEngine _mappingEngine;
        public string ActionName { get; set; }
        public string UserInstructions { get; set; }
        public string CurrentUserUrl { get; set; }
        public string NewUserUrl { get; set; }

        public IndexViewModel(IMappingEngine mappingEngine, IRepositoryProgram repositoryProgram)
        {
            _mappingEngine = mappingEngine;
            _repositoryProgram = repositoryProgram;
        }

        public override void Load()
        {
            base.Load();

            var record = _repositoryProgram.GetCurrentActive();
            const string homeindex = "/Home/Index";
            UserInstructions = record.LoginInstructions;
            CurrentUserUrl = WebConfigurationManager.AppSettings["SsoUrl"] + "?ReturnToPage=" + HttpContext.Current.Request.Url.AbsoluteUri + homeindex;
            NewUserUrl = WebConfigurationManager.AppSettings["SsoNewUserUrl"] + "?ReturnToPage=" + HttpContext.Current.Request.Url.AbsoluteUri + homeindex;
            ViewName = MVC.Home.Views.LandingPage;

        }
    }
}