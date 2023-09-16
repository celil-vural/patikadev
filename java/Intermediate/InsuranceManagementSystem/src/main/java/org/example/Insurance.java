package org.example;

import java.util.Date;

public abstract class Insurance {
    String insuranceName;
    double insurancePrice;
    Date insuranceStartDate;
    Date insuranceEndDate;
    abstract double calculate();
}
