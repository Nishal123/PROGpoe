using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Class1
    { 
        progPOEEntities1 db = new progPOEEntities1();
        String user = "Invalid";
        
        public String login(String Username, String Password)
        {
            foreach ( var s in db.Students)
            {
                if ((s.stu_Num == Convert.ToInt16(Username)) && (s.stu_Password == Password))
                {
                    user = "Student";
                }
                else 
                {
                    user = "Invalid";

                }


            }
            foreach (Lecturer L in db.Lecturers)
            {
                if ((L.L_Firstname.Equals(Username)) && (L.L_Password == Password))
                {
                    user = "Lecturer";
                }

            }
            return user;


        }


    }
}
