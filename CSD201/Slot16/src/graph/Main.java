/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package graph;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Main {

    public static void main(String[] args) throws InterruptedException, Exception {
        // TODO code application logic here
        int n = 6;
        Graphs grap = new Graphs(n);
        String s, s1 = null;
        Scanner scan;

        grap.Vertex = "ABCDEFGHIJKLMNOP".toCharArray();
        //A     B       C        D   E       F    G       H        I
        s1 = "0    999     999     999     8       2   15     999     14 "//A
                + "999   0      999     999     999    999   10     999     999 "//B
                + "999  999      0       999    999    999   999     2     999 "//C
                + "999  999     999      0      999     999   999     11     999 "//D
                + "8    999     999     999      0      3   999     999     5 "//E
                + "2   999      999     999     3       0   999     999     999 "//F
                + "15   10      999     999   999      999   0      999     999 "//G
                + "999  999     2       11      999     999   999     0       999 "//H
                + "14    999     999     999     5      999   999     999     0 ";//I

        //   A   B   C  D E  F  G  H  I
        String s2 = "0  0  0  0  1  1  1  0  1 "
                +//A
                "0  0  0  0  0  0  1  0  0 "
                +//B
                "0  0  0  0  0  0  0  1  0 "
                +//C adj[2][8] ==1
                "0  0  0  0  0  0  0  1  0 "
                +//D
                "1  0  0  0  0  1  0  0  1 "
                +//E
                "1  0  0  0  1  0  0  0  1 "
                +//F
                "1  1  0  0  0  0  0  0  0 "
                +//G
                "0  0  1  1  0  0  0  0  0 "
                +//H
                "1  0  0  0  1  1  0  0  0 ";  //I

//    grap.Vertex="123456".toCharArray();
        String s3 = "0 2 4 999 999 999 "
                + "2 0 1 7 999 999 "
                + "4 1 0 999 3 999 "
                + "999 7 999 0 2 1 "
                + "999 999 3 2 0 5 "
                + "999 999 999 1 5 0 ";
        // 0 1 2 3 4 5 6 7 
        String s4 = "0 1 1 1 0 0 0 0 "
                +//0
                "1 0 0 1 0 1 1 0 "
                +//1
                "1 0 0 0 1 0 1 0 "
                +//2
                "1 1 0 0 0 0 0 0 "
                +//3
                "0 0 1 0 0 0 0 1 "
                +//4
                "0 1 0 0 0 0 1 0 "
                +//5
                "0 1 1 0 0 1 0 0 "
                +//6
                "0 0 0 0 0 0 0 0 ";//7
        String s5 = "0 2 999 999 999 4 "
                + "2 0 7 999 999 1 "
                + "999 7 0 1 2 999 "
                + " 999 999 1 0 5 999  "
                + " 999 999 2 5 0 3 "
                + "4 1 999 999 3 0 ";
        scan = new Scanner(s5);
//        System.out.println("s ="+s);
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                grap.adj[i][j] = scan.nextInt();// Integer.parseInt( scan.next());
            }
        }
        System.out.println("adjacency matrix");
        grap.display();
        System.out.println("");
        int from = 0, to = 6;
        System.out.println("test breadth- first travels");
        boolean visited[] = new boolean[n];
        for (int i = 0; i < n; i++) {
            visited[i] = false;
        }
        grap.breadth(visited, from);
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                grap.breadth(visited, i);
            }
        }
//        System.out.println("test depth-first");
//        grap.depthFirst(from);
        System.out.println("");
        System.out.println("shortest path from Vertex " + grap.Vertex[from] + " to Vertex " + grap.Vertex[to]);
        grap.dijkstra(from);
        System.out.println("");
    }

}
