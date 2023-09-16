package org.example;

import java.util.ArrayList;

public class Enterprise extends Account{
    public Enterprise(User user, ArrayList<Insurance> insurances) {
        super(user, insurances);
    }

    @Override
    public void addInsurancePolicy() {

    }

    @Override
    public int compareTo(Object o) {
        return 0;
    }
}
