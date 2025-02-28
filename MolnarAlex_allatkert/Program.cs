namespace MolnarAlex_allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vizben allat1 = new("cápa", "Halcska", "vízi", 6);
			Szarazhideg allat2 = new("jegesmedve", "Maci", "emlős", 4);
			Szarazmediterran allat3 = new("róka", "Ravasz", "emlős", 3);
			Szarazmeleg allat4 = new("oroszlán", "Simba", "emlős", 5);
			Szaraztropusi allat5 = new("gorilla", "King-kong", "emlős", 4);


			List<object> lista = new List<object> 
			{ 
				allat1,
				allat2, 
				allat3, 
				allat4,
				allat5,
			};

			foreach (var item in lista) { Console.WriteLine(item); }



		}
	}
}
