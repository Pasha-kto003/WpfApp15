using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp15
{
    class GroupManager
    {
        public List<Group> Groups { get; set; }
        
        internal void Edit(Group selectedGroup, Student selectedStudent)
        {
            throw new NotImplementedException();
        }

        internal void Remove(Group selectedGroup, Student selectedStudent)
        {
            Groups.Find(g => g == selectedGroup).Students.Remove(selectedStudent);
        }

        internal void CreateStudent(Group selectedGroup)
        {
            Groups.Find(g => g == selectedGroup).Students.Add(new Student());
        }
    }

    class Group
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
    }
}
