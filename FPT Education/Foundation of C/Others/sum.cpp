#include <stdio.h>

int main(){
	int N, sum;
	sum= 0;
	printf("Enter the highest integer: ");
	scanf("%d",&N);
	for(int i=0;i<=N;i++){
		sum +=i;
	}
//	printf("The value of the series is %d \n",sum);
	
	return 0;
}
