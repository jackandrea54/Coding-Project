/* This program contains 2 parts: (1) and (2)
   YOUR TASK IS TO COMPLETE THE PART  (2)  ONLY
 */
//(1)==============================================================
import java.io.*;
class MyList
 {Node head,tail;
  MyList() {head=tail=null;}
  boolean isEmpty()
   {return(head==null);
   }
  void clear() {head=tail=null;}

  void fvisit(Node p, RandomAccessFile f) throws Exception
   {if(p != null) f.writeBytes(p.info + " ");
   }

  void ftraverse(RandomAccessFile f) throws Exception
   {Node p = head;
    while(p!=null)
      {fvisit(p,f); // You will use this statement to write information of the node p to the file
       p=p.next;
      }
    f.writeBytes("\r\n");
   }

  void loadData(int k)  //do not edit this function
          
   {File f = new File("data.txt");
       if (!f.isFile()) System.out.println("not file");
        String [] a = Lib.readLineToStrArray("data.txt", k);
    int [] b = Lib.readLineToIntArray("data.txt", k+1);
    int n = a.length;
    for(int i=0;i<n;i++) addHead(a[i],b[i]);
   }

//===========================================================================
//(2)===YOU CAN EDIT OR EVEN ADD NEW FUNCTIONS IN THE FOLLOWING PART========
//===========================================================================
  void addHead(Car x)
   {head=new Node(x,head);
    if(tail==null) tail=head;
   }
  void addHead(String xOwner, int xPrice)
   {//You should write here appropriate statements to complete this function.
        if(xOwner.charAt(0)=='B' || xPrice >100) return;
       Car x=new Car(xOwner,xPrice);
        addHead(x);
   }

  void f1() throws Exception
    {/* You do not need to edit this function. Your task is to complete the addLast  function
        above only.
     */
     clear();
     loadData(1);
     String fname = "f1.txt";
     File g123 = new File(fname);
     if(g123.exists()) g123.delete();
     RandomAccessFile  f = new RandomAccessFile(fname, "rw"); 
     ftraverse(f);
     f.close();
    }  

//==================================================================
  void f2() throws Exception
    {clear();
     loadData(4);
     String fname = "f2.txt";
     File g123 = new File(fname);
     if(g123.exists()) g123.delete();
     RandomAccessFile  f = new RandomAccessFile(fname, "rw"); 
     ftraverse(f);
     Node x = new  Node (new Car("X",1));
     //------------------------------------------------------------------------------------
     /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
        Node p=head;
      while(p!=null)
       {if(p.info.price>10){
           addHead(p.info);
           break;
       }
        p=p.next;
       }
     
    //------------------------------------------------------------------------------------
     ftraverse(f);
     f.close();
    }  

//==================================================================
  void f3() throws Exception
   {clear();
    loadData(7);
    String fname = "f3.txt";
    File g123 = new File(fname);
    if(g123.exists()) g123.delete();
    RandomAccessFile  f = new RandomAccessFile(fname, "rw"); 
    ftraverse(f);
    //------------------------------------------------------------------------------------
     /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/
       Node p=head;
      while(p!=null)
       {if((p.info.price>10) && (p.info.owner.charAt(1)== 'C')) 
       {dele(p);
        break;
       }
        p=p.next;
       }
    //------------------------------------------------------------------------------------
    ftraverse(f);
    f.close();
   }
  void dele(Node q)
 {Node f,p; f=null;p=head;
  while(p!=null)
   {if(p == q) break;
    f=p;p=p.next;
   }
  if(p==null) return;
  if(f==null)
   {head=head.next;
    if(head==null) tail=null;
    return;
   }
  f.next=p.next;
  if(f.next==null) tail=f;
 }

//==================================================================
  void f4() throws Exception
   {clear();
    loadData(10);
    String fname = "f4.txt";
    File g123 = new File(fname);
    if(g123.exists()) g123.delete();
    RandomAccessFile  f = new RandomAccessFile(fname, "rw"); 
    ftraverse(f);
    //------------------------------------------------------------------------------------
     /*You must keep statements pre-given in this function.
       Your task is to insert statements here, just after this comment,
       to complete the question in the exam paper.*/

      Node pi,pj; Car x;
       pi=head;
       while(pi!=null)
         {pj=pi.next;
          while(pj!=null)
           {if(pj.info.owner.compareTo(pi.info.owner)<0)
               {x=pi.info;pi.info=pj.info;pj.info=x;}
            pj=pj.next;
           }
         pi=pi.next;
       }

    //------------------------------------------------------------------------------------
    ftraverse(f);
    f.close();
   }

    

 }