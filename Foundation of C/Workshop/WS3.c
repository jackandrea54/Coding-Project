#include <stdio.h>

void printMinMaxDigits(int n){   
	int digit; 
    int min, max ;  
    max=0;
    min = n%10;
    while (n>0){
		digit = n%10;
	    n=n/10;
	    if (min > digit) min=digit; 
	    if (max < digit) max=digit;
    }
   	printf("Max min la: %d %d",max,min);
}

int main() {
	int n;
	do{
		printf("Nhap n: ");
		scanf("%d",&n);
	}
	while(n<=0);
	printMinMaxDigits(n);
    return 0;
}

