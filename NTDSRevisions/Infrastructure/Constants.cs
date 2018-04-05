using System.Configuration;

namespace App.Infrastructure
{
    public class Constants
    {
        public sealed class NtdsStatusType
        {
            public const int ExternalStatus = 1;
            public const int InternalStatusNewEntry = 1;
            public const int InternalStatusNewEntryField = 1;
        }

   }
}