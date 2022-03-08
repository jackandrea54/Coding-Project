#include <stdio.h>
#include <math.h>
int  prime(int num){
    int m = sqrt(num); 
    int i;  
    if (num<2) return 0; 
    for ( i=2; i<=m; i++) 
		if (num%i==0) return 0 ; 
    return 1; 
}


int main() {
	int n,i;
	do{
		printf("Nhap mot so N: ");
		scanf("%d",&n);
	}
	while(n<2);
	for( i = 2;i<=n;i++){
		if(prime(i)) printf("%d ",i);
	}
    return 0;
}

