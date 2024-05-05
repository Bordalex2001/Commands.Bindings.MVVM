using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Bindings.MVVM
{
    internal class Resume
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; }
    }

    internal static class ResumeDB
    {
        public static List<Resume> resumes = new List<Resume>();

        public static void AddResume(Resume resume)
        {
            resumes.Add(resume);
        }

        public static List<Resume> GetResumes()
        {
            return resumes;
        }
    }
}
