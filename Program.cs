﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado_dot_net_assignment1
{
    class Program
    {
        static void Main()
        {
            student.AddStudent("Pratyush", "17202254", "B.tech", "virtusa", "hyd", "pratyushp@gmail.com");
            student.getstudentbyname("Pratyush");
        }
    }
}
