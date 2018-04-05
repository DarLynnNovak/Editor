using System.Web;

namespace App.Infrastructure
{
    public interface ISessionVariables
    {
        string ContactEmail { get; set; }
        int PersonId { get; set; }
        string PersonName { get; set; }
        bool PersonIsPrimary { get; set; }
        int CommitteeId { get; set; }
        int SponsorId { get; set; }
        UserRoles UserRoles { get; set; }

        void LoadVariables(HttpContextBase context);

        void SaveVariables(HttpContextBase context);

        void Clear(HttpContextBase context);
    }
}