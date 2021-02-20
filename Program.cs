using System;

namespace DIO.Series
{
    class Program
    {
        static repositorySeries repository = new repositorySeries();
        static void Main(string[] args)
        {
            string optionUser = getOptionUser();

			while (optionUser.ToUpper() != "X")
			{
				switch (optionUser)
				{
					case "1":
						listSeries();
						break;
					case "2":
						insertSerie();
						break;
					case "3":
						updateSerie();
						break;
					case "4":
						deleteSerie();
						break;
					case "5":
						visualizarSerie();
						break;
					case "C":
						Console.clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOption = getOptionUser();
			}

			Console.WriteLine("Thank you for using our services.");
			Console.ReadLine();
        }

        private static void deleteSerie()
		{
			Console.Write("Enter the series id: ");
			int indexSerie = int.Parse(Console.ReadLine());

			repository.delete(indexSerie);
		}

        private static void viewSerie()
		{
			Console.Write("Enter the series id: ");
			int indexSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indexSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Enter the series id: ");
			int indexSerie = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
			}
			Console.Write("Enter the gender between the options above: ");
			int enterGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the Series Title: ");
			string enterTitle = Console.ReadLine();

			Console.Write("Enter the Series Start Year: ");
			int enterYear = int.Parse(Console.ReadLine());

			Console.Write("Enter Series Description: ");
			string enterDescription = Console.ReadLine();

			Serie updateSerie = new Serie(id: indexSerie,
										genre: (Genre)enterGenre,
										title: enterTitle,
										year: enterYear,
										description: enterDescription);

			repositorio.Atualiza(indexSerie, updateSerie);
		}
        private static void listSeries()
		{
			Console.WriteLine("List eeries");

			var lista = repository.List();

			if (list.Count == 0)
			{
				Console.WriteLine("No series registered.");
				return;
			}

			foreach (var serie in list)
			{
                var delete = serie.returnDelete();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.returnId(), serie.returnTitulo(), (delete ? "*Delete*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Insert new series");

			foreach (int i in Enum.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
			}
			Console.Write("Enter the gender between the options above: ");
			int enterGenre = int.Parse(Console.ReadLine());

			Console.Write("Enter the Series Title: ");
			string enterTitle = Console.ReadLine();

			Console.Write("Enter the Series Start Year: ");
			int enterYear = int.Parse(Console.ReadLine());

			Console.Write("Enter Series Description: ");
			string enterDescription = Console.ReadLine();

			Serie novaSerie = new Serie(id: repository.nextId(),
										genero: (Genre)enterGenre,
										title: enterTitle,
										year: enterYear,
										description: enterDescription);

			repository.Insert(newSerie);
		}

        private static string getOptionUser()
		{
			Console.WriteLine();
			Console.WriteLine("We thank you!");
			Console.WriteLine("Enter the desired option:");

			Console.WriteLine("1- List series");
			Console.WriteLine("2- Insert new series");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Update series");
			Console.WriteLine("5- View series");
			Console.WriteLine("C- Clear Screen");
			Console.WriteLine("X- Exit");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
    }
}
