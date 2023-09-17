package org.example;

public class Counter2 implements Runnable {
    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    private boolean isRun=true;
    @Override
    public void run() {
        for (int i=0;i<1000;i++){
            if(!isRun) break;
            System.out.println(name+" : "+i);
        }
    }
    public void stop(){
        this.isRun=false;
    }
}
