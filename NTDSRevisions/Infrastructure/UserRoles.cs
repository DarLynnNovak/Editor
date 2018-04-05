using System;
using System.Collections.Generic;

namespace App.Infrastructure
{
    [Serializable()]
    public class UserRoles
    {
        public IList<AcsAuthorize.UserType> CurrentRoles { get; set; }

        public UserRoles()
        {
            CurrentRoles = new List<AcsAuthorize.UserType>();
        }
    }
}