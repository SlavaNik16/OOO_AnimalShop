using OOO_AnimalShop.Context.Models;
using OOO_AnimalShop.Context.Models.Enums;

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
