#include <stdio.h>
#include <string.h>
void sortArr( int quantity[], char name[][21], int n){
	int i,j;
	int quantemp[10]
	int c[21];
	for(i=0;i < n-1;i++)
		for(j = n-1;j > i; j--){
			// Bubble sort unfinished
			if(quantity[j] > quantity[j-1]){
				strcpy(quantemp,quantity[j]);
				
				
				
			}
		}
}

int main(){
	FILE *fp = NULL;
	int quantity[10],n=0,i;
	char name[10][21];
	fp = fopen("inp.txt","r");
	while(fscanf(fp, "%d %20[^\n]%*c", &quantity[n], name[n]) != EOF)
		n++;
	fclose(fp);
	
	fp = fopen("out.txt", "w");
	sortArr(quantity,name,n);
	for(i=0;i < n;i++)
		printf("%d %s\n",quantity[i],name[i]);
	fclose(fp);
	
}
