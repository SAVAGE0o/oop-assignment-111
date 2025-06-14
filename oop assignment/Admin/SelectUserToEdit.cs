// File: SelectUserToEdit.cs
using System.Collections.Generic;

namespace oop_assignment
{
    /// <summary>
    /// Returns all users so the selector form can display them.
    /// Reuses UserManager—no SQL here.
    /// </summary>
    public class SelectUserToEdit
    {
        public List<User> Execute()
        {
            return UserManager.GetAllUsers();
        }
    }
}
