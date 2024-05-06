using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Commands.Bindings.MVVM
{
    internal class ViewModel : DependencyObject
    {
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AgeProperty;
        private static readonly DependencyProperty MaritalStatusProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty EmailProperty;
        private static readonly DependencyProperty SkillsProperty;
        private static readonly DependencyProperty UsersProperty;

        static ViewModel()
        {
            FullNameProperty = DependencyProperty.Register("Full name", typeof(string), typeof(ViewModel));
            AgeProperty = DependencyProperty.Register("Age", typeof(int), typeof(ViewModel));
            MaritalStatusProperty = DependencyProperty.Register("Marital status", typeof(string), typeof(ViewModel));
            AddressProperty = DependencyProperty.Register("Address", typeof(string), typeof(ViewModel));
            EmailProperty = DependencyProperty.Register("Email", typeof(string), typeof(ViewModel));
            SkillsProperty = DependencyProperty.Register("Skills", typeof(List<string>), typeof(ViewModel));
            UsersProperty = DependencyProperty.Register("Users", typeof(ObservableCollection<Resume>), typeof(ViewModel));
        }

        public ViewModel() 
        {
            FullName = "ПІБ";
            Age = 18;
            MaritalStatus = "Сімейний стан";
            Address = "Адреса";
            Email = "Email";
            Skills = new List<string>();
        }

        public string FullName
        {
            get 
            { 
                return (string)GetValue(FullNameProperty); 
            }
            set
            {
                SetValue(FullNameProperty, value);
            }
        }

        public int Age
        {
            get
            {
                return (int)GetValue(AgeProperty);
            }
            set
            {
                SetValue(AgeProperty, value);
            }
        }

        public string MaritalStatus
        {
            get
            {
                return (string)(GetValue(MaritalStatusProperty));
            }
            set
            {
                SetValue(MaritalStatusProperty, value);
            }
        }

        public string Address
        {
            get
            {
                return (string)(GetValue(AddressProperty));
            }
            set
            {
                SetValue(AddressProperty, value);
            }
        }

        public string Email
        {
            get
            {
                return (string)(GetValue(EmailProperty));
            }
            set
            {
                SetValue(EmailProperty, value);
            }
        }

        public List<string> Skills
        {
            get
            {
                return (List<string>)GetValue(SkillsProperty);
            }
            set
            {
                SetValue(SkillsProperty, value);
            }
        }

        public ObservableCollection<Resume> Users
        {
            get
            {
                return (ObservableCollection<Resume>)GetValue(UsersProperty);
            }
            set
            {
                SetValue(UsersProperty, value);
            }
        }

        public RelayCommand _OkCommand;
        public ICommand ButtonClick
        {
            get
            {
                if (_OkCommand == null)
                {
                    _OkCommand = new RelayCommand();
                }
            }
        }

        private void Add(object obj)
        {
            Users.Add(new Resume() 
            { 
                FullName = this.FullName, 
                Age = this.Age,
                MaritalStatus = this.MaritalStatus,
                Address = this.Address,
                Email = this.Email,
                Skills = this.Skills,
            }); 
        }

        private void CanAdd(object obj)
        {
            
        }
    }
}