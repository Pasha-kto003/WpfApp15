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
            Groups.Add(new Group { GroupName = "1115" });
            Groups.Add(new Group { GroupName = "1121" });
            Groups.Add(new Group { GroupName = "1135" });
            Groups.Add(new Group { GroupName = "1131" });
        }

        internal void Edit(Group selectedGroup, Student selectedStudent)
        {
            
        }

        internal void Remove(Group selectedGroup, Student selectedStudent)
        {
            selectedGroup?.Students.Remove(selectedStudent);
        }

        internal void CreateStudent(Group selectedGroup)
        {
            selectedGroup?.Students.Add(new Student {  FirstName = "gdfdjfgdjfgdf", LastName = "sdgsdsddssd", FatherName = "fsffsssff", Address = "sdsdsdsds"});
            selectedGroup?.Students.Add(new Student {  FirstName = "gdfdjfgdjfgdf", LastName = "sdgsdsddssd", FatherName = "fsffsssff", Address = "sdsdsdsds"});
            selectedGroup?.Students.Add(new Student {  FirstName = "gdfdjfgdjfgdf", LastName = "sdgsdsddssd", FatherName = "fsffsssff", Address = "sdsdsdsds"});
        }
    }

    class Group
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
