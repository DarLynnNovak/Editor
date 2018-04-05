using System;
using System.Web;

namespace App.Infrastructure
{
    [Serializable]
    public class SessionVariables : ISessionVariables
    {
        public string ContactEmail { get; set; }
        public int PersonId { get; set; }
        public bool PersonIsPrimary { get; set; }
        public string PersonName { get; set; }
        public int CommitteeId { get; set; }
        public int SponsorId { get; set;  }
        public UserRoles UserRoles { get; set; }
        public DateTime DateCreated { get; set; }

        public SessionVariables()
        {
            DateCreated = DateTime.Now;
        }

        public void LoadVariables(HttpContextBase context)
        {
            HttpSessionStateBase session = context.Session;
            ContactEmail = session["sess_contactemail"] == null ? "" : session["sess_contactemail"].ToString();
            PersonId = session["sess_personid"] == null ? 0 : int.Parse(session["sess_personid"].ToString());
            PersonIsPrimary = session["sess_personisprimary"] == null ? false : bool.Parse(session["sess_personisprimary"].ToString());
            PersonName = session["sess_personname"] == null ? "" : session["sess_personname"].ToString();
            CommitteeId = session["sess_committeeid"] == null ? 0 : int.Parse(session["sess_committeeid"].ToString());
            SponsorId = session["sess_sponsorid"] == null ? 0 : int.Parse(session["sess_sponsorid"].ToString());
            UserRoles = session["sess_userroles"] == null ? new UserRoles() : (UserRoles)session["sess_userroles"];
        }

        public void SaveVariables(HttpContextBase context)
        {
            HttpSessionStateBase session = context.Session;
            session["sess_contactemail"] = ContactEmail;
            session["sess_personid"] = PersonId;
            session["sess_personisprimary"] = PersonIsPrimary;
            session["sess_personname"] = PersonName;
            session["sess_committeeid"] = CommitteeId;
            session["sess_sponsorid"] = SponsorId;
            session["sess_userroles"] = UserRoles;
        }

        public void Clear(HttpContextBase context)
        {
            ContactEmail = string.Empty;
            PersonId = 0;
            PersonName = string.Empty;
            CommitteeId = 0;
            SponsorId = 0;
            UserRoles = new UserRoles();
            SaveVariables(context);
        }
    }
}