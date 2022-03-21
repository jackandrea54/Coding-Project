#include <stdio.h>
 
int main() {
   int n,i,j;
 
   n = 6;
 
   printf("Ve tam giac sao deu:\n");
   for(i = 1; i <= n; i++) {
      for(j = 1; j < i; j++)
         printf(" "); 
 
      for(j = i; j <= n; j++){
      		if(j == i || j == n || i == 1)
         		printf("* ");
         	else
         		printf("  ");
	  }
      	
 
      printf("\n");
   }
 
   return 1;
}
