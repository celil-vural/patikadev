package org.adventuregame;

import java.util.Scanner;

public class Player {
	private GameCharacter gameCharacter;
	private String name;
	private String charName;
	private Scanner input=new Scanner(System.in);
	public Player(String name) {
		this.name=name;
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
