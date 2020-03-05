using System;
using System.Collections.Generic;

namespace classes {

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
            Company nss = new Company ("NSS", new DateTime (1990, 02, 03));
            // Create three employees
            Employee willy = new Employee ("Willy", "Metcalf", "Lazy person");
            Employee garrett = new Employee ("Garrett", "Freshwater", "Director of Whatever");
            Employee william = new Employee ("William", "Green", "Date Man");

            // Assign the employees to the company
            nss.employeeList.Add (willy);
            nss.employeeList.Add (garrett);
            nss.employeeList.Add (william);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            nss.ListEmployees (nss);
        }
    }
}