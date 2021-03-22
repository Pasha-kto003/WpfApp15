using System;

namespace WpfApp15
{
    internal class Model
    {
        GroupManager groupManager;

        public Model()
        {
            groupManager = new GroupManager();
        }

        internal void EditStudent(Group selectedGroup, Student selectedStudent)
        {
            groupManager.Edit(selectedGroup, selectedStudent);
        }

        internal void RemoveStudent(Group selectedGroup, Student selectedStudent)
        {
            groupManager.Remove(selectedGroup, selectedStudent);
        }

        internal void CreateStudent(Group selectedGroup)
        {
            groupManager.CreateStudent(selectedGroup);
        }
    }
}