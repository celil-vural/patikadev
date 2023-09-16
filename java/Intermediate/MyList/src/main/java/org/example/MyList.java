package org.example;

public class MyList<T> {
    private T[] array;
    private int size=0;
    private int startingLength;
    public MyList(){
        arrayInitialize(10);
        startingLength=10;
    }
    public MyList(int length){
        arrayInitialize(length);
        startingLength=length;
    }
    private void arrayInitialize(int length){
        array=(T[]) new Object[length];
    }
    public void lengthIncrease(){
        int size=array.length*2;
        T[] newArray=(T[]) new Object[size];
        System.arraycopy(array, 0, newArray, 0, array.length);
        array=newArray;
    }
    public int size(){
        return size;
    }
    private void sizeIncrease(){
        size+=1;
        arrayLengthControl();
    }
    private void arrayLengthControl(){
        if(array.length<=size){
            lengthIncrease();
        }
    }
    public T get(int index){
        return array[index];
    }
    private void sizeDecrease(){
        size-=1;
    }
    public T remove(int index){
        if(index>=size || index<0){
            return null;
        }
        T r=array[index];
        for(int i=index;i<size;i++){
            if(i+1==array.length){
                array[i]=null;
                break;
            }
            array[i]=array[i+1];
        }
        sizeDecrease();
        return r;
    }
    public int indexOf(T data){
        int i=0;
        for(T e:array){
            if(e==data){
                return i;
            }
            i++;
        }
        return -1;
    }
    public boolean isEmpty(){
        return size == 0;
    }
    public T[] toArray(){
        T[] newArray=(T[]) new Object[size];
        System.arraycopy(array, 0, newArray, 0, size);
        return newArray;
    }
    public void clear(){
        array=(T[])new Object[startingLength];
        size=0;
    }
    public MyList<T> subList(int start,int finish){
        if(finish<start || start<0 || finish>size){
            return new MyList<>(0);
        }
        MyList<T> sub=new MyList<>(finish-start);
        for(int i=start;i<=finish;i++){
            sub.add(array[i]);
        }
        return sub;
    }
    public boolean contains(T data){
        int c=indexOf(data);
        return c!=-1;
    }
    public int lastIndexOf(T data){
        for(int i=array.length-1;i>=0;i--){
            if(array[i]==data){
                return i;
            }
        }
        return -1;
    }
    public T set(int index, T data){
        if(index<0 || index>=size){
            return null;
        }
        T old=array[index];
        array[index]=data;
        return old;
    }
    @Override
    public String toString(){
        String s= "[";
        for(int i=0;i<size;i++){
            s+=array[i].toString();
            if(i!=size-1)
                s+=",";
        }
        s+="]";
        return s;
    }
    public int getCapacity(){
        return  array.length;
    }
    public void add(T data){

        array[size]=data;
        sizeIncrease();
    }
}
