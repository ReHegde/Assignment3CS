﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public enum Department
    {
        HR = 1, ACCOUNTS, PRODUCTION, PACKING, DISPATCH, SALES
    }
    class Employees
    {
        private int id;
        private String name;
        private Department department;
        private Date JoiningDt;
        private double salary;

       
        public Employees()
        {
            id = 0;
            name = "";
            department = Department.SALES;
            JoiningDt = new Date(10, 10, 2011);
            salary = 0.0;
        }

     

        public Employees(int id, String name, double salary, Date JoiningDt, Department department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.JoiningDt = JoiningDt;
            this.salary = salary;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public Date JoiningDate
        {
            get { return JoiningDt; }
            set { JoiningDt = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

       
        public override string ToString()
        {
            return "\nEmployee Id = " + Id + "\nEmployee Name = " + Name + "\nDate of Joining = " + JoiningDate + "\nDepartment = " + Department + "\nBasic Salary = " + Salary;
        }

      
        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
}

