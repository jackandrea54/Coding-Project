//hash table
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author thangnv
 */
public class Hashtable {
       Node hashArray[] ;
       int size;
       

    public Hashtable() {
    }

    public Hashtable(int size) {
        this.size = size;
        hashArray = new Node[size];
//        for (int i = 0; i < size; i++) {
//            hashArray[i] = null;
//        }
        
    }
          
   
    public int hashfunc(int key){
        return key%size;
    }
    
    public void insert(int key,Object value){
        int index = hashfunc(key);
        if (hashArray[index]==null){
            hashArray[index]  = new Node(key,value);
            return;
        }
//        Node newNode = new Node(key,value);
//        newNode.next=hashArray[index];
//        hashArray[index] = newNode;
        hashArray[index] = new Node(key,value, hashArray[index]);
    }
    
    public Node getValue(int key){
        
        int index = hashfunc(key);
        
        if (hashArray[index]==null) {            
            return null;
        }
        while (hashArray[index]!=null){
            if (hashArray[index].key==key)
                 return hashArray[index];
            hashArray[index]=hashArray[index].next;
        }
       return null;
    }
    public static void main(String[] args) {
        int size=11;
        Hashtable hm = new Hashtable(size);
//        for (int i = 0; i < 50; i++) {
//            hm.insert("Line "+i, hm.hashfunc("Line "+i));
//        }
        hm.insert(1,"Nguyen Van Thang");
        hm.insert(12,"Nguyen Van Bao");
        hm.insert(3,"Nguyen Van Anh");
        for (int i = 0; i < size; i++) {
            int count=0;
            while (hm.hashArray[i]!=null) {
                count++;
                System.out.print ("indx = "+hm.hashfunc(i)+" "+ hm.hashArray[i].key+" = "+ hm.hashArray[i].val);
                hm.hashArray[i]=hm.hashArray[i].next;
            }
            System.out.println("");
//            System.out.println("len "+i+" "+count);
        }
    }
    
}
class Node {   
    int key;
    Object val;
    Node next;

    public Node() {
    }

    public Node(int key,Object val, Node next) {
        this.key=key;
        this.val = val;
        this.next = next;
    }
     public Node(int key,Object val ) {
        this.val = val;
         this.key=key;
        this.next = null;
    }
}