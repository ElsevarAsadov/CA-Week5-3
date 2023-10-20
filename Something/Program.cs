using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Something
{

    public class Program
    {
        public static Employee[] employees = Array.Empty<Employee>();

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

        public static void Add(Employee e)
        {
            Array.Resize(ref employees, employees.Length+1);
            employees[^1] = e;
        }

        public static void Main()
        {
            try
            {
                Employee emp1 = new Employee("Name1 Surname1", "HR", 20, 20, 1000);
                Employee emp2 = new Employee("Name2 Surname2", "IT", 25, 5, 2000);

                Add(emp1);
                Add(emp2);


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
