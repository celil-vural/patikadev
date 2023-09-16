package org.example;

import java.util.ArrayList;

public class Product {
    private int id;
    private String name;
    private Brand brand;
    private Category category;
    private double price;
    private int stock;
    private double discountRate;
    public Product(int id, String name,double price,double discountRate,int stock,Brand brand,Category category) {
        this.id = id;
        this.name = name;
        this.discountRate=discountRate;
        this.brand=brand;
        this.category=category;
        this.stock=stock;
        this.price=price;
    }
    public String getPropertyNames(){
        return "ID,Ürün Adı,Marka,Fiyat,Stok Adedi,Indirim,"+category.getPropertyNames();
    }
    @Override
    public String toString() {
        return id+","+name +","+ brand.getName()+","+price +","+ stock +","+ discountRate+","+category.toString();
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Brand getBrand() {
        return brand;
    }

    public void setBrand(Brand brand) {
        this.brand = brand;
    }

    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }
}
