using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Something
{

    public class Program
    {
        public static List<Employee> employees = new List<Employee>();

        public static double CalculateSalary()
        {
            double totalSalary = 0;
            foreach (Employee employee in employees)
            {

                FieldInfo salaryField = employee.GetType().GetField("_salary", BindingFlags.NonPublic | BindingFlags.Instance);

                double salary = Convert.ToDouble(salaryField.GetValue(employee));

                totalSalary += salary;
                
            }
            return totalSalary;
        }

        public static void Main()
        {
            try
            {
                Employee emp1 = new Employee("Name1 Surname1", "HR", 20, 20, 1000);
                Employee emp2 = new Employee("Name2 Surname2", "IT", 25, 5, 2000);

                employees.Add(emp1);
                employees.Add(emp2);


                double totalSalary = CalculateSalary();

                Console.WriteLine("Total Salary: " + totalSalary);
            }
            catch (InvalidFullNameException ex)
            {
                Console.WriteLine("Invalid Full Name: " + ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Invalid Age: " + ex.Message);
            }
            catch (InvalidDepartmentNoException ex)
            {
                Console.WriteLine("Invalid Department Number: " + ex.Message);
            }
            catch (InvalidExperienceException ex)
            {
                Console.WriteLine("Invalid Experience: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
