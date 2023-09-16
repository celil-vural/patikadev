package org.example;

public class HealthInsurance extends Insurance{
    @Override
    double calculate() {
        System.out.println("Health Insurance Calculating...");
        return 0;
    }
}
