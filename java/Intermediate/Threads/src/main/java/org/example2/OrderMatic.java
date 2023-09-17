package org.example2;

import java.util.Objects;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class OrderMatic implements Runnable{
    private volatile int orderNo;
    //volatile cache verisi yerine işlemciye sordurtur buda bu uygulamada threadlerin garanti olarak değişkenin net değerine ulaşmasını sağlar
    public OrderMatic() {
        this.orderNo =0;
    }
    private final Object LOCK=new Object();
    @Override
    public void run() {
        try {
            Thread.sleep(2000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        /*synchronized (LOCK){
            this.orderNo++;
            System.out.println(Thread.currentThread().getName()+" - Order no => "+this.orderNo);
         } OR
        */
        increaseOrder();
    }
    public synchronized void increaseOrder(){
        this.orderNo++;
        System.out.println(Thread.currentThread().getName()+" - Order no => "+this.orderNo);
    }
    public int getOrderNo() {
        return orderNo;
    }

    public void setOrderNo(int orderNo) {
        this.orderNo = orderNo;
    }
}
