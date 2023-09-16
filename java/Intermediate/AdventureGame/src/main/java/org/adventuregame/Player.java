package org.adventuregame;

import java.util.Scanner;

public class Player {
	private GameCharacter gameCharacter;
	private String name;
	private Inventory inventory;
	private String charName;
	private double money;
	private double damage;
	private double health;
	private Scanner input=new Scanner(System.in);
	public Player(String name) {

		this.name=name;
		this.inventory=new Inventory();
	}
	public void selectChar() {
		GameCharacter[] charList= {new Samurai(),new Knight(),new Archer()};
		System.out.println("#######################");
		for(GameCharacter c:charList) {
			System.out.println(c.toString());
		}
		System.out.println("-------------------------");
		System.out.println("Lütfen bir karakter giriniz:");
		short selectChar=input.nextShort();
		if(selectChar<1 || selectChar>charList.length) this.selectChar();
		gameCharacter=charList[selectChar-1];
		System.out.println(gameCharacter.toString());
		this.setMoney(gameCharacter.getMoney());
		this.setHealth(gameCharacter.getHealth());
		this.setDamage(gameCharacter.getDamage());

	}

	public double getMoney() {
		return money;
	}

	public double getDamage() {
		return damage+this.inventory.getWeapon().getDamage();
	}

	public void setDamage(double damage) {
		this.damage = damage;
	}

	public void printPlayerInfo(){
		System.out.println("Silah: "+this.inventory.getWeapon().getName()
				+"\nHasarınız:"+this.getDamage()
				+"\nSağlık:"+this.getHealth()
				+"\nPara:"+this.getMoney()
		);
	}
	public void setMoney(double money) {
		this.money = money;
	}

	public double getHealth() {
		return health;
	}

	public void setHealth(double health) {
		this.health = health;
	}

	public Inventory getInventory() {
		return inventory;
	}

	public void setInventory(Inventory inventory) {
		this.inventory = inventory;
	}

	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getCharName() {
		return charName;
	}
	public void setCharName(String charName) {
		this.charName = charName;
	}


}
