using System;

namespace WPFCRUDDemo.Model
{
    public  class Employee : BaseNotifyPropertyChanged, ICloneable
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetField(ref _lastName, value); }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { SetField(ref _birthDate, value); }
        }

        private Enums.Gender _gender;
        public Enums.Gender Gender
        {
            get { return _gender; }
            set { SetField(ref _gender, value); }
        }

        private Enums.MaritalState _maritalState;
        public Enums.MaritalState MaritalState
        {
            get { return _maritalState; }
            set { SetField(ref _maritalState, value); }
        }

        private DateTime _adimissionDate;
        public DateTime AdmissionDate
        {
            get { return _adimissionDate; }
            set { SetField(ref _adimissionDate, value); }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
