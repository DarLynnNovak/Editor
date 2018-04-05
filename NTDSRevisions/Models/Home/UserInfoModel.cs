using System;
using System.Collections.Generic;
using AcsAptify;
using FluentValidation;

namespace App.Models.Home
{
    public class UserInfoUpdateModel : IAptifyEntity
    {
        public int ID { get; set; }
        public int PersonId { get; set; }
        public string UserType { get; set; }
        public string InstitutionName { get; set; }
        public Nullable<decimal> NTDBId { get; set; }
        public string EntityName
        {
            get { return "ACSNtdsUserInfo"; }
        }

        public IList<IAptifySubType> SubTypes
        {
            get
            {
                return null;
            }
            set
            {

            }
        }

        public int EntityID()
        {
            return ID;
        }
    }

    public class UserInfoModel : UserInfoUpdateModel
    {
        public string PersonId_ACSMailName { get; set; }
    }
    
    public class UserInfoModelValidator : FluentValidation.AbstractValidator<UserInfoModel>
    {
        public UserInfoModelValidator()
        {
            RuleFor(m => m.UserType).NotEmpty().WithMessage("Required");
            RuleFor(m => m.NTDBId).NotNull().When(m => m.UserType == "NTDB" || m.UserType == "TQIP").WithMessage("Required");
            RuleFor(m => m.InstitutionName).NotNull().When(m => m.UserType == "Researcher" || m.UserType == "Other").WithMessage("Required");
        }
    }
}