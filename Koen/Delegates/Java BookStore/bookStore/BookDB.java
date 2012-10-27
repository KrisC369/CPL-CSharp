package bookStore;
import java.util.ArrayList;

// Maintains a book database
public class BookDB {
	
	// List of all books in the database
	ArrayList<Book> list = new ArrayList<Book>();
	
	// Add a book to the database
	public void addBook(String title, String author, double price, boolean paperback) {
		list.add(new Book(title, author, price, paperback));
	}
	
	// Call a passed-in delegate on each paperback book to process it.
	public void processPaperbackBooks(Delegate delegate) {
		for(Book b : list) {
			if(b.paperback) 
				// Calling the delegate
				delegate.processBook(b);
		}
	}
}
