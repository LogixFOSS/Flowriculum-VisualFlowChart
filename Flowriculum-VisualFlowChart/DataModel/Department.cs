using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Departments
    {
        string departmentName;
        string departmentCodeName;
        DegreeProgram listOfDegreeProgramsOffered;
        Course listOfCourseOffered;
        Professor listOfProfessor;
        public string getDepartmentName()
        {
            return departmentName;
        }
        public void setDepartmentName(string _departmentName)
        {
            departmentName = _departmentName;
        }
        public string getDepartmentCodeName()
        {
            return departmentCodeName;
        }
        public void setDepartmantCodename(string _departmentCodeName)
        {
            departmentCodeName = _departmentCodeName;
        }
        public DegreeProgram getDegreeProgramList()
        {
            return listOfDegreeProgramsOffered;
        }
        public Course getListOfCourseOffered()
        {
            return listOfCourseOffered;
        }
        public Professor getListOfProfessor()
        {
            return listOfProfessor;
        }
    }