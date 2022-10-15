package graph;


import java.util.Scanner;
import java.util.Stack;


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author thangnv
 */
public class Graphs {
    int n;
    char Vertex[];
    int[][] adj;//adj[v][i] i se la dinh lien ke cua v,

    public Graphs(int n) {
        this.n = n;
        Vertex = new char[n];
        adj = new int[n][n];
    }

    public void visit(int i) {
        System.out.print(Vertex[i] + " ");
    }

    public void depth(boolean visited[], int i) {
        visit(i);
        visited[i] = true;
        for (int k = 0; k < n; k++) {
            if (adj[i][k] > 0 && adj[i][k] < 999 && !visited[k]) {
                depth(visited, k);
            }
        }
    }

    public void depthFirst(int k) {
        boolean visited[] = new boolean[n];
        for (int i = 0; i < n; i++) {
            visited[i] = false;
        }
        depth(visited, k);
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                depth(visited, i);
            }
//            System.out.println("");
        }
    }
    public void breadth(boolean visited[],int v) throws Exception{
        Queue q = new Queue();
        q.enqueue(v);
        visited[v]=true;
        while (!q.isEmpty()){
            int r = q.dequeue();
            visit(r);
            for (int i=0;i<n;i++){
                if (adj[r][i]>0 && !visited[i]){
                    q.enqueue(i);
                    visited[i]=true;
                }
            }
        }
    }
  
    public void breadth_full(int v) throws Exception{
        boolean visited[] = new boolean[n];
        for (int i=0;i<n;i++) visited[i]=false;
        
//       breadth (visited,v);
        
        for (int i=0;i<n;i++){
            if (!visited[i])  breadth (visited, i);
        }        
        System.out.println(""); 
    }
//    
   
   
    public void dijkstra(int from) {
        int distance[] = new int[n];
        boolean[] ok = new boolean[n];

        int[] path = new int[n];
        for (int i = 0; i < n; i++) {
            distance[i] = Integer.MAX_VALUE;
            path[i] = from;
            ok[i] = false;
        }

        System.out.println("");
        distance[from] = 0;
        int sel = from;
        ok[sel] = true;
        path[sel] = from;

        for (int t = 0; t < n; t++) {
            for (int i = 0; i < n; i++) {
                //cac dinh lien ke cua from
                if (!ok[i] && (adj[sel][i] + distance[sel] < distance[i])) {
                    distance[i] = adj[sel][i] + distance[sel];
                    path[i] = sel;
                }
            }
            int min = Integer.MAX_VALUE;
            for (int i = 0; i < n; i++) {
                if (!ok[i] && distance[i] < min) {
                    sel=i;
                    min = distance[i];
                }
            }
//            sel = path[t];
            ok[sel] = true;
//         System.out.println("from = "+path[0]+"ver 0 ="+Vertex[0]);
            System.out.println("from vertex " + Vertex[from] + " to " + Vertex[path[t]] + " dis = " + distance[path[t]]);

            //tinh khoang cach tu dinh from toi cac dinh lien ke
        }
        System.out.println("");
        for (int i=0;i<n;i++){
            System.out.println (" from  : "+i+" to "+path[i]+" ");
        }
        System.out.println("");
        for (int t = 0; t < n; t++) {
            System.out.print(Vertex[path[t]] + " ");
        }
    }

    public void dijkstra(int from, int to) {
        int distance[] = new int[n];
        boolean[] visited = new boolean[n];
        int[] path = new int[n];
        for (int i = 0; i < n; i++) {
            distance[i] = Integer.MAX_VALUE;
            path[i] = from;
            visited[i] = false;
        }

        System.out.println("");
        distance[from] = 0;
        int sel = from;
        visited[sel] = true;
//        path[0] = from;
        for (int t = 0; t < n; t++) {
            
            for (int i = 0; i < n; i++) {
                //cac dinh lien ke cua from
                if (!visited[i] && (adj[sel][i] + distance[sel] < distance[i])) {
                    distance[i] = adj[sel][i] + distance[sel];
                    path[i]=sel;
                }

            }
            int min = Integer.MAX_VALUE;          
            for (int i = 0; i < n; i++) {
                if (!visited[i] && (distance[i] < min ) ) {
                    sel = i;
                    min = distance[i];
                }
            }
            visited[sel] = true;
        }

       
        int x =to;
        Stack stack = new Stack();
        while (x!=from){
            stack.push(x);            
             x=path[x];
        }
        stack.push(from);
        while (!stack.isEmpty()){
            x = (int) stack.pop();
            System.out.print (Vertex [x]+" ");
        }
        System.out.println("distance = "+distance[to]);

    }

    public void input(int n) {
        this.n = n;
        Scanner scan;//= new Scanner(System.in);
        for (int i = 0; i < n; i++) {
            System.out.print("ten dinh thu " + i + ": ");
            scan = new Scanner(System.in);
            String s = scan.nextLine();
            Vertex[i] = s.charAt(0);
        }
        System.out.println("Ma tran lien thuoc");
        for (int i = 0; i < n; i++) {
            System.out.print("Vertex " + Vertex[i] + " ");
            scan = new Scanner(System.in);
            String s = scan.nextLine();//.split("[ ]+");
            scan = new Scanner(s);
            for (int j = 0; j < n; j++) {
                adj[i][j] = scan.nextInt();// Integer.parseInt(s[j]);
            }
        }
    }

    public void display() {
        System.out.println("");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                System.out.print(adj[i][j] + " ");
            }
            System.out.println("");
        }
    }

}

class Queue {

    Node head, tail;

    public boolean isEmpty() {
        return head == null;
    }

    public void enqueue(int t) {
        if (head == null) {
            head = tail = new Node(t);
        } else {
            tail.next = new Node(t);
            tail = tail.next;
        }
    }

    public int dequeue() throws Exception {
        int x = 0;
        if (head != null) {
            x = head.val;
            head = head.next;
        } else {
            throw new Exception("Nothing to dequeue");
        }
        return x;
    }
}

class Node {

    int val;
    Node next;

    public Node() {
    }

    public Node(int val) {
        this.val = val;
        this.next = null;
    }

}
