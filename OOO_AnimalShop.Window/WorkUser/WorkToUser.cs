using OOO_AnimalShop.Context.Models;
using OOO_AnimalShop.Context.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_AnimalShop.Window.WorkUser
{
    public static class WorkToUser
    {
        private static User user;
        public static User User
        {
            get
            {
                if(user == null)
                {
                    user = new User()
                    {

                    };
                }
                return user;
            }
            set
            {
                user = value;
            }
        }

        public static bool CompareTo(RoleTypes roleTypes) => roleTypes == user.RoleType;
    }
}
