/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot4_2;

import java.util.EmptyStackException;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
// PRIORITY queue
public class Slot4_2 {

    public static void main(String[] args) {
        myQueue queue = new myQueue();
        queue.enqueue(10);
        queue.enqueue(12);
        queue.enqueue(2);
        queue.enqueue(30);
        queue.enqueue(609);
        queue.enqueue(32);
        queue.enqueue(119);
        queue.enqueue(28);
        queue.display();

    }
}

class myQueue {

    Scanner sc = new Scanner(System.in);
    Node head;

    public myQueue() {

    }

    boolean empty() {
        return head == null;
    }

    Integer front() throws EmptyStackException {
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
        if (empty()) {
            head = new Node(x);
        } else {
            if (head.inf < x) {
                head = new Node(x, head);
                return;
            } else {
                Node p = head;
                while (p.next != null && p.next.inf >= x) {
                    p = p.next;
                }
                p.next = new Node(x, p.next);
            }
        }
    }

    Integer dequeue() throws EmptyStackException {
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

    void clear() {
//        head = null;        
        Node tmp = head;
        while (head.next != null) {
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
