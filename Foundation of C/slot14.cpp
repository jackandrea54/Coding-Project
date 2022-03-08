#include <stdio.h>
#include <ctype.h>

int main(){
	int low,high,i,j;
	scanf("%d %d",&low,&high);
	printf(" ");
	for(i=low;i<=high;i++){
		printf("%4d",i);
	}
	printf("\n");
	for(i=low;i<=high;i++){
		printf("%d",i);
		for(j=low;j<=high;j++){
				printf("%4d",i*j);
		}
		printf("\n");
	}
	
}
