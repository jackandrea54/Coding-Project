/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CompareThePlayer;

/**
 *
 * @author ADMIN
 */

import java.io.*;
import java.util.*;

class Checker{
    Comparator<Player> desc = new Comparator<Player>() {
        @Override
        public int compare(Player p1, Player p2) {
            int d = p2.score - p1.score;
            if(d ==0){
                return p2.name.compareTo(p1.name);
            }
            return d;
        }
    };
}

class Player
{
	String name;
	int score;
}

public class Solution5 {

	public static void main(String[] args) throws NumberFormatException, IOException {
	  BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
       
	  int N=Integer.parseInt(br.readLine().trim());
	  String s;
	  StringTokenizer st;
	  Player Player[]=new Player[N];
	  Checker check=new Checker();
	  for(int i=0;i<N;i++)
	  {
		  s=br.readLine().trim();
		  st=new StringTokenizer(s);
		  Player[i]=new Player();
		  Player[i].name=st.nextToken();
		  Player[i].score=Integer.parseInt(st.nextToken());
	  }
	 
	  Arrays.sort(Player,check.desc);
	  for(int i=0;i<Player.length;i++)
	  {
			System.out.printf("%s %s\n",Player[i].name,Player[i].score);
	  }

		
    }
}
