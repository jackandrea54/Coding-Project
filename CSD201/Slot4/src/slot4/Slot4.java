/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot4;

import java.util.EmptyStackException;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Slot4 {

    public static void main(String[] args) {
        myqueue queue = new myqueue();
        queue.enqueue(10);
        queue.enqueue(12);
        queue.enqueue(2);
        queue.enqueue(30);
        queue.enqueue(609);
        queue.display();
        System.out.println("Dequeue: " + queue.dequeue());
        System.out.println("Front: " + queue.front());
        queue.display();
        queue.clear();
        queue.display();
    }
}

class myqueue {

    Scanner sc = new Scanner(System.in);
    Node head;

    public myqueue() {

    }

    boolean empty() {
        return head == null;
    }

    Integer front() throws EmptyStackException{
        try {
            if (empty()) {
                throw new EmptyStackException();
            } else {
                return head.inf;
            }
        } catch (Exception e) {
            System.out.println("The queue is empty");
            return null;
        }
    }

    void enqueue(Integer x) {
        Node p = head;
        if(empty()){
            head = new Node(x);
        }else{
            while(p.next != null){
                p = p.next;
            }
            p.next = new Node(x);
        }
        
    }

    Integer dequeue() throws EmptyStackException{
        try {
            if (empty()) {
                throw new EmptyStackException();
            } else {                
                Integer val = head.inf;
                head = head.next;
                return val;
            }
        } catch (Exception e) {
            System.out.println("The queue is empty");
            return null;
        }
    }

    void display() {
        Node p = head;
        if (empty()) {
            System.out.println("The queue is empty");
        } else {
            System.out.println("The queue: ");
            while (p != null) {
                System.out.print(p.inf + " ");
                p = p.next;
            }
            System.out.println("");
        }
    }
    
    void clear(){
//        head = null;        
        Node tmp = head;
        while(head.next != null){
            tmp = head.next;
            head.next = null;
            head = tmp;
            display();
        }
        head = null;
    }
  

    
}

class Node {

    Integer inf;
    Node next;

    public Node() {
    }

    public Node(int x) {
        inf = x;
    }

    public Node(int x, Node p) {
        inf = x;
        next = p;
    }
}
