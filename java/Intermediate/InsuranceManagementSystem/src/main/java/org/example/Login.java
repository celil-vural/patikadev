package org.example;

import java.util.Objects;

public class Login {
    public static Account Login(){
        while (true){
            try{
                System.out.print("Email: ");
                String email=Main.input.nextLine();
                System.out.print("\nPassword:");
                String password=Main.input.nextLine();
                Account account=AccountManager.Login(email,password);
                if (account != null) {
                    continue;
                }
                return account;
            }
            catch (InvalidAuthenticationException e){
                System.out.println("Email or Password is not correct... ");
            }
        }
    }
}
