using System;

namespace SalaryCalculation
{
    class ProgramSalary
    {
        static void Main(string[] args)
        {
            Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            int employeeType = int.Parse(Console.ReadLine());
            
            decimal grossSalary = 0;
            
            if (employeeType == 1)
            {
                Console.Write("Ingrese el salario base: ");
                grossSalary = decimal.Parse(Console.ReadLine());
            }
            else if (employeeType == 2)
            {
                Console.Write("Ingrese el sueldo por hora: ");
                decimal hourlyRate = decimal.Parse(Console.ReadLine());
                
                Console.Write("Ingrese las horas trabajadas: ");
                decimal hoursWorked = decimal.Parse(Console.ReadLine());
                
                grossSalary = hourlyRate * hoursWorked;
            }
            
            decimal netSalary = CalculateNetSalary(grossSalary);
            
            Console.WriteLine($"Salario neto después de impuestos y bono: {netSalary}");
        }
        
        static decimal CalculateNetSalary(decimal grossSalary)
        {
            const decimal taxRate = 0.18m;
            const decimal bonusRate = 0.05m;
            
            decimal tax = grossSalary * taxRate;
            decimal bonus = grossSalary * bonusRate;
            
            return grossSalary - tax + bonus;
        }
    }
}
