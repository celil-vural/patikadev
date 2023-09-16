package org.example;

import java.util.ArrayList;
import java.util.Objects;

public abstract class Account implements Comparable{
     private User user;
     private AuthenticationStatus authenticationStatus=AuthenticationStatus.FAIL;
     private ArrayList<Insurance> insurances;

    public Account(User user, ArrayList<Insurance> insurances) {
        this.user = user;
        this.insurances = insurances;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public AuthenticationStatus getAuthenticationStatus() {
        return authenticationStatus;
    }

    public void setAuthenticationStatus(AuthenticationStatus authenticationStatus) {
        this.authenticationStatus = authenticationStatus;
    }

    public ArrayList<Insurance> getInsurances() {
        return insurances;
    }

    public void setInsurances(ArrayList<Insurance> insurances) {
        this.insurances = insurances;
    }

    public void Login(String email, String password) throws InvalidAuthenticationException {
        if(Objects.equals(user.getEmail(), email) && Objects.equals(user.getPassword(), password)){
            authenticationStatus=AuthenticationStatus.SUCCESS;
        }
        else{
            authenticationStatus=AuthenticationStatus.FAIL;
            throw new InvalidAuthenticationException("Login Failed");
        }
    }
    public boolean isLogin(){
        return authenticationStatus==AuthenticationStatus.SUCCESS;
    }
    public abstract void addInsurancePolicy();
    public void addAddress(Address address){
        AddressManager.addAddress(address,user);
    }
    public void removeAddress(Address address){
        AddressManager.removeAddress(address,user);
    }
    final void showUserInfo(){
        System.out.println(user.toString());
    }
}
