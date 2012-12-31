using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowriculum_VisualFlowChart.Data
{

    public class Students : Person
    {
        public Degree degree;
        public string IDnumber { get; set; }
        public FlowChart flowchart;
        public float GPA;
        public float CGPA;
        public Course listOfCourseTaken;
        public string password;
        public Degree getDegree;
        public Degree setDegree;
        public BatchYear batchyear;
        public string Password;
        public enum BatchYear
        {
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4,
            Terminal = 5,
        }

        public class Degree
        {
            public class FlowChart
            {
            }
        }
        public class FlowChart
        {
            //why duplicated?
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
            return this.batchyear;
        }
        public void setBatchYear(int year)
        {
            switch (year)
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
            ///TODO: Logic of GPA
        }
        public void calculateCGPA()
        {
            ///TODO: Logic of CGPA
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
}