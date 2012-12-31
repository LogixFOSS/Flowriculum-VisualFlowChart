using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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