using System;
using System.Collections.Generic;
using AcsAptify;
using FluentValidation;

namespace App.Models.PersonSuggestion
{
    public class PersonSuggestionModel : PersonSuggestionUpdateModel
    {
        public string NtdsVersionId_Name { get; set; }
        public string ExternalStatusTypeId_Name { get; set; }
        public string InternalStatusTypeId_Name { get; set; }
        public string SubmissionDate { get; set; }
        public string DateCreated { get; set; }
        public string DateUpdated { get; set; }
    }
    public class PersonSuggestionUpdateModel : IAptifyEntity
    {
        public int ID { get; set; }
        public int PersonId { get; set; }
        public string NewFieldName { get; set; }
        public string Definition { get; set; }
        public string FieldValues { get; set; }
        public string AdditionalInformation { get; set; }
        public string DataSourceHierarchy { get; set; }
        public string AssociatedEditChecks { get; set; }
        public string Description { get; set; }
        public string ChapterName { get; set; }
        public string VersionName { get; set; }
        public Nullable<int> NtdsChapterId { get; set; }
        public Nullable<int> NtdsVersionId { get; set; }
        public int FieldId { get; set; }
        public int Year { get; set; }
        public int InternalStatusTypeId { get; set; }
        public int ExternalStatusTypeId { get; set; }
        public string FieldName { get; set; }
        public string SelectedFieldId { get; set; }
        public int NtdsFieldTypeId { get; set; }
        public string NtdsFieldTypeId_Name { get; set; }
        public bool IsAppendix { get; set; }

        public string EntityName
        {
            get { return "ACSNtdsSuggestion"; }
        }

        public IList<IAptifySubType> SubTypes
        {
            get { return null; }
            set { }
        }

        public int EntityID()
        {
            return ID;
        }
    }
    public class PersonSuggestionValidator : AbstractValidator<PersonSuggestionModel>
    {
        public PersonSuggestionValidator()
        {
            RuleFor(m => m.NtdsVersionId).NotEmpty().WithMessage("Required Book Version");
            RuleFor(m => m.NtdsChapterId).NotEmpty().WithMessage("Required Chapter Name");
            RuleFor(m => m.FieldId).NotEmpty().When(m => m.SelectedFieldId != "-1").WithMessage("Required Data Field");
            RuleFor(m => m.NewFieldName).NotEmpty().WithMessage("Required New Field Name").When(m => m.SelectedFieldId == "-1" && !m.IsAppendix);
            RuleFor(m => m.Definition).NotNull().When(m => m.ID < 0 && m.FieldId < 0 && !m.IsAppendix).WithMessage("Required Definition");
            RuleFor(m => m.FieldValues).NotNull().When(m => m.ID < 0 && m.FieldId < 0 && !m.IsAppendix).WithMessage("Required Field Values");
            RuleFor(m => m.NtdsFieldTypeId).NotEmpty().When(m => m.IsAppendix && m.SelectedFieldId == "-1").WithMessage("Required Appendix Type");
            RuleFor(m => m.NewFieldName).NotNull().When(m => m.IsAppendix && m.SelectedFieldId == "-1").WithMessage("Required Name");
            RuleFor(m => m.Definition).NotNull().When(m => m.IsAppendix && m.SelectedFieldId == "-1").WithMessage("Required Suggestion");
        }
    }
}