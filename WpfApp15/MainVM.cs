﻿using System;
using System.Collections.Generic;
using System.Text;
using Mvvm1125;

namespace WpfApp15
{
    class MainVM : MvvmNotify
    {
        Model model;

        public List<Group> Groups { get; set; }
        public List<Student> Students { get => SelectedGroup.Students; set => SelectedGroup.Students = value; }

        public Group SelectedGroup { get; set; }
        public Student SelectedStudent { get; set; }

        public MvvmCommand EditSelectedStudent { get; set; }
        public MvvmCommand RemoveSelectedStudent { get; set; }
        public MvvmCommand CreateStudent { get; set; }


        public MainVM()
        {
            model = new Model();

            EditSelectedStudent = new MvvmCommand(() => model.EditStudent(SelectedGroup, SelectedStudent), () => SelectedStudent != null);
            RemoveSelectedStudent = new MvvmCommand(() => model.RemoveStudent(SelectedGroup, SelectedStudent), () => SelectedStudent != null);
            CreateStudent = new MvvmCommand(() => model.CreateStudent(SelectedGroup), () => true);
        }
    }
}