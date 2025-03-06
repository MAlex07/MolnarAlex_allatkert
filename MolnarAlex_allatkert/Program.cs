namespace MolnarAlex_allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int db = r.Next(5, 16);

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
				allat5
			};

			foreach (var item in lista) { Console.WriteLine(item); }


			string keret = new string('_', db);
            Console.WriteLine(keret);
            Console.Write("|");
			Console.BackgroundColor = ConsoleColor.Green;
			for (int i = 0; i < lista.Count; i++)
			{
				if (lista[i] != null)
				{
					Console.Write(" ");

				}
			}
			Console.BackgroundColor = ConsoleColor.Black;
			for (int i = 0;i < db - lista.Count; i++)
			{
                Console.Write(" ");
            }
			Console.WriteLine("|");
			Console.WriteLine(keret);



			Console.WriteLine("O(jegesmedve)\nO(oroszlán)");
			int haladas = 0;
			int haladas2 = 0;
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(1000);
				Console.Clear();
                Console.WriteLine("(jegesmedve)\n(oroszlán)");
				Console.SetCursorPosition(haladas += allat2.Sebesseg, 0);
				Console.WriteLine("O");
				Console.SetCursorPosition(haladas2 += allat4.Sebesseg, 1);
				Console.WriteLine("O");

			}
		}
	}
}
