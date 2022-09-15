/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot1;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Test1{
    public static void main(String[] args) {
        myList list = new myList();
        list.add(new Node(15));
        list.add(new Node(18));
        list.add(new Node(25));
        list.display();
        list.insert(new Node(20));
        list.display();
    }
}

class myList {
    Scanner sc = new Scanner(System.in);
    Node root;

    public myList() {

    }
    
    void sort(){
        
    }
    void insert(Node x){
        System.out.print("Nhap vi tri muon insert: ");
        int insertPos = Integer.parseInt(sc.nextLine());
//        int insertPos = 2;
        if(root == null){
            root = x;
        }else{
            Node p = root;
            int curPos = 1;
            while(p.next != null && curPos < insertPos - 1){
                curPos++;
            }
            x.next = p.next;
            p.next = x;
            
        }
        
    }

    void add(Node x) {
        if (root == null) {
            root = x;
        } else {
            Node p = root;
            while (p.next != null) {
                p = p.next;
            }
            p.next = x;
        }
    }

    void remove(int x) {
        Node p = root;
        if (root.inf == x) {
            root = root.next;
        } else {
            while (p.next.inf != x) {
                p = p.next;
            }
            if (p.next != null) {
                p.next = p.next.next;
            }
        }

    }
    
    void display(){
        Node p = root;
        while (p != null) {
            System.out.print(p.inf + " ");
            p = p.next;
        }
    }
}

class Node {

    int inf;
    Node next;

    public Node() {
    }
    public Node(int x){
        inf = x;
    }

    public Node(int x, Node p) {
        inf = x;
        next = p;
    }
}
