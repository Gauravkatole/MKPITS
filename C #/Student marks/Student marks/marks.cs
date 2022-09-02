using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_marks
{
    internal class marks
    {
        public int rollno;
        public string name;
        public int che;
        public int phy;
        public int maths;
        public int res;
        public float per;
        public string total()
        {
             res = che + phy + maths;
            return " Total Marks: " + res.ToString();
        }
        public string percentage()
        {
            
            per = res / 300.0f * 100.0f;
            return "Percentage: " + per.ToString();
            
        }
        public string grade()
        {
            string result = null;
            if (per >= 90)
            {
                result = "Distintion";
            }
            else if (per >= 80 &&per<70 )
            {
                result = "Fail";
            }
            return "Grade: " + result.ToString(); ;
        }

    }
}
