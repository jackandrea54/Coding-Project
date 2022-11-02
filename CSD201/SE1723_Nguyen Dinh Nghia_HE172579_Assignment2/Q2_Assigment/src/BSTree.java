/* This program contains 2 parts: (1) and (2)
   YOUR TASK IS TO COMPLETE THE PART  (2)  ONLY
 */
//(1)==============================================================
import java.io.*;
import java.util.*;

class BSTree {

    Node root;

    BSTree() {
        root = null;
    }

    boolean isEmpty() {
        return (root == null);
    }

    void clear() {
        root = null;
    }

    void fvisit(Node p, RandomAccessFile f) throws Exception {
        if (p != null) {
            f.writeBytes(p.info + " ");
        }
    }

    void preOrder(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }

        //if (p.info.price>=3 && p.info.price<=5)
        fvisit(p, f);
        preOrder(p.left, f);
        preOrder(p.right, f);
    }

    void inOrder(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }
        inOrder(p.left, f);
        fvisit(p, f);
        inOrder(p.right, f);
    }

    void postOrder(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }
        postOrder(p.left, f);
        postOrder(p.right, f);
        fvisit(p, f);
    }

    void breadth(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }
        Queue q = new Queue();
        q.enqueue(p);
        Node r;
        while (!q.isEmpty()) {
            r = q.dequeue();
            fvisit(r, f);
            if (r.left != null) {
                q.enqueue(r.left);
            }
            if (r.right != null) {
                q.enqueue(r.right);
            }
        }
    }

    void loadData(int k) //do not edit this function
    {
        String[] a = Lib.readLineToStrArray("data.txt", k);
        int[] b = Lib.readLineToIntArray("data.txt", k + 1);
        int n = a.length;
        for (int i = 0; i < n; i++) {
            insert(a[i], b[i]);
        }
    }

//===========================================================================
//(2)===YOU CAN EDIT OR EVEN ADD NEW FUNCTIONS IN THE FOLLOWING PART========
//===========================================================================
    void insert(String xOwner, int xPrice) {
        //You should insert here statements to complete this function
        if (xOwner.charAt(1) == 'B' || xPrice % 2 == 0) {
            return;
        }
        if (isEmpty()) {
            root = new Node(new Car(xOwner, xPrice));
        } else {
            Node p = root;
            Node par = p;
            while (p != null) {
                if (p.info.price > xPrice) {
                    par = p;
                    p = p.left;
                } else if (p.info.price < xPrice) {
                    par = p;
                    p = p.right;
                } else {
                    return;
                }

            }
            if (par.info.price > xPrice) {
                par.left = new Node(new Car(xOwner, xPrice));
            } else {
                par.right = new Node(new Car(xOwner, xPrice));
            }
        }
    }

    void f1() throws Exception {/* You do not need to edit this function. Your task is to complete insert  function
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
        breadth(root, f);
        f.writeBytes("\r\n");

        breadth(root, f);
        f.writeBytes("\r\n");
        f.close();
    }

//=============================================================
    void inOrder2(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }
        inOrder2(p.left, f);
        fvisit2(p, f);
        inOrder2(p.right, f);
    }

    void fvisit2(Node p, RandomAccessFile f) throws Exception {
        if (p != null) {
            if (p.info.price >= 3 && p.info.price <= 50) {
                f.writeBytes(p.info + " ");
            }
        }
    }

    void f2() throws Exception {
        clear();
        loadData(4);
        String fname = "f2.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        inOrder(root, f);
        f.writeBytes("\r\n");
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        inOrder2(root, f);
        //------------------------------------------------------------------------------------
        f.writeBytes("\r\n");
        f.close();
    }

// f.writeBytes(" k = " + k + "\r\n");
//=============================================================
    /**
     * This function will find the first Node that has 2 sons and price in [x,y]
     *
     *
     * @return
     */
    public Node findNode(Node p, int x, int y) {
        if (p == null) {
            return null;
        }
        Node q = findNode(p.left, x, y);
        if (q != null) {
            return q;
        }
        q = findNode(p.right, x, y);
        if (q != null) {
            return q;
        }
        if (p.left != null && p.right != null && p.info.price >= x && p.info.price <= y) {
            return p;
        } else {
            return null;
        }
    }

    public void removeByCopying() {
        //Tim duoc node p chua x va node cha cua p
        //Co ca con ben trai lan phai
        //Phuong phap 1: Delete by Copying
        //Cach 1: Tim Max cua cay con trai 
        Node p = findNode(root, 3, 50);
        Node k = p.left;
        Node par_k = p;
        while (k.right != null) {
            par_k = k;
            k = k.right;
        }
        p.info.price = k.info.price;
        p.info.owner = k.info.owner;
        if (par_k == p) {
            p.left = k.left;
        } else {
            par_k.right = k.left;
        }

    }

    void f3() throws Exception {
        clear();
        loadData(7);
        String fname = "f3.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        postOrder(root, f);
        f.writeBytes("\r\n");
//        inorder2(root);
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        removeByCopying();
        //------------------------------------------------------------------------------------
        postOrder(root, f);

        f.writeBytes(
                "\r\n");
        f.close();
    }

//=============================================================
    public Node findNodePreOrder(Node p, int x, int y) { // Using pre-order
        if (p == null) {
            return null;
        }
        if (p.left != null && p.right != null && p.info.price >= x && p.info.price <= y) {
            return p;
        }
        Node q = findNodePreOrder(p.left, x, y);
        if (q != null) {
            return q;
        }
        q = findNodePreOrder(p.right, x, y);
        if (q != null) {
            return q;
        } else {
            return null;
        }
    }

    public void left_Rotate() {
        int x = findNodePreOrder(root, 3, 50).info.price;
        Node p = root, par = p;
        while (p != null && p.info.price < x) {
            if (p.info.price < x) {
                par = p;
                p = p.right;
            } else if (p.info.price > x) {
                par = p;
                p = p.left;
            }
        }
        Node newroot = p.right;
        p.right = newroot.left;
        newroot.left = p;
        if (p == root) {
            root = newroot;
        } else {
            if (p == par.left) {
                par.left = newroot;
            } else if (p == par.right) {
                par.right = newroot;
            }
        }

    }

    void f4() throws Exception {
        clear();
        loadData(10);
        String fname = "f4.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        preOrder(root, f);
        f.writeBytes("\r\n");
        //------------------------------------------------------------------------------------
        /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        left_Rotate();
        //-------------------+-----------------------------------------------------------------
        preOrder(root, f);
        f.writeBytes("\r\n");
        f.close();
    }

}
