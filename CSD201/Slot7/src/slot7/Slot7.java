/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot7;

import java.io.File;
import java.io.IOException;
import java.util.EmptyStackException;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Slot7 {

    public static void main(String[] args) throws Exception{
        myqueue queue = new myqueue();
        String pathname = "D:\\SLIDES\\SPRING2022";
        File f = new File(pathname);

        /*
         * Dùng queue để hiển thị toàn bộ danh sách file và folder từ một đường
         * dẫn
         */
//        for (int i = 0; i < f.listFiles().length; i++) {
////            System.out.println(f.listFiles()[i].toString());
//            queue.enqueue(f.listFiles()[i].toString());
//        }
//        while (!queue.empty()) {
//            String child = queue.dequeue();
//            f = new File(child);
//            if (f.isDirectory()) {
//                System.out.println("dir " + child);
//                for (int i = 0; i < f.listFiles().length; i++) {
//                    queue.enqueue(f.listFiles()[i].toString());
//                }
//            } else {
//                System.out.println("    " + child);
//            }
//
//        }
        
        f = new File(pathname);
        System.out.println(diskUsage(f));

    }

    /**
     * Use Recursion to calculate size of a folder
     *
     * @param root
     * @return
     * @throws IOException
     */
    public static long diskUsage(File root) throws IOException {
        long total = root.length(); //srart with direct disk usage
        if(root.isDirectory()){ //If this is a directory
            File child; 
            for (int i = 0; i < root.list().length; i++) {
                String fname = root.list()[i];
                child = new File(root, fname);
                System.out.println(child);
                total += diskUsage(child);
            }
        }
        return total;
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

//    Integer front() throws EmptyStackException{
//        try {
//            if (empty()) {
//                throw new EmptyStackException();
//            } else {
//                return head.inf;
//            }
//        } catch (Exception e) {
//            System.out.println("The queue is empty");
//            return null;
//        }
//    }
    void enqueue(String x) {
        Node p = head;
        if (empty()) {
            head = new Node(x);
        } else {
            while (p.next != null) {
                p = p.next;
            }
            p.next = new Node(x);
        }

    }

    String dequeue() throws EmptyStackException {
        try {
            if (empty()) {
                throw new EmptyStackException();
            } else {
                String val = head.inf;
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

    String inf;
    Node next;

    public Node() {
    }

    public Node(String x) {
        inf = x;
    }

    public Node(String x, Node p) {
        inf = x;
        next = p;
    }
}
