package bo;


import entity.Node;
import entity.student;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author thangnv
 */
public class listStudent {
    Node head,tail;
    public boolean isEmpty(){
        return head==null;
    }
    public void addHead(student sv){
        if (isEmpty()) {
            head = tail = new Node(sv);
        }else{
            head = new Node(sv, head);
        }
    }
    public void addTail(student sv){
        if (isEmpty()) {
            head = tail = new Node(sv);
        }else{
            tail.next = new Node(sv);
            tail = tail.next;
        }
    }
    public void insert(student sv, int index){
        
    }
    public int getIndex(String  Rollnum){
        int index=0;
        return index;
    }
    public void remove(int index){
        if (isEmpty()) {
            System.out.println("The list is empty");
        }else{
            Node p = head;
            if (index == 0) {
                head = head.next;
            } else {
                int count = 1;
                while (p.next != null && count != index){
                    p = p.next;
                    count++;
                }
                if (p.next != null) {
                    p.next = p.next.next;
                }
            }
        }
    }
    public void remove(String Rollnum) {
        if (isEmpty()) {
            System.out.println("The list is empty");
        }else{
            Node p = head;
            if (p.inf.Rollnumber.equals(Rollnum)) {
                head = head.next;
                p = null;
            } else {
                while (p.next != null && !(p.next.inf.Rollnumber.equals(Rollnum))) {
                    p = p.next;
                }
                
                if (p.next != null) {
                    p.next = p.next.next;
                }
            }
        }
        
    }
    public void display(){
        if (isEmpty()) {
            System.out.println("The list is empty");
        }else{
            Node p = head;
            System.out.println("-----------------------------------------");
            while (p != null) {                
                System.out.println(p.toSring());
                p = p.next;
            }
        }
    }
    
    public void listPEStudent(){
        //list all student can take PE   
        if (isEmpty()) {
            System.out.println("The list is empty");
        } else {
            Node p = head;
            while (p != null) {
                if (p.inf.As1 > 0 && p.inf.As2 > 0 && p.inf.Pt1 > 0 && p.inf.Pt2 > 0 && p.inf.AT <= 20.0) {
                    System.out.println(p.toSring());
                }
                p = p.next;
            }
        }
    }
    
     public void takeExam(){
      
    }
     
     public void clear(){
         head = tail = null;
     }
}
