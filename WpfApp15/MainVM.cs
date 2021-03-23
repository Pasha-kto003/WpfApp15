using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Mvvm1125;

namespace WpfApp15
{
    class MainVM : MvvmNotify
    {
        Model model;

        public List<Group> Groups { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public Group SelectedGroup { get; set; }
        public Student SelectedStudent { get; set; }

        public MvvmCommand EditSelectedStudent { get; set; }
        public MvvmCommand RemoveSelectedStudent { get; set; }
        public MvvmCommand CreateStudent { get; set; }
        public MvvmCommand EditList { get; set; }


        public MainVM()
        {
            model = new Model();
            Groups = model.GetGroups();
            EditSelectedStudent = new MvvmCommand(() => model.EditStudent(SelectedGroup, SelectedStudent), () => SelectedStudent != null);
            RemoveSelectedStudent = new MvvmCommand(() => model.RemoveStudent(SelectedGroup, SelectedStudent), () => SelectedStudent != null);
            CreateStudent = new MvvmCommand(() => model.CreateStudent(SelectedGroup), () => true);
            

            model.StudentsChanged += Model_StudentsChanged;
        }

        private void Model_StudentsChanged(object sender, EventArgs e)
        {
            Students = new ObservableCollection<Student>( SelectedGroup?.Students);
            NotifyPropertyChanged("Students");
        }
    }
}
