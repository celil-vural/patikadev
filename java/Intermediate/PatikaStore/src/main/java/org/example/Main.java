package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    static List<Brand> brands=new ArrayList<Brand>();
    static List<Category> categories=new ArrayList<Category>();
    static List<Product> products = new ArrayList<Product>();
    static Scanner input=new Scanner(System.in);
    public static void main(String[] args) {
        brands.add(new Brand(0,"Samsung"));
        brands.add(new Brand(1,"Lenovo"));
        brands.add(new Brand(2,"Apple"));
        brands.add(new Brand(3,"Huawei"));
        brands.add(new Brand(4,"Casper"));
        brands.add(new Brand(5,"Asus"));
        brands.add(new Brand(6,"HP"));
        brands.add(new Brand(7,"Xiaomi"));
        brands.add(new Brand(8,"Monster"));
        categories.add(new Phone());
        categories.add(new Notebook());
        Category c=new Phone(128,6.5,4000.0,6,"Siyah");
        Category c1=new Phone(64,6.1,3046.0,6,"Mavi");
        Category c2=new Phone(128,6.5,4000.0,12,"Beyaz");
        products.add(new Product(0,"SAMSUNG GALAXY A51",3199.0,0,10,brands.get(0),c));
        products.add(new Product(1,"iPhone 11 64 GB",7379.0,0,10,brands.get(2),c1));
        products.add(new Product(2,"Redmi Note 10 Pro 8GB",4012.0,0,10,brands.get(7),c2));
        c=new Notebook(16,512,14.0);
        c1=new Notebook(8,1024,14.0);
        c2=new Notebook(32,2048,15.6);
        products.add(new Product(3,"HUAWEI Matebook 14",7000.0,0,10,brands.get(3),c));
        products.add(new Product(4,"LENOVO V14 IGL",3699.0,0,10,brands.get(1),c1));
        products.add(new Product(5,"ASUS Tuf Gaming",8199.0,0,10,brands.get(5),c2));
        printPanel();
    }
    private static void printPanel(){
        System.out.println("PatikaStore Ürün Yönetim Paneli!");
        short i=1;
        while(i<=categories.size()){
            System.out.println(i+" - "+((Category)categories.get(i-1)).name + " İşlemleri");
            i++;
        }
        System.out.println(i+" - Marka Listeleme");
        System.out.println("0 - Çıkış Yap");
        toSelect(i);
    }
    private static void toSelect(short i){
        short select=input.nextShort();
        while(select>i || select<0){
            System.out.println("Hatalı tuşladınız, lütfen tekrar deneyiniz:");
            select=input.nextShort();
        }
        selectCase(select);
    }
    private static void selectCase(short select){
        if(select==0){
            System.out.println("Çıkış Yapılıyor...");
        }
        else if(select==categories.size()+1){
            printBrands();
        }
        else{
            printCategoryProducts(categories.get(select-1));
        }
        System.out.println("####################");
        printPanel();
    }
    private static void printCategoryProducts(Category category){
        ArrayList<Product> products1=new ArrayList<Product>();
        for(Product p:products){
            if(p.getCategory().id==category.id){
                products1.add(p);
            }
        }
        printProducts(products1);
    }
    private static void printProducts(ArrayList<Product> products1){
        String forFormatArray=products1.get(0).getPropertyNames();
        Object[] formatArray=forFormatArray.split(",");
        StringBuilder format= new StringBuilder("| %-2s | %-30s");
        for(int i=2;i<formatArray.length;i++){
            format.append("| %-10s ");
        }
        format.append("|%n");
        printTableFooter();
        System.out.format(format.toString(),formatArray);
        printTableFooter();
        for(Product p : products1){
                printProduct(p,format.toString());
        }
        printTableFooter();
        printPanel();
    }
    public static void printTableFooter() {
        int tableWidth = 98;
        String horizontalLine = new String(new char[tableWidth]).replace('\0', '-');
        System.out.println(horizontalLine);
    }
    public static void printProduct(Product product,String format) {
        System.out.format(format,product.toString().split(","));
    }
    private static void printBrands(){
        System.out.println("Markalarımız");
        System.out.println("-----------------------");
        for(Brand b:brands){
            System.out.println("- "+b.getName());
        }
    }
}