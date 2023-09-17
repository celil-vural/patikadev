package org.example;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        List<Book> books = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            String name = "Book " + i;
            int pageCount = i*20;
            String authorName = "Author " + i;
            Date publishDate = new Date();
            books.add(new Book(name, pageCount, authorName, publishDate));
        }
        Map<String,String> map=new HashMap<>();
        books.forEach(b->map.put(b.getName(),b.getAuthorName()));
        List<Book> newBooks=books.stream().filter(b-> b.getPageCount() > 100).toList();
        for (Map.Entry<String, String> entry : map.entrySet()) {
            System.out.println("Key: " + entry.getKey() + ", Value: " + entry.getValue());
        }
        System.out.println("###############################");
        for (Book book : newBooks) {
            System.out.println("Kitap Adı: " + book.getName());
            System.out.println("Sayfa Sayısı: " + book.getPageCount());
            System.out.println("Yazar Adı: " + book.getAuthorName());
            System.out.println("Yayın Tarihi: " + book.getPublishDate());
            System.out.println("--------------");
        }
    }
}