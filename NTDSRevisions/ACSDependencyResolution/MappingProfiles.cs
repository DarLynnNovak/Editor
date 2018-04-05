using App.Models.PersonSuggestion;
using AutoMapper;

namespace App.ACSDependencyResolution
{
    public class MappingProfiles : Profile
    {
        protected override void Configure()
        {
            CreateMap<Data.vwACSNtdsVersion, VersionModel>();
            CreateMap<Data.vwACSNtdsChapter, ChapterModel>();
            CreateMap<Data.vwACSNtdsPersonSuggestions, PersonSuggestionModel>();
            CreateMap<Data.vwACSNtdsField, FieldModel>();
            CreateMap<PersonSuggestionModel, PersonSuggestionUpdateModel>();
            CreateMap<Models.Home.UserInfoModel, Models.Home.UserInfoUpdateModel>();

        }
    }
}