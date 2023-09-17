package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Main {
    public static void main(String[] args) {
        List<Integer> numbers=new ArrayList<>();
        for(int i=1;i<=10000;i++){
            numbers.add(i);
        }
        int chunkSize = numbers.size() / 4;
        List<List<Integer>> chunks = new ArrayList<>();
        for (int i = 0; i < 4; i++) {
            int start = i * chunkSize;
            int end = (i + 1) * chunkSize;
            if (i == 3) {
                end = numbers.size();
            }
            chunks.add(numbers.subList(start, end));
        }
        ExecutorService executorService = Executors.newFixedThreadPool(4);
        List<Integer> evenNumbers = new ArrayList<>();
        List<Integer> oddNumbers = new ArrayList<>();
        final Object LOCK=new Object();
        for (int i = 0; i < 4; i++) {
            final List<Integer> chunk = chunks.get(i);
            executorService.submit(() -> {
                for (Integer number : chunk) {
                    synchronized (LOCK){
                        if (number % 2 == 0) {
                            evenNumbers.add(number);
                        } else {
                            oddNumbers.add(number);
                        }
                        System.out.println(Thread.currentThread().getName());
                    }
                }
            });
        }

        executorService.shutdown();
        while (!executorService.isTerminated()) {

        }
        System.out.println("Çift Sayılar: " + evenNumbers.size());
        System.out.println("Tek Sayılar: " + oddNumbers.size());

    }
}