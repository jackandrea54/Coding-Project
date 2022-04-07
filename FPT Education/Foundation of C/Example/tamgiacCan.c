#include <stdio.h>
 
int main() {
   int n,i,j;
 
   n = 6;   // khai bao so hang.
 
   printf("Ve tam giac sao can:\n");
   for(i=1; i<=n; i++)
	{
		for(j=1; j<=n*2-1; j++)
		{
			if(i == n || i + j == n + 1 ||  j - i == n-1) // Dieu kien de ve tam giac rong
			{
				printf("*");
			}
			else
				printf(" ");
		}
//		if(i < n)
		printf("\n");
	}
   return 1;
}
