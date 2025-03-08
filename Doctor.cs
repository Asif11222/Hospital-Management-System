using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Doctor
    {
        private string docId;
        private string docName;
        private int yearsOfExperience;
        private string password;

        public Doctor(string docId, string docName, int yearsOfExperience, string password)
        {
            this.docId = docId;
            this.docName = docName;
            this.yearsOfExperience = yearsOfExperience;
            this.password = password;
        }

        public Doctor() { }

        public string GetDocId()
        {
            return docId;
        }

        public void SetDocId(string value)
        {
            docId = value;
        }

        public string GetDocName()
        {
            return docName;
        }

        public void SetDocName(string value)
        {
            docName = value;
        }

        public int GetYearsOfExperience()
        {
            return yearsOfExperience;
        }

        public void SetYearsOfExperience(int value)
        {
            yearsOfExperience = value;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }
    }
}
