package org.adventuregame;
import java.util.Scanner;
public class Game {
	private Scanner input=new Scanner(System.in);
	public void start() {
		System.out.println("Macera oyununa hoşgeldiniz...");
		System.out.print("Lütfen bir isim giriniz:");
		String playerName=input.nextLine();
		Player player=new Player(playerName);
		System.out.println("Sayın "+player.getName()+" hoşgeldiniz...");
		System.out.println("Lütfen bir karakter seçin:");
		player.selectChar();
	}
}
