/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws3;

/**
 *
 * @author ADMIN
 */
public class Book {
    private String author;
    private String title;
    private int noOfPages;
    private boolean fiction;

    public Book(String author, String title, int noOfPages, boolean fiction) {
        this.author = author;
        this.title = title;
        this.noOfPages = noOfPages;
        this.fiction = fiction;
    }

    
    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public int getNoOfPages() {
        return noOfPages;
    }

    public void setNoOfPages(int noOfPages) {
        this.noOfPages = noOfPages;
    }

    public boolean isFiction() {
        return fiction;
    }

    public void setFiction(boolean fiction) {
        this.fiction = fiction;
    }
}

class Main{
    public static void main(String[] args) {
        Book book1 = new Book("Nguyen Nhat Anh","Mat biec",2009,false);
        System.out.println("BOOK1:\nAuthor: " + book1.getAuthor() + ", Book title: "+ book1.getTitle()+", Number of pages: "+book1.getNoOfPages()+ ", Fictional: "+book1.isFiction());
        
        book1.setAuthor("Nguyen Dinh Nghia");
        book1.setNoOfPages(2003);
        book1.setTitle("Life of Jack");
        System.out.println("BOOK1:\nAuthor: " + book1.getAuthor() + ", Book title: "+ book1.getTitle()+", Number of pages: "+book1.getNoOfPages()+ ", Fictional: "+book1.isFiction());

    }
}

