package org.adventuregame;

public class Weapon {
    private int id;
    private double damage;
    private double price;
    private String name;
    public Weapon(String name,int id, double damage, double price) {
        this.id = id;
        this.damage = damage;
        this.price = price;
        this.name=name;
    }
    public static Weapon[] weapons(){

        Weapon[] weapons=new Weapon[]{
                new Weapon("Tabanca",1,2,10),
                new Weapon("Kılıç",2,3,35),
                new Weapon("Tüfek",3,7,45),
        };
        return weapons;
    }

    @Override
    public String toString() {
        return  "Id=" + id +
                ", damage=" + damage +
                ", price=" + price +
                ", name='" + name;
    }
    public static Weapon getWeaponObj(short id){
        for(Weapon w:Weapon.weapons()){
            if(w.id==id){
                return w;
            }
        }
        return null;
    }
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getDamage() {
        return damage;
    }

    public void setDamage(double damage) {
        this.damage = damage;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
}
