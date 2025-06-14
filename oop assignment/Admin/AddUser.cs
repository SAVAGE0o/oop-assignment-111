using System;

namespace oop_assignment
{
    public class AddUser
    {
        private User _user;

        public AddUser(User user)
        {
            _user = user;
        }

        // This method executes the add operation
        public bool Execute()
        {
            return UserManager.AddUser(_user);
        }
    }
}
