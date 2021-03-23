using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp15
{
    class GroupManager
    {
        public List<Group> Groups { get; set; } = new List<Group>();

        public GroupManager()
        {
            Groups.Add(new Group { GroupName = "1125" });
        }
        
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
            Groups.Find(g => g == selectedGroup).Students.Add(new Student { LastName = "Example"});
        }
    }

    class Group
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
