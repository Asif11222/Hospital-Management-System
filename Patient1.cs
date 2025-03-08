using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Patient1
    {

        private string patientId;
        private string patientName;
        private string patientAddress;
        private int patientAge;
        private string patientGender;
        private string patientBloodGroup;
        private string patientDisease;

        public Patient1(string patientId, string patientName, string patientAddress, int patientAge, string patientGender, string patientBloodGroup, string patientDisease)
        {
            this.patientId = patientId;
            this.patientName = patientName;
            this.patientAddress = patientAddress;
            this.patientAge = patientAge;
            this.patientGender = patientGender;
            this.patientBloodGroup = patientBloodGroup;
            this.patientDisease = patientDisease;
        }

        public Patient1() { }

        public string GetPatientId()
        {
            return patientId;
        }

        public void SetPatientId(string value)
        {
            patientId = value;
        }

        public string GetPatientName()
        {
            return patientName;
        }

        public void SetPatientName(string value)
        {
            patientName = value;
        }

        public string GetPatientAddress()
        {
            return patientAddress;
        }

        public void SetPatientAddress(string value)
        {
            patientAddress = value;
        }

        public int GetPatientAge()
        {
            return patientAge;
        }

        public void SetPatientAge(int value)
        {
            patientAge = value;
        }

        public string GetPatientGender()
        {
            return patientGender;
        }

        public void SetPatientGender(string value)
        {
            patientGender = value;
        }

        public string GetPatientBloodGroup()
        {
            return patientBloodGroup;
        }

        public void SetPatientBloodGroup(string value)
        {
            patientBloodGroup = value;
        }

        public string GetPatientDisease()
        {
            return patientDisease;
        }

        public void SetPatientDisease(string value)
        {
            patientDisease = value;
        }
    }
}
