package main;

import bookStore.Book;

// Class to total and average price of books.
public class PriceTotaller {
	int countBooks = 0; 
	double priceBooks = 0.0;
	
	void addBookTotal(Book book) {
		countBooks++;
		priceBooks += book.price;
	}
	
	double averagePrice() {
		return priceBooks / countBooks;
	}
	
}
