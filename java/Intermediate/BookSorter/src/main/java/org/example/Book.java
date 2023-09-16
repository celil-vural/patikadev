package org.example;

import java.util.Date;

public class Book implements Comparable<Book>{
    private String name;
    private int pageCount;
    private String authorName;
    private Date releaseDate;

    public Book(String name, int pageCount, String authorName, Date releaseDate) {
        this.name = name;
        this.pageCount = pageCount;
        this.authorName = authorName;
        this.releaseDate = releaseDate;
    }
    @Override
    public int compareTo(Book otherBook) {
        return this.name.compareTo(otherBook.name);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getPageCount() {
        return pageCount;
    }

    public void setPageCount(int pageCount) {
        this.pageCount = pageCount;
    }

    public String getAuthorName() {
        return authorName;
    }

    public void setAuthorName(String authorName) {
        this.authorName = authorName;
    }

    public Date getReleaseDate() {
        return releaseDate;
    }

    public void setReleaseDate(Date releaseDate) {
        this.releaseDate = releaseDate;
    }
}
