using System.Collections.Generic;
using AcsAptify;
using StructureMap.Attributes;

namespace App.Infrastructure
{
    public class BaseViewModel
    {
        public IList<SaveResults> SaveResults; 
        public bool CanEdit { get; set; }

        public string ContactEmail
        {
            get { return SessionVariables.ContactEmail; }
            set { SessionVariables.ContactEmail = value; }
        }

        public bool CurrentPersonIsPrimary
        {
            get { return SessionVariables.PersonIsPrimary; }
        }

        public string CurrentPersonName
        {
            get { return SessionVariables.PersonName; }
        }

        public string InstructionsText { get; set; }
        public int CurrentCommitteeId { get { return SessionVariables.CommitteeId; } set { SessionVariables.CommitteeId = value; } }
        public int CurrentSponsorId { get { return SessionVariables.SponsorId; } set { SessionVariables.SponsorId = value; } }
        [SetterProperty]
        public ISessionVariables SessionVariables
        {
            get;
            set;
        }

        public string UpdateTargetId { get; set; }
        public string ViewName { get; protected set; }

        protected int CurrentPersonId
        {
            get { return SessionVariables.PersonId; }
        }

        public bool NewUser { get; set; }
       
        public virtual void Load()
        {
            InstructionsText = string.Empty;
        }
    }
}