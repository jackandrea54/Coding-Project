/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot9;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.EmptyStackException;
import java.util.Scanner;
import sun.misc.Queue;
import sun.security.provider.PolicyParser;

/**
 *
 * @author ADMIN
 */
public class BSTree {

    Scanner sc = new Scanner(System.in);
    Node root;

    public BSTree() {

    }

    boolean isEmpty() {
        return root == null;
    }

    public void visited(Node p) {
        System.out.print(p.inf + " ");
    }

    public void insert(int x) {
//        if (isEmpty()) {
//            root = new Node(x, null, null);
//        }
//        Node p = root;
//        while (true) {            
//            if (x < p.inf  && p.left == null) {
//                p.left = new Node(x, null, null);
//                break;
//            }
//            if (x > p.inf  && p.right == null) {
//                p.left = new Node(x, null, null);
//                break;
//            }
//            if (x < p.inf  && p.left != null) {
//                p = p.left;
//            }
//            if (x > p.inf  && p.right != null) {
//                p = p.right;
//            }
//        } can sua lai
        if (isEmpty()) {
            root = new Node(x);
        } else {
            Node p = root;
            Node par = p; //node parent
            while (p != null) {
                if (x > p.inf) {
                    par = p;
                    p = p.right;
                } else if (x < p.inf) {
                    par = p;
                    p = p.left;
                } else {
                    return; // x == p.inf thi ko insert gi ca
                }
            }
            // p == null; par la node cha cua node can insert
            if (x > par.inf) {
                par.right = new Node(x);
            } else {
                par.left = new Node(x);
            }
        }
        balance(root, root);
    }

    public void preOrder(Node p) {
        if (p == null) {
            return;
        }
        visited(p);
        preOrder(p.left);
        preOrder(p.right);
    }

    public void inOrder(Node p) {
        if (p == null) {
            return;
        }
        inOrder(p.left);
        visited(p);
        inOrder(p.right);
    }

    public void postOrder(Node p) {
        if (p == null) {
            return;
        }
        postOrder(p.left);
        postOrder(p.right);
        visited(p);
    }

    public void breadth(Node p) throws InterruptedException {
        if (p == null) {
            return;
        }
        Queue<Node> myQueue = new Queue<>();
        myQueue.enqueue(p);
        Node q;
        while (!myQueue.isEmpty()) {
            q = myQueue.dequeue();
            System.out.print(q.inf + " ");
            if (q.left != null) {
//                System.out.println("Add left: " + q.left.inf);
                myQueue.enqueue(q.left);
            }
            if (q.right != null) {
//                System.out.println("Add right: " + q.right.inf);
                myQueue.enqueue(q.right);
            }
        }
        System.out.println("");
    }

    public void remove(int x) {
        Node p = root, par = p;
        while (p != null && p.inf != x) {
            if (p.inf < x) {
                par = p;
                p = p.right;
            } else if (p.inf > x) {
                par = p;
                p = p.left;
            }
        }
        if (p == null) {
            return;
        }
        //Tim duoc node p chua x va node cha cua p
        if (p.left == null && p.right == null) {//TH1: p la node la, khong co con
            if (par.left == p) {
                par.left = null;
            } else {
                par.right = null;
            }
        } else if (p.left != null && p.right == null) { //chi co 1 con trai
            if (par.left == p) {
                par.left = p.left;
            } else {
                par.right = p.left;
            }
        } else if (p.right != null && p.left == null) { //chi co 1 con phai
            if (par.left == p) {
                par.left = p.right;
            } else {
                par.right = p.right;
            }
        } else { //Co ca con ben trai lan phai
            //Phuong phap 1: Delete by Copying
            //Cach 1: Tim Max cua cay con trai 
            Node k = p.left;
            Node par_k = p;
            while (k.right != null) {
                par_k = k;
                k = k.right;
            }
            p.inf = k.inf;
            if (par_k == p) {
                p.left = k.left;
            } else {
                par_k.right = k.left;
            }
//            //Cach 2: Tim Min cua cay con phai
//            Node k = p.right;
//            Node par_k = p;
//            while (k.left != null) {                
//                par_k = k;
//                k = k.left;
//            }
//            p.inf = k.inf;
//            if(par_k == p){
//                p.right = k.right;
//            }
//            else{
//                par_k.left = k.right;
//            }
        }
        balance(root, root);
    }

    public void removeByMerge(int x) {
        Node p = root, par = p;
        while (p != null && p.inf != x) {
            if (p.inf < x) {
                par = p;
                p = p.right;
            } else if (p.inf > x) {
                par = p;
                p = p.left;
            }
        }
        if (p == null) {
            return;
        }
        //Tim duoc node p chua x va node cha cua p
        if (p.left == null && p.right == null) {//TH1: p la node la, khong co con
            if (par.left == p) {
                par.left = null;
            } else {
                par.right = null;
            }
        } else if (p.left != null && p.right == null) { //chi co 1 con trai
            if (par.left == p) {
                par.left = p.left;
            } else {
                par.right = p.left;
            }
        } else if (p.right != null && p.left == null) { //chi co 1 con phai
            if (par.left == p) {
                par.left = p.right;
            } else {
                par.right = p.right;
            }
        } else {//p co 2 con
            //Cach 1: Cho con trái cua p len thay
            // sau do cho con phải của P đến node phải cùng của con trái
            Node mostRight = p.left;
            while (mostRight.right != null) {
                mostRight = mostRight.right;
            }
            if (root == p) {
                root = root.left;
            } else {
                if (par.left == p) {
                    par.left = p.left;
                } else {
                    par.right = p.left;
                }
            }
            mostRight.right = p.right;

            //Cách 2: Cho con phải cua p len thay
            // sau do cho con trái của P đến node trái cùng của con phải
        }
    }

    public int height(int x) {
        //Tim node p chua x
        Node p = root, par = p;
        if (isEmpty()) {
            return 0;
        }
        while (p != null && p.inf != x) {
            if (p.inf < x) {
                par = p;
                p = p.right;
            } else if (p.inf > x) {
                par = p;
                p = p.left;
            }
        }
        if (p == null) {
            return 0;
        }

        if (p.left == null && p.right == null) {
            return 1;
        } else if (p.left != null && p.right == null) {
            return 1 + height(p.left.inf);
        } else if (p.left == null && p.right != null) {
            return 1 + height(p.right.inf);
        } else {
            return Integer.max(1 + height(p.left.inf), 1 + height(p.right.inf));
        }
    }

    public void readFile(String fname) throws FileNotFoundException, IOException {
        File f = new File(fname);
        if (!f.isFile()) {
            return;
        }
        RandomAccessFile fr = new RandomAccessFile(fname, "r");
        String s;
        while ((s = fr.readLine()) != null) {
            String arr[] = s.split("[ ]+");
            for (int i = 0; i < arr.length; i++) {
                insert(Integer.parseInt(arr[i].trim()));
            }
        }
    }

    private Node right_Rotate(Node p) {
        if (p == null || p.left == null) {
            return p;
        }
        Node newroot = p.left;
        p.left = newroot.right;
        newroot.right = p;
        return newroot;
    }

    private Node left_Rotate(Node p) {
        if (p == null || p.right == null) {
            return p;
        }
        Node newroot = p.right;
        p.right = newroot.left;
        newroot.left = p;
        return newroot;
    }

    private Node left_right_Rotate(Node p) {
        p.left = left_Rotate(p.left);
        p = right_Rotate(p);
        return p;
    }

    private Node right_left_Rotate(Node p) {
        p.right = right_Rotate(p.right);
        p = left_Rotate(p);
        return p;
    }
    
    private int heightOfNode(Node p) {
        if (p == null) {
            return 0;
        } else {
            return height(p.inf);
        }
    }
    
    private int factor(Node p){
        int fact = heightOfNode(p.right) - heightOfNode(p.left);
        return fact;
    }
    
    private Node rotate(Node p) {
        if (factor(p) == -2) { //Lech trai
            //Neu node p va node con trai cua no cung dau
            if ((factor(p.left)) == -1) { // lech trai - trai
                p = right_Rotate(p);
            } else { //Lech trai - phai
                p = left_right_Rotate(p);
            }
        } else if (factor(p) == 2) { //Lech phai
            //Neu node p va node con phai cua no cung dau
            if (factor(p.right) == 1) { //Lech phai - phai
                p = left_Rotate(p);
            } else { //Lech phai - trai
                p = right_left_Rotate(p);
            }
        }

//        breadth(p);
        return p;
    }

    //Balance dung moi khi insert mot node moi
    public void balance(Node p, Node par) {
        if (p == null) {
            return;
        }

        balance(p.left, p);
        balance(p.right, p);
        if (p == par.left) {
            par.left = rotate(p);
        } else if (p == par.right) {
            par.right = rotate(p);
        } else {
            root = rotate(p);
        }
    }
}

class Node {

    int inf;
    Node left;
    Node right;

    public Node() {
    }

    public Node(int x) {
        inf = x;
    }

    public Node(int x, Node p, Node q) {
        inf = x;
        left = p;
        right = q;
    }
}
