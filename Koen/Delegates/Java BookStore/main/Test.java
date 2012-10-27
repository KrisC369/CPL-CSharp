package main;

import bookStore.Book;
import bookStore.BookDB;
import bookStore.Delegate;

// Class to test the bookstore classes.
public class Test {

	// Print the title of the book.
	private static Delegate printTitle = new Delegate() {
		public void processBook(Book b) {
			System.out.println(b.title);
		}
	};

	// Execution starts here.
	public static void main(String[] args) {
		BookDB bookDB = new BookDB();

		// Initialize the database with some books.
		addBooks(bookDB);

		// Print all the titles of paperbacks:
		System.out.println("Paperback Book Titles:");

		// Create a new delegate object associated with the static
		// object Test.printTitle:
		bookDB.processPaperbackBooks(printTitle);

		// Get the average price of a paperback by using
		// a PriceTotaller object:
		final PriceTotaller totaller = new PriceTotaller();
		
		// Create a new delegate object associated with the nonstatic
		// method AddBookToTotal on the object totaller: 
		// TODO dit is ook anders in java.
		bookDB.processPaperbackBooks(new Delegate() {
			public void processBook(Book b) {
				totaller.addBookTotal(b);
			}
		});
		
		System.out.printf("Average Paperback Book Price: " + 
				totaller.averagePrice());
	}

	// Initialize the book database with some test books:
	private static void addBooks(BookDB bookDB) {
		bookDB.addBook("The C Programming Language",
				"Brian W. Kernighan and Dennis M. Ritchie", 19.95, true);
		bookDB.addBook("The Unicode Standard 2.0", "The Unicode Consortium",
				39.95, true);
		bookDB.addBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95, false);
		bookDB.addBook("Dogbert's Clues for the Clueless", "Scott Adams",
				12.00, true);
	}
}
