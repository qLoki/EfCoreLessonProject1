using Lesson1_EFCore_DBLibrary_;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFLesson1Training
{
	internal class Program
	{
		private static IConfigurationRoot _configuration;
		private static DbContextOptionsBuilder<AdventureWorksContext> _optionsBuilder;
		static void Main(string[] args)
		{
			BuildConfiguration();
			BuildOptions();
			ListPeople();
			//Console.WriteLine($"Cnstr:{_configuration.GetConnectionString("AdventureWorks")}");
		}
		private static void BuildConfiguration()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
			_configuration = builder.Build();
		}
		private static void BuildOptions()
		{
			_optionsBuilder = new DbContextOptionsBuilder<AdventureWorksContext>();
			_optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorks"));
		}
		static void ListPeople()
		{
			using (var db = new AdventureWorksContext(_optionsBuilder.Options))
			{
				var people = db.People.OrderByDescending(x => x.LastName).Take(20).ToList();
				foreach (var person in people)
				{
					Console.WriteLine($"{person.FirstName} {person.LastName}");
				}
			}
		}
	}
}
