#include <stdio.h>
#include <math.h>
int prime(int n){
	int i;
	if(n==2) return 0;
	for(i=2;i<=sqrt(n);i++){
		if(n%i == 0) return 0;
	}
	return 1;
}

void printMinMaxDigits(int n){
	int min,max,digit;
	min = max = n%10;
	while(n>0){
		digit = n%10;
		min = min < digit ? min : digit;
		max = max > digit ? max : digit;
		n = n/10;
	}
	printf("Max la: %d\n",max);
	printf("Min la: %d\n\n",min);
}


int main(){
	int choice,n;
	do{
		printf("1- Process primes\n");
		printf("2- Print min, max digit in an integer \n");
		printf("3-Quit\n");
		printf("Select an operation: ");
		scanf("%d",&choice);
		switch(choice){
			case 1:
				do{
					printf("Nhap N: ");
					scanf("%d",&n);
				}
				while(n<0);
				if(prime(n)==1) printf("It is a prime\n\n");
				else printf("It is not a prime\n\n");
				break;
			case 2:
				do{
					printf("Nhap N: ");
					scanf("%d",&n);
				}
				while(n<0);
				printMinMaxDigits(n);
				break;	
		}

	}
	while(choice > 0 && choice < 3);
	
	return 0;
}
