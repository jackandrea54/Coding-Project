/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package slot9;

import java.io.IOException;

/**
 *
 * @author ADMIN
 */
public class Main {
    public static void main(String[] args) throws InterruptedException, IOException {
        BSTree tree = new BSTree();
        tree.insert(55);
        tree.insert(50);
        tree.insert(60);
        tree.insert(40);
        tree.insert(52);
        tree.insert(57);
        tree.insert(70);
        tree.insert(53);
        tree.insert(54);
//      ----------------
//        System.out.println("BS Tree before rotate:");
//        tree.breadth(tree.root);
//        System.out.println("");
//        System.out.println("BS Tree after rotate:");
//        tree.root = tree.left_right_Rotate(tree.root);
//        tree.insert(3);
//        tree.insert(2);
        System.out.println("Tree before:");
        tree.breadth(tree.root);
        int x = 40;
        tree.remove(x);
        System.out.println("Tree after remove " + x + " then balance:");
        tree.breadth(tree.root);
        
//        tree.insert(9);
//        tree.insert(15);
//        tree.insert(5);
//        tree.insert(2);
//        tree.insert(7);
//        tree.insert(6);
//        tree.insert(14);
//        tree.insert(16);
//        tree.insert(10);
//        tree.readFile("data.txt");
//        System.out.println("Pre-order: ");
//        tree.preOrder(tree.root);
//        System.out.println("");
//        System.out.println("In-order: ");
//        tree.inOrder(tree.root);
//        System.out.println("");
//        System.out.println("Post-order: ");
//        tree.postOrder(tree.root);
//        System.out.println("");
//        System.out.println("Breadth-first: ");
//        tree.breadth(tree.root);
//        int x = 44;
//        tree.removeByMerge(x);
//        System.out.println("");
//        System.out.println("Tree after remove " + x + " :");
//        tree.breadth(tree.root);
//        System.out.println("");
//        System.out.println("Do cao cua node chua gia tri " + x +" = "+ tree.height(x));
        
    }
}
