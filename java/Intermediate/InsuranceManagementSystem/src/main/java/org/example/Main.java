package org.example;

import java.util.Scanner;

public class Main {
    static Scanner input=new Scanner(System.in);
    static short selectedOption;
    public static void printHastag(){
        System.out.println("########################################");
    }
    public static void main(String[] args) {
        //Individual ve Enterprise hesaplar oluşturup bunları AccountManager.accounts ta tut
        printHastag();
        System.out.println("Welcome to Insurance Management System");
        printHastag();
        Account account;
        selectedOption=startPage();
        account=getAccount(selectedOption);
        if(account == null) return;
    }
    public static void printLoginedUserPanel(Account account){
        printHastag();
        System.out.println("Welcome "+account.getUser().getName());

    }
    public static Account getAccount(short selectedOption){
        switch (selectedOption){
            case 1:
                return Login.Login();
            case 2:
                return Register.Register();
            case 3:
                return null;
        }
    }
    public static short startPage(){
        while(true){
            System.out.println();
            printHastag();
            System.out.println("Options");
            System.out.println("1-Login");
            System.out.println("2-Register");
            System.out.println("3-Exit");
            short selectedOption=input.nextShort();
            if(selectedOption<4 && selectedOption>0) return selectedOption;
            System.out.println("You selected the wrong option, please select again");
        }
    }
}