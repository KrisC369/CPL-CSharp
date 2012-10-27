package bookStore;
// Boek klasse.
public class Book {
	
	public String title;		// Title of the book
	public String author;		// Author of the book
	public double price;		// Price of the book
	public boolean paperback;	// Is it paperback?
	
	public Book(String title, String author, double price, boolean paperback) {
		this.title = title;
		this.author = author;
		this.price = price;
		this.paperback = paperback;
	}
}
