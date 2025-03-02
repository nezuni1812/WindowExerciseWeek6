using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowExerciseWeek6.Model
{
    public class Employee : INotifyPropertyChanged, ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public object Clone()
        {
            var result = new Employee()
            {
                ID = this.ID,
                Name = this.Name
            };
            return result;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    };

   
}
