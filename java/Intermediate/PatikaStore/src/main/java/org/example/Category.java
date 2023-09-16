package org.example;

import java.util.ArrayList;

public class Category {
    public int id;
    public String name;
    public Category(int id, String name) {
        this.id = id;
        this.name = name;
    }
    public String getPropertyNames(){
        return "Name";
    }
}
