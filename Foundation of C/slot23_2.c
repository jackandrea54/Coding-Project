#include <stdio.h>
#include <string.h>
void sortArr( int quantity[], char name[][21], int n){
	int i,j;
	
	for(i=0;i < n-1;i++)
		for(j = n-1;j > i; j--){
			if(quantity[j] > quantity[j-1]){
				
			}
		}
}

int main(){
	FILE *fp = NULL;
	int quantity[10],n=0;
	char name[10][21];
	fp = fopen("inp.txt","r");
	while(fscanf(fp, "%d %20[^\n]%*c", &quantity[n], name[n]) == 2)
		n++;
	fclose(fp);
	
	fp = fopen("out.txt", "w");
	sortArr(quantity,name,n);
	
	
}
