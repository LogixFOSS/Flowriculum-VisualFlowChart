using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowriculum_VisualFlowChart.Data
{

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
        public void setSpecialty(Course _course)
        {
            this.specialty = _course;
        }
    }
}