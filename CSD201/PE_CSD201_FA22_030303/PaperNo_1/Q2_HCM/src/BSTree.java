
import java.io.*;
import java.util.*;

public class BSTree {

    Node root;

    // Default constructor
    BSTree() {
        this.root = null;
    }

    public boolean isEmpty() {
        return this.root == null;
    }

    public void clear() {
        this.root = null;
    }

    public void visit(Node p) {
        System.out.print("p.info: ");
        if (p != null) {
            System.out.println(p.getInfo() + " ");
        }
    }

    public void fvisit(Node p, RandomAccessFile f) throws Exception {
        if (p != null) {
            f.writeBytes(p.getInfo() + " ");
        }
    }

    public void breadth(Node p, RandomAccessFile f) throws Exception {
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

    public void preOrder(Node p, RandomAccessFile f) throws Exception {

        if (p == null) {
            return;
        }

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

    /**
     * Do NOT modify this method Load 3 lines of data from file: line k (for
     * owner), and line k+1 (for price), and line k+2 (for color)
     *
     * @param k the k-th line where data is started to be loaded
     */
    void loadData(int k) {
        String[] a = Lib.readLineToStrArray("data.txt", k);
        int[] b = Lib.readLineToIntArray("data.txt", k + 1);
        int[] c = Lib.readLineToIntArray("data.txt", k + 2);

        int n = a.length;
        for (int i = 0; i < n; i++) {
            insert(a[i], b[i], c[i]); // insert the new Node(a[i], b[i], c[i]) into the BST
        }
    }

    /**
     * Luy y: 1. SV KHONG su dung tieng Viet co dau trong bai lam de tranh Error
     * khi run chuong trinh. 2. Neu khong tuan thu se nhan diem 0 (khong).
     * Question 2.1: use House’s price as the key attribute when building a BST.
     * implement the 'insert' method that inserts a new Node into the BST if the
     * attribute 'Owner'of House does NOT start with 'B'. The output of this
     * method will be written into the file 'f1.txt'. Therefore you should open
     * this file to see/test your code output. Example: with the content given
     * in the file 'data.txt', the content of 'f1.txt' after insertion should be
     * (A,7,9) (C,4,3) (D,8,6) (E,2,5) (Y,6,-7) (F,-6,7) (F,-6,7) (E,2,5)
     * (C,4,3) (Y,6,-7) (A,7,9) (D,8,6)
     *
     * @param xOwner the owner of the input House
     * @param xPrice the price of the input House
     * @param xColor the color of the input House
     */
    void insert(String xOwner, int xPrice, int xColor) {
        //Hint: create a recursive method to insert, called insertRec then call it here
        //For example:
        if (xOwner.startsWith("B")) {
            return;
        }
        if (isEmpty()) {
            root = new Node(new House(xOwner, xPrice, xColor));
        }else{
            Node p = root;
            Node par = p;
            while (p != null) {
                if (p.getInfo().price > xPrice) {
                    par = p;
                    p = p.left;
                } else if (p.getInfo().price < xPrice) {
                    par = p;
                    p = p.right;
                } else {
                    return;
                }
            }
            if (par.getInfo().price > xPrice) {
                par.left = new Node(new House(xOwner, xPrice, xColor));
            } else {
                par.right = new Node(new House(xOwner, xPrice, xColor));
            }
        }

    }

    /**
     * Do NOT modify this method This is a helper method for writing data
     * (node's info) stored in the BST to file
     *
     * @throws Exception
     */
    void f1() throws Exception {
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
        inOrder(root, f);
        f.writeBytes("\r\n");
        f.close();
    }

    // This method is used for Question 2.2
     public void fvisit2(Node p, RandomAccessFile f) throws Exception {
        if (p != null && p.getInfo().color < 5) {
            f.writeBytes(p.getInfo() + " ");
        }
    }

    public void breadth2(Node p, RandomAccessFile f) throws Exception {
        if (p == null) {
            return;
        }
        Queue q = new Queue();
        q.enqueue(p);
        Node r;
        while (!q.isEmpty()) {
            r = q.dequeue();
            fvisit2(r, f);

            if (r.left != null) {
                q.enqueue(r.left);
            }

            if (r.right != null) {
                q.enqueue(r.right);
            }
        }
    }
    
    
    void f2() throws Exception {
        clear();
        loadData(5);
        String fname = "f2.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        breadth(root, f);
        f.writeBytes("\r\n");

        /**
         * Question 2.2: Perform breadth-first-search on the BST, but ONLY visit
         * nodes that has House's color less than 5. Hint: This method is
         * similar to the method 'breadth' (provided in this class already). You
         * should create a new method which body is similar to 'breadth' for
         * doing BFS but considering only color less than 5. The output f2()
         * will be written into the file 'f2.txt'. Therefore you should open
         * this file to see/test your code output. Example: With the data
         * provided in 'data.txt', the content of 'f2.txt' after running this
         * method is (C,8,2) (D,6,1) (E,9,4) (F,2,3) (G,7,8) (H,1,7) (I,3,9)
         * (J,5,5) (K,4,6) (C,8,2) (D,6,1) (E,9,4) (F,2,3)
         */
        //---------------------------------------------------------------------------------------
        //------ Start your code here------------------------------------------------------------
        breadth2(root, f);
        //------ End your code here--------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        f.writeBytes("\r\n");
        f.close();
    }

    // This method is used for Question 2.3
    public int height(int x) {
        //Tim node p chua x
        Node p = root, par = p;
        if (isEmpty()) {
            return 0;
        }
        while (p != null && p.getInfo().price != x) {
            if (p.getInfo().price  < x) {
                par = p;
                p = p.right;
            } else if (p.getInfo().price > x) {
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
            return 1 + height(p.left.getInfo().price);
        } else if (p.left == null && p.right != null) {
            return 1 + height(p.right.getInfo().price);
        } else {
            return Integer.max(1 + height(p.left.getInfo().price), 1 + height(p.right.getInfo().price));
        }
    }
    
    void f3() throws Exception {
        clear();
        loadData(9);
        String fname = "f3.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        postOrder(root, f);
        f.writeBytes("\r\n");
        /**
         * Question 2.3: Insert into the current tree a new House which Onwer =
         * 'Z', price = 15, color = k, where k is height of the current tree
         * before insertion Hint: (1) Implement a method to calculate the tree's
         * height (2) Insert the new House('Z', 15, Tree Height) into the
         * current tree The output f3() will be written into the file 'f3.txt'.
         * Therefore you should open this file to see/test your code output.
         * Example: With the data provided in 'data.txt', the content of
         * 'f3.txt' after running this method is (H,1,7) (K,4,6) (J,5,5) (I,3,9)
         * (F,2,3) (G,7,8) (D,6,1) (E,9,4) (C,8,2) (H,1,7) (K,4,6) (J,5,5)
         * (I,3,9) (F,2,3) (G,7,8) (D,6,1) (Z,15,6) (E,9,4) (C,8,2)
         */
        //---------------------------------------------------------------------------------------
        //------ Start your code here------------------------------------------------------------
        insert("Z", 15, height(root.getInfo().price));
        //------ End your code here--------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        postOrder(root, f);
        f.writeBytes("\r\n");
        f.close();
    }

    // This method is used for Question 2.4
    void f4() throws Exception {
        clear();
        loadData(13);;
        String fname = "f4.txt";
        File g123 = new File(fname);
        if (g123.exists()) {
            g123.delete();
        }
        RandomAccessFile f = new RandomAccessFile(fname, "rw");
        postOrder(root, f);
        f.writeBytes("\r\n");
        /**
         * Question 2.4: Increase the House's color of all leaf Nodes by 1 Hint:
         * Leaf nodes have neither left child nor right child The output f4()
         * will be written into the file 'f4.txt'. Therefore you should open
         * this file to see/test your code output. Example: With the data
         * provided in 'data.txt', the content of 'f4.txt' after running this
         * method is (H,1,7) (K,4,6) (J,5,5) (I,3,9) (F,2,3) (G,7,8) (D,6,1)
         * (E,9,4) (C,8,2) (H,1,8) (K,4,7) (J,5,5) (I,3,9) (F,2,3) (G,7,9)
         * (D,6,1) (E,9,5) (C,8,2)
         */
        //---------------------------------------------------------------------------------------
        //------ Start your code here------------------------------------------------------------

        //------ End your code here--------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        postOrder(root, f);
        f.writeBytes("\r\n");
        f.close();
    }
}
