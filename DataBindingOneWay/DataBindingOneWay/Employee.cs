﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingTwoWay
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee()
            {
                Name = "Tyler",
                Title = "CEO"
            };
            return emp;
        }

        public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(
                [CallerMemberName] string caller = "")
            {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(caller));
        }

       
    }
}
