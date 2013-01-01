using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowriculum_VisualFlowChart.Data
{
    public abstract class Person
    {
		public enum Gender
        {
            Male,
            Female,
        }
		
		public Name name;
        public int age;
        public Gender gender;
		
        public void getName()
        {
            name.getFirstName();
            name.getMiddleName();
            name.getLastName();
        }
		
        ///<summary>
		///Sets the full name.
		///</summary>
		
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
		
        ///<summary>
		///Contains the full name of the person.
		///</summary>
		
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
            public string toOneString()
            {
                return (FirstName + " " + MiddleName + " " + LastName);
            }

        }

    }
}
