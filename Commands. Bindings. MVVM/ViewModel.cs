using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands.Bindings.MVVM
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Resume> Resumes { get; set; }
        public Resume SelectedResume { get; set; }

        public ICommand ViewResumeCommand { get; }

        public ViewModel()
        {
            Resumes = new ObservableCollection<Resume>(ResumeDB.GetResumes());
            ViewResumeCommand = new RelayCommand(ViewResume);
        }

        private void ViewResume()
        {
            if (SelectedResume != null)
            {
                Resumes.Add(SelectedResume);
            }
        }
    }
}