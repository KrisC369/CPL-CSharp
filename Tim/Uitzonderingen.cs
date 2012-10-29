using System;

namespace Application
{
	[Serializable]
	class MyCrazySerializableException : System.Exception
	{
		public MyCrazySerializableException ()
		{
		}
	}

	public class Uitzonderingen
	{
		public static string something (string txt)
		{
			if (txt == null) {
				throw new ArgumentNullException ("Argument cannot be null");
			} else if (txt == "") {
				throw new ArgumentException ("Argument cannot be the empty string");
			} else {
				return "nu gaat het wel";
			}
		}

		public static void Main (string[] args)
		{
			try {
				Uitzonderingen.something (null);
				//Uitzonderingen.something ("");
			} catch (ArgumentNullException e) {
				Console.WriteLine ("gevangen null!");
			} catch (ArgumentException e) {
				Console.WriteLine ("gevangen empty string!");
			} catch {
				Console.WriteLine ("er gebeurd iets verkeerd, maar we weten niet wat");
			} finally {
				// cleanup the mess
			}

			// overflow proberen
			int n1 = int.MaxValue;
			n1++;
			Console.WriteLine (n1); // dit werk en is een fout resultaat

			checked {
				int n2 = int.MaxValue;
				n2 = n2 + 1;
				System.Console.WriteLine (n2); // nu gaat dit wel een foutmelding geven
			}
		}
	}
}

