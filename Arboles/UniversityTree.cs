using System;


	class UniversityTree
	{
	int accountant = 0;
	float salaryMay = 0;
	string salaryoMayT = "";
	string rollook = "";
	public PositionNode Root;

	// Metodo para crear los nodos
	public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
    {
		PositionNode newNode = new PositionNode();
		newNode.Position = positionToCreate;
		if(Root == null)
        {
			Root = newNode;
			return;
        }

		if(parent == null)
        {
			return;
        }

		if(parent.Position.Name == parentPositionName)
        {
			if(parent.Left == null)
            {
				parent.Left = newNode;
				return;
            }
			parent.Right = newNode;
			return;
        }

		CreatePosition(parent.Left, positionToCreate, parentPositionName);
		CreatePosition(parent.Right, positionToCreate, parentPositionName);
    }

	// Imprint Tree
	public void PrintTree(PositionNode from)
    {
		
		if(from == null)
        {
			return;
        }
        else
        {
			accountant++;
		}
		from.Position.tax = from.Position.Salary * (from.Position.tax / 100);
	
        Console.WriteLine($"{from.Position.Name} : tax free - ${from.Position.Salary} with tax - ${from.Position.tax}");
		PrintTree(from.Left);
		PrintTree(from.Right);

	}


	//Add Salaries

	public float Addsalaries(PositionNode from)
    {
		if (from == null)
		{
			return 0;
		}

		return from.Position.Salary + Addsalaries(from.Left) + Addsalaries(from.Right);
	}

	public float AddsalariesTax(PositionNode from)
	{
		if (from == null)
		{
			return 0;
		}

		return  from.Position.tax + AddsalariesTax(from.Left) + AddsalariesTax(from.Right);
	}

	//take tax
	public float taxsalary(PositionNode from)
	{
		if (from == null)
		{
			return 0;
		}

		return (from.Position.Salary + Addsalaries(from.Left) + Addsalaries(from.Right))/accountant;
	}

	public void PrintTreeRector(PositionNode from)
	{

		if (from == null)
		{
			return;
		}

        if (from.Position.Name == "rector")
        {

        }
        else
        {
            if (salaryMay < from.Position.Salary)
            {
				salaryMay = from.Position.Salary;
				salaryoMayT = from.Position.Name;
			}

		}

	
		PrintTreeRector(from.Left);
		PrintTreeRector(from.Right);

	}

	//get higher salary
	public string salaryhigh()
	{
		
		return $"Higher salary is:  {salaryoMayT} : {salaryMay}";
	}

	public void PrintSalaryRol(PositionNode from , string rol)
	{

		if (from == null)
		{
			return;
		}

		if (from.Position.Name.ToLower() == rol.ToLower())
		{
			rollook = $"{from.Position.Name} : {from.Position.Salary}";
		}



		//Console.WriteLine($"{contador}  { from.Position.Name}");
		PrintSalaryRol(from.Left, rol);
		PrintSalaryRol(from.Right, rol);

	}

	//print role
	public string Printrole()
	{

		return rollook;
	}
}

