using System;
using System.Collections.ObjectModel;

namespace WpfApp3
{
    public class Student
    {
        public Student() { }
        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    [Serializable]
    public class StringDataSource
    {
        public ObservableCollection<Student> data = new ObservableCollection<Student>();
    }
}
