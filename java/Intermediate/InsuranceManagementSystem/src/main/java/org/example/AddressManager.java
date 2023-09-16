package org.example;

import java.util.ArrayList;

public class AddressManager {
    public static void addAddress(Address address,User user){
        ArrayList<Address> addressList= user.getAdressList();
        addressList.add(address);
        user.setAdressList(addressList);
    }
    public static void removeAddress(Address address,User user){

    }
}
