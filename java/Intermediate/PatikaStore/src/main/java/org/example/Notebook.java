package org.example;

import java.util.ArrayList;

public class Notebook extends Category{
    private int ram;
    private int storage;
    private double screenSize;
    private  int cateGoryId=1;

    public Notebook(int ram, int storage, double screenSize) {
        super(1, "Notebook");
        this.ram = ram;
        this.storage = storage;
        this.screenSize = screenSize;
    }
    public String getPropertyNames(){
        return "Storage,Ekran,Ram";
    }

    @Override
    public String toString() {
        return storage+","+screenSize+","+ram;
    }
    public Notebook(){
        super(1, "Notebook");
    }
}
