using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class College
    {
        string collegeName;
        string collegeCodeName;
        string collegeDescription;
        Departments collegeDepartments;
        Students listOfStudents;
        public string getCollegeName()
        {
            return collegeName;
        }
        public void setCollegeName(string _collegeName)
        {
            collegeName = _collegeName;
        }
        public string getCollegeCodeName()
        {
            return collegeCodeName;
        }
        public void setCollegeCodename(string _collegeCodeName)
        {
            collegeCodeName = _collegeCodeName;
        }
        public string getCollegeDescription()
        {
            return collegeDescription;
        }
        public void setCollegeDescription(string _collegeDescription)
        {
            collegeDescription = _collegeDescription;
        }
        public Departments getDepartment()
        {
            return this.collegeDepartments;
        }
        public void setDepartment(Departments department)
        {
            this.collegeDepartments = department;
        }
       

    }