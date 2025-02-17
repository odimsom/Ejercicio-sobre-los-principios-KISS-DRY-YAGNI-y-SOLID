using System;
using System.Runtime.CompilerServices;

namespace Principios
{
    public class Payroll
    {
        private decimal interes = 0.18m;
        private decimal bonus = 0.05m;

        static decimal calcularSalario(decimal salary)
        {
            decimal taxSalario = salary * 0.18m;
            decimal bonus = salary * 0.05m;
            return salary - taxSalario + bonus;
        }

        public decimal CalcularSalarioFijo(decimal baseSalary)
        {
            return calcularSalario(baseSalary);
        }

        public decimal CalcularSalarioTime(decimal salarioPorHora, int horaDeTrabajo)
        {
            decimal salary = salarioPorHora * horaDeTrabajo;
            return calcularSalario(salary);
        }
    }
}