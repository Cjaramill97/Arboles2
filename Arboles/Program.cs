using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.tax = 30;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "vicerector financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.tax = 25;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.tax = 20;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.tax = 22;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.tax = 19;


            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.tax = 19;

            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "vicerector academico";
            vicAcaPosition.Salary = 780;
            vicAcaPosition.tax = 25;


            Position jefeRegisPosition = new Position();
            jefeRegisPosition.Name = "Jefe de registro academico";
            jefeRegisPosition.Salary = 640;
            jefeRegisPosition.tax = 22;


            Position secGest2Position = new Position();
            secGest2Position.Name = "Secretario de gestion 2";
            secGest2Position.Salary = 360;
            secGest2Position.tax = 19;

            Position secGest1Position = new Position();
            secGest1Position.Name = "Secretario de gestion 1";
            secGest1Position.Salary = 400;
            secGest1Position.tax = 19;

            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2";
            asist2Position.Salary = 170;
            asist2Position.tax = 10;


            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.tax = 5;

            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1";
            asist1Position.Salary = 250;
            asist1Position.tax = 10;




            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition( universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegisPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGest2Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGest1Position, jefeRegisPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secGest1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);

            universityTree.CreatePosition(universityTree.Root, asist1Position, secGest1Position.Name);


            universityTree.PrintTree(universityTree.Root);
            universityTree.PrintTreeRector(universityTree.Root);
            universityTree.PrintSalaryRol(universityTree.Root, "Secretaria FINANCIERA 2");
            float totalSalary = universityTree.Addsalaries(universityTree.Root);

            Console.WriteLine($"Total Salaries: { totalSalary}");
            float totalProm = universityTree.taxsalary(universityTree.Root);
            Console.WriteLine($"The tax salary is : { totalProm }");
            Console.WriteLine(universityTree.salaryhigh());
            Console.WriteLine(universityTree.Printrole());
            Console.WriteLine($"Add tax is : {universityTree.AddsalariesTax(universityTree.Root)}");
            


            Console.ReadLine();
        }
    }
}
