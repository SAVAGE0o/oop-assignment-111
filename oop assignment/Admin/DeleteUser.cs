// File: DeleteUser.cs
using System;

namespace oop_assignment
{
    /// <summary>
    /// Wraps UserManager.DeleteUser so the UI layer doesn’t call SQL directly.
    /// Usage:
    ///     bool ok = new DeleteUser(userId).Execute();
    /// </summary>
    public class DeleteUser
    {
        private readonly int _userId;

        public DeleteUser(int userId)
        {
            _userId = userId;
        }

        /// <returns>true if at least one row was deleted.</returns>
        public bool Execute()
        {
            return UserManager.DeleteUser(_userId);
        }
    }
}
