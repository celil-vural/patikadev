package org.example;

import java.util.Comparator;
import java.util.Date;
import java.util.Set;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        // Kitap nesneleri oluşturun
        Book book1 = new Book("C Programming", 200, "John Smith", new Date(2023, 9, 15));
        Book book2 = new Book("Java Programming", 350, "Alice Johnson", new Date(2023, 9, 10));
        Book book3 = new Book("Python Programming", 250, "Bob Brown", new Date(2023, 9, 20));
        Book book4 = new Book("Android Development", 300, "Mary Davis", new Date(2023, 9, 5));
        Book book5 = new Book("Web Development", 400, "David Lee", new Date(2023, 9, 25));

        // Kitapları Set'te saklayın ve isme göre sıralayın
        Set<Book> bookSetByName = new TreeSet<>();
        bookSetByName.add(book1);
        bookSetByName.add(book2);
        bookSetByName.add(book3);
        bookSetByName.add(book4);
        bookSetByName.add(book5);

        System.out.println("Kitaplar İsim Sırasına Göre:");
        for (Book book : bookSetByName) {
            System.out.println(book.getName());
        }
        // Kitapları sayfa sayısına göre sıralamak için Comparator kullanın
        Comparator<Book> sortByPageCount = Comparator.comparingInt(Book::getPageCount);
        Set<Book> bookSetByPageCount = new TreeSet<>(sortByPageCount);
        bookSetByPageCount.add(book1);
        bookSetByPageCount.add(book2);
        bookSetByPageCount.add(book3);
        bookSetByPageCount.add(book4);
        bookSetByPageCount.add(book5);

        System.out.println("\nKitaplar Sayfa Sayısına Göre:");
        for (Book book : bookSetByPageCount) {
            System.out.println(book.getName());
        }
    }
}