package org.example2;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Main {
    public static void main(String[] args){
       try {
           OrderMatic o1=new OrderMatic();
           List<Thread> threads=new ArrayList<>();
           ExecutorService pool= Executors.newFixedThreadPool(100); //Bizim için 100 tanelik thread havuzu oluşturdu
           for(int i=0;i<100;i++){
               /*Thread t=new Thread(o1);
               threads.add(t);
               t.start(); Havuzdan önce*/
               pool.execute(o1);
           }
           for(Thread t:threads){
               t.join();
           }
           pool.close();
           System.out.println(o1.getOrderNo());
       }
       catch (Exception e){
           System.out.println(e.getMessage());
       }
    }
}
