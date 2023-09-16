package org.example;

import java.util.TreeSet;

public class AccountManager {
    private static TreeSet<Account> accounts=new TreeSet<Account>();
    public static Account Login(String email,String password) throws InvalidAuthenticationException {
        for (Account account : accounts) {
            try {
                account.Login(email, password);
                return account;
            } catch (InvalidAuthenticationException e) {}
        }
        throw new InvalidAuthenticationException("Login Failed");
    }
    public void addAccount(Account account){
        accounts.add(account);
    }
    public void removeAccount(Account account){
        accounts.remove(account);
    }
}
