/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class MyGeneric<T> {
    T obj;
    public void add(T obj){
        this.obj = obj;
    }

    public T get() {
        return obj;
    }
    
    
}
