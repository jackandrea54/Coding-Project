/* This program contains 2 parts: (1) and (2)
   YOUR TASK IS TO COMPLETE THE PART  (2)  ONLY
 */
//(1)==============================================================
import java.util.*;
import java.io.*;
import jdk.nashorn.internal.ir.BreakNode;

class MyList {

    Node head, tail;

    MyList() {
        head = tail = null;
    }

    boolean isEmpty() {
        return (head == null);
    }

    void clear() {
        head = tail = null;
    }

    void fvisit(Node p, RandomAccessFile f) throws Exception {
        if (p != null) {
            f.writeBytes(p.info + " ");
        }
    }

    void ftraverse(RandomAccessFile f) throws Exception {
        Node p = head;
        while (p != null) {
            fvisit(p, f); // You will use this statement to write information of the node p to the file
            p = p.next;
        }
        f.writeBytes("\r\n");
    }

    void loadData(int k) //do not edit this function
    {
        String[] a = Lib.readLineToStrArray("data.txt", k);
        int[] b = Lib.readLineToIntArray("data.txt", k + 1);
        int n = a.length;
        for (int i = 0; i < n; i++) {
            addLast(a[i], b[i]);
        }
    }

//===========================================================================
//(2)===YOU CAN EDIT OR EVEN ADD NEW FUNCTIONS IN THE FOLLOWING PART========
//===========================================================================
    void addLast(String xOwner, int xPrice) {//You should write here appropriate statements to complete this function.
        if (xOwner.charAt(0) == 'B' || xPrice > 100) {
            return;
        } else {
            if (head == null) {
                head = tail = new Node(new Car(xOwner, xPrice), null);
            } else {
                Node p = new Node(new Car(xOwner, xPrice));
                tail.next = p;
                tail = p;
            }
        }
    }

    void f1() throws Exception {/* You do not need to edit this function. Your task is to complete the addLast  function
        above only.
         */
        clear();
        loadData(1);
        String fname = "f1.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        ftraverse(f);
        f.close();
    }

//==================================================================
    void f2() throws Exception {
        clear();
        loadData(4);
        String fname = "f2.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        ftraverse(f);
        Car x = new Car("X", 1);
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        Node p = new Node(x);
        if (head == null) {
            head = tail = p;
        }
        else{
            p.next = head;
            head = p;
        }
        
        //------------------------------------------------------------------------------------
        ftraverse(f);
        f.close();
    }

//==================================================================
    void f3() throws Exception {
        clear();
        loadData(7);
        String fname = "f3.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        ftraverse(f);
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        if (head == null) {
            return;
        }
        if (head.info.price == 5) {
            head = head.next;

        } else {
            Node p = head;
            while (p.next != null) {
                if (p.next.info.price == 5) {
                    p.next = p.next.next;
                    break;
                }
            }
        }

        //------------------------------------------------------------------------------------
        ftraverse(f);
        f.close();
    }

//==================================================================
    void f4() throws Exception {
        clear();
        loadData(10);
        String fname = "f4.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        ftraverse(f);
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/

        if (head == null || head.next == null) {
            return;
        }

        boolean flag = true;
        do {
            if (head.info.price > head.next.info.price) {
                Node tmp = head.next;
                head.next = head.next.next;
                tmp.next = head;
                head = tmp;
            }
            Node p = head;
            flag = false;
            while (p.next != null && p.next.next != null) {
                if (p.next.info.price > p.next.next.info.price) {
                    Node tmp = p.next;
                    p.next = p.next.next;
                    tmp.next = tmp.next.next;
                    p.next.next = tmp;
                    flag = true;
                }
                p = p.next;
            }
        } while (flag == true);

        //------------------------------------------------------------------------------------
        ftraverse(f);
        f.close();
    }

}
