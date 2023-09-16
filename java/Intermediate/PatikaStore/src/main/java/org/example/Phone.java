package org.example;

import java.util.ArrayList;

public class Phone extends Category{
    private int storage;
    private double screenSize;
    private double battery;
    private int ram;
    private String color;
    private int categorId=0;
    public Phone(int storage, double screenSize, double battery, int ram, String color) {
        super(0, "Phone");
        this.storage = storage;
        this.screenSize = screenSize;
        this.battery = battery;
        this.ram = ram;
        this.color = color;
    }
    public Phone(){
        super(0,"Phone");
    }

    @Override
    public String toString() {
        return storage+","+screenSize+","+battery+","+ram+","+color;
    }
    public String getPropertyNames(){
        return "Storage,Ekran,Pil,Ram,Renk";
    }
}
