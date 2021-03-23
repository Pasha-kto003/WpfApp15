using System;
using System.Collections.Generic;

namespace WpfApp15
{
    internal class Model
    {
        GroupManager groupManager;
        public event EventHandler StudentsChanged;

        public Model()
        {
            groupManager = new GroupManager();
        }

        public List<Group> GetGroups()
        {
            return groupManager.Groups;
        }

        internal void EditStudent(Group selectedGroup, Student selectedStudent)
        {
            groupManager.Edit(selectedGroup, selectedStudent);
            StudentsChanged?.Invoke(this, null);
        }

        internal void RemoveStudent(Group selectedGroup, Student selectedStudent)
        {
            groupManager.Remove(selectedGroup, selectedStudent);
            StudentsChanged?.Invoke(this, null);
        }

        internal void CreateStudent(Group selectedGroup)
        {
            groupManager.CreateStudent(selectedGroup);
            StudentsChanged?.Invoke(this, null);
        }
    }
}