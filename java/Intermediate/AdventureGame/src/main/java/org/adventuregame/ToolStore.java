package org.adventuregame;

public class ToolStore  extends NormalLoc{
    public ToolStore(Player player) {
        super(player,"Mağaza");
    }

    @Override
    public boolean onLocation() {
        System.out.println("-------------- Mağzaya hoş geldiniz. --------------------");
        System.out.println("1- Silahlar");
        System.out.println("2- Zırhlar");
        System.out.println("3- Çıkış yap");
        short selectCase=Location.input.nextShort();
        while (selectCase<1 || selectCase>3){
            System.out.println("Geçersiz bir değer girdiniz.Lütfen tekrar giriniz:");
            selectCase= Location.input.nextShort();
        }
        switch (selectCase){
            case 1:
                printWeapon();
                break;
            case 2:
                printArmor();
                break;
            case 3:
                System.out.println("Bir daha bekleriz");
                return true;
        }
        return  true;
    }
    public void printArmor(){
        System.out.println("Zırhlar");
    }
    public void printWeapon(){
        System.out.println("---------- Silahlar -----------------");

        for(Weapon w :Weapon.weapons()){
            System.out.println(w.toString());
        }
    }
    public  void buyWeapon(){
        System.out.print("Bir silah seçiniz:");
        short selectId=Location.input.nextShort();
        while (selectId<1 || selectId>Weapon.weapons().length){
            System.out.print("\nGeçersiz bir değer, lütfen tekrar seçiniz:");
            selectId=Location.input.nextShort();
        }
        Weapon selectedWeapon=Weapon.getWeaponObj(selectId);
        if(selectedWeapon!=null) {
            if (selectedWeapon.getPrice() > this.getPlayer().getMoney()) {
                System.out.println("Yeterli paranız bulunmamaktadır");
            } else {
                System.out.println(selectedWeapon.getName() + " silahını satın aldınız.");
                double ballance = this.getPlayer().getMoney() - selectedWeapon.getPrice();
                this.getPlayer().setMoney(ballance);
                System.out.println("Kalan Paranız:" + this.getPlayer().getMoney());
                System.out.println("Eski silahınız: "+this.getPlayer().getInventory().getWeapon().getName());
                this.getPlayer().getInventory().setWeapon(selectedWeapon);
            }
        }
    }
}
