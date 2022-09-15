/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot2;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class DoubleLinkedList {

    
    Node2 head, tail;
    Scanner sc = new Scanner(System.in);

    void addHead(Node2 x) {
        if(head == null) {
            head = tail = x;
        }else{
            x.next = head;
            head.prev = x;
            head = x;
        }
    }

    void addTail(Node2 x) {
        if(head == null) {
            head = tail = x;
        }else{
            tail.next = x;
            x.prev = tail;
            tail = x;
        }
    }

    void display() {
        Node2 p = head;
        while(p != null){
            System.out.print(p.inf + " ");
            p = p.next;
        }
        System.out.println("");
    }
    
    int get(int index){
        int curPos = 0;
        Node2 p = head;
        while (p != null) {
            if(curPos == index){
                return p.inf;
            }else{
                curPos++;
                p = p.next;   
            }
        }
        return -1;
 
    }
    
    void set(int index, int val){
        int curPos = 0;
        Node2 p = head;
        while (p != null ) {
            if(curPos == index){
                p.inf = val;
                return;
            }else{
                p = p.next;
                curPos++;
            }
        }
        
    }
    
    void delete(int index){
        int curPos = 0;
        Node2 p = head;
        while (p.next != null) {  
            if(curPos == index){
                if (p == head) {
                    head = head.next;
                    head.prev = null;
                } else if (p == tail) {
                    tail = tail.prev;
                    tail.next = null;
                } else {
                    p.prev.next = p.next;
                    p.next.prev = p.prev;
                }
                return;
            }else{
                curPos++;
                p = p.next;
            }
        }
        
    }
}
