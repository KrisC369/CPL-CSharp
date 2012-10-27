using System;

namespace Application
{
	public class Employee
	{
		public string FirstName {
			get {
				return _FirstName;
			}
			set {
				_FirstName = value;
			}
		}

		private string _FirstName;

		public string LastName {
			get {
				return _LastName;
			}
			set {
				if (value == null) {
					throw new ArgumentNullException ("value");
				} else {
					_LastName = value;
				}
			}
		}

		private string _LastName;

		// virtual property die read-only is
		public string Name {
			get {
				return FirstName + " " + LastName;
			}
		}

		// property automatisch
		public string City{ get; set; }

		public static string Country = "Belgium";

		// met constructoren spelen
		public Employee (string firstName)
		{
			this.FirstName = firstName;
		}

		public Employee (string firstName, string lastName) : this(firstName)
		{
			this.LastName = lastName;
		}

		public static void Main ()
		{
			Employee e = new Employee ("Tim");
			e.LastName = "Ameye";
			e.City = "Moorsele";
			Console.WriteLine (e.Name);

			var anoniemType = new{
				Title = "Skyfall",
				Bond = "Daniel Craig"
			};

			Console.WriteLine(anoniemType);
		}
	}
}
