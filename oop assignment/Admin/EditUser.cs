using System;

namespace oop_assignment
{
    /// <summary>
    /// Encapsulates the logic to update an existing user.
    /// Usage:
    ///   var cmd = new EditUser(updatedUser);
    ///   bool ok = cmd.Execute();
    /// </summary>
    public class EditUser
    {
        // The user object containing the new values to save
        private readonly User _user;

        // Pass in a User that already has UserID + updated fields
        public EditUser(User user)
        {
            _user = user;
        }

        /// <summary>
        /// Calls UserManager.UpdateUser and returns its result.
        /// </summary>
        public bool Execute()
        {
            return UserManager.UpdateUser(_user);
        }
    }
}
