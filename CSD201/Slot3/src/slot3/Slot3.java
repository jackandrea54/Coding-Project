/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot3;

import java.util.EmptyStackException;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Slot3 {

    public static void main(String[] args) {
        myStack stack = new myStack();
        stack.push(15);
        stack.push(18);
        stack.push(20);
        stack.push(120);
        stack.push(123);
        stack.push(2811);
        stack.push(287);
        stack.push(22);
        stack.push(13);
        stack.display();
        System.out.println("Pop: " + stack.pop());
        stack.display();
        System.out.println("The position of 120: "+ stack.search(120));
        
        //Transfer all stack to st2;
        myStack st2 = new myStack();
        st2.transfer(stack, st2);
        st2.display();
       
    }
}

class myStack {

    Scanner sc = new Scanner(System.in);
    Node top;

    public myStack() {

    }
    
    /**
     * This function check if the stack is empty or not
     * @return <code> true </code> if the stack is empty 
     *  ,<code> false </code> otherwise
     */
    
    boolean empty() {
        return top == null;
    }

    Integer peek() throws EmptyStackException{
        
        try {
            if (empty()) {
                throw new EmptyStackException();
            } else {
                return top.inf;
            }
        } catch (Exception e) {
            System.out.println("The stack is empty");
            return null;
        }
    }

    void push(Integer x) {
        top = new Node(x, top);
    }

    Integer pop() throws EmptyStackException{
        try {
            if (empty()) {
                throw new EmptyStackException();
            } else {                
                Integer val = top.inf;
                top = top.next;
                return val;
            }
        } catch (Exception e) {
            System.out.println("The stack is empty");
            return null;
        }
    }

    void display() {
        Node p = top;
        if (empty()) {
            System.out.println("The stack is empty");
        } else {
            System.out.println("The stack: ");
            while (p != null) {
                System.out.print(p.inf + " ");
                p = p.next;
            }
            System.out.println("");
        }
    }

    int search(Integer x) {
        if (empty()) {
            System.out.println("The stack is empty");
        }
        else{
            
            Node p = top;
            int pos = 0;
            while(p!= null){
                if (p.inf.equals(x)) {
                    return pos;
                }
                else{
                    p = p.next;
                    pos++;
                }
            }
        
        }
        return -1;
    }
    
    void transfer(myStack st1, myStack st2){
        if(st1.empty()){
            return;
        }else{
            Node p = st1.top;
            while (p != null) {    
                st2.push(p.inf);
                p = p.next;             
            }
        }
        
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
