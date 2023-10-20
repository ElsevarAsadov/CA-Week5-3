using System;


namespace Something
{
    public class Employee
    {
        private static int nextId = 1;
        private int id;
        private string fullName;
        private string departmentNo;
        private int age;
        private int experience;
        private double _salary;

        public int Id => id;

        public double Salary 
        {
            get=>_salary;
            set 
            {
                _salary = value;
            } 
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (IsValidFullName(value))
                {
                    fullName = value;
                }
                else
                {
                    throw new InvalidFullNameException("Invalid full name format. It should be in the 'Name Lastname' format.");
                }
            }
        }

        public string DepartmentNo
        {
            get { return departmentNo; }
            set
            {
                if (IsValidDepartmentNo(value))
                {
                    departmentNo = value;
                }
                else
                {
                    throw new InvalidDepartmentNoException("Invalid department number format. It should be two uppercase letters.");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (IsValidAge(value))
                {
                    age = value;
                }
                else
                {
                    throw new InvalidAgeException("Invalid age. Age should be between 0 and 150.");
                }
            }
        }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (IsValidExperience(value))
                {
                    experience = value;
                }
                else
                {
                    throw new InvalidExperienceException("Invalid experience. Experience should be greater than 0.");
                }
            }
        }

        public Employee(string fullName, string departmentNo, int age, int experience, double salary)
        {
            id = nextId++;
            FullName = fullName;
            DepartmentNo = departmentNo;
            Age = age;
            Experience = experience;
            Salary = salary;
        }

        private bool IsValidFullName(string fullName)
        {
         
            string[] parts = fullName.Split(' ');
            return parts.Length == 2 && !string.IsNullOrWhiteSpace(parts[0]) && !string.IsNullOrWhiteSpace(parts[1]);
        }

        private bool IsValidDepartmentNo(string departmentNo)
        {
   
            return departmentNo.Length == 2 && departmentNo.All(char.IsUpper);
        }

        private bool IsValidAge(int age)
        {
            return age >= 0 && age <= 150;
        }

        private bool IsValidExperience(int experience)
        {
            return experience >= 0;
        }
    }
}
