using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run Successfully");
            Console.ReadLine();
        }
    }
         
    public class Person
    {
         public Name name;
         public int age;
         public Gender gender;
         public void getName()
         {
             name.getFirstName();
             name.getMiddleName();
             name.getLastName();
         }
         public void setName(string _first, string _middle, string _last)
         {
             name.setFirstName(_first);
             name.setLastName(_last);
             name.setMiddleName(_middle);
         }
         public int getAge()
         {
             return age;
         }
         public void setAge(int _age)
         {
             age = _age;
         }
         public void setGender(string _gender)
         {
             if (_gender == "male")
                 this.gender = Gender.Male;
             else if (_gender == "female")
                 this.gender = Gender.Female;
             else
                 this.gender = 0; 
         }
         public Gender getGender()
         {
             return this.gender;
         }
         public class Name
         {
             public string FirstName;
             public string MiddleName;
             public string LastName;
             public string getFirstName()
             {
                 return FirstName;
             }
             public string getMiddleName()
             {
                 return MiddleName;
             }
             public string getLastName()
             {
                 return LastName;
             }
             public void setFirstName(string _Name)
             {
                 FirstName = _Name;
             }
             public void setMiddleName(string _Name)
             {
                 MiddleName = _Name;
             }
             public void setLastName(string _Name)
             {
                 LastName = _Name;
             }
             public string toString()
             {
                 return FirstName + " " + MiddleName + " " + LastName;
             }

         }

         public enum Gender
         {
             Male,
             Female,
         }
     }
       
    public class Students:Person
    {
         public Degree degree;
         public string IDnumber;
         public FlowChart flowchart;
         public float GPA;
         public float CGPA;
         public Course listOfCourseTaken;
         public string password;
         public Degree getDegree;
         public Degree setDegree;
         public BatchYear batchyear;
         public string assword;
         public enum BatchYear
         {
             First = 1,
             Second,
             Third,
             Fourth,
             Terminal
         }
         public class Degree
         {
             public class FlowChart
             {
             }
         }
         public class FlowChart
         {
         }
         public string getIDnumber()
         {
             return IDnumber;
         }
         public void setIDnumber(string _IDnumber)
         {
             IDnumber = _IDnumber;
         }
         public BatchYear getBatchYear()
         {
             return this.batchyear ;
         }
         public void setBatchYear(int year)
         {
   	      switch(year)
	      {
		    case 1:
		    this.batchyear = BatchYear.First;
		    break;
		    case 2:
		    this.batchyear = BatchYear.Second;	
		    break;
		    case 3:
		    this.batchyear = BatchYear.Third;
		    break;
		    case 4:
		    this.batchyear = BatchYear.Fourth;
		    break;
		    case 5:
		    this.batchyear = BatchYear.Terminal;
		    break;
	      }   
	     }
         public void calculateGPA()
         {
         }
         public void calculateCGPA()
         {
         }    
         public Course getListOfCourseTaken()
         {
	     return this.listOfCourseTaken;
         }
         public string getPassword()
	     {
             return password;
         }
         public void setPassword(string _password)
         {
	     password = _password;
         }
    }
    public class Professor : Person
    {
         public College college;
	     public Course specialty;
	     public College getCollege()
         {
             return this.college;
         }
	     public void setCollege(College _college)
         {
             this.college = _college;  
         }
         public Course getSpecialty()
         {
             return this.specialty;
         }
         public void setSpecialty (Course _course)
         {
             this.specialty = _course;
         }
    }
    public class Course
    {
        string courseCode;
        string courseName;
        string definition;
        int difficulty;
        Course listOfPrerequisites;
        Course listofPostrequisites;
        public string getCourseCode()
        {
            return courseCode;
        }
        public void setCourseCode(string _courseCode)
        {
            courseCode = _courseCode;
        }
        public string getCourseName()
        {
            return courseName;
        }
        public void setCourseName(string _courseName)
        {
            courseName = _courseName;
        }
        public string getDefinition()
        {
            return definition;
        }
        public void setDefinition(string _definition)
        {
            definition = _definition;
        }
        public int getDifficulty()
        {
            return difficulty;
        }
        public void setDifficulty(int _difficulty)
        {
            difficulty = _difficulty;
        }
        public Course getListOfPrerequisites()
        {
            return listOfPrerequisites;
        }
        public Course getListOfPostrequisites()
        {
            return listofPostrequisites;
        }
        public bool isPassed(Course course,string _grade)
        {
            if (string.Compare(_grade, "pass") == 0)
            { return true; }
            return false;
        }
    }
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
    public class DegreeProgram
    {
    }
}