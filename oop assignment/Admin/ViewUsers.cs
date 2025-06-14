// File: ViewUsers.cs
using System.Collections.Generic;

namespace oop_assignment
{
    /// <summary>
    /// Returns the full user list (wrapper around UserManager).
    /// Usage:
    ///     var list = new ViewUsers().Execute();
    /// </summary>
    public class ViewUsers
    {
        public List<User> Execute()
        {
            return UserManager.GetAllUsers();   // no SQL here, relies on UserManager
        }
    }
}
