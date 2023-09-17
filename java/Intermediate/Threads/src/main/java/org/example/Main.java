package org.example;

public class Main {
    public static void main(String[] args) {
        Counter c1=new Counter();
        Counter c2=new Counter();
        c1.start();
        c2.start();
        Counter2 c3=new Counter2();
        Counter2 c4=new Counter2();
        Thread t3=new Thread(c3);
        Thread t4=new Thread(c4);
        c3.setName(t3.getName());
        c4.setName(t4.getName());
        t3.start();
        c3.stop();
        t4.start();
    }
}