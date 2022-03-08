#include <stdio.h>  
#include <math.h>
#include <ctype.h>  

double capSoCong(int n){
//	int i,tu;
//	tu = 0;
//	for(i=0;i<=n;i++){
//		tu += i;
//	}
//	sum = pow(-1,n)*((double)tu/mau);
	return n*(n+1)/2;
}

long power(int x, int y)
{
    int i;
    long p = 1;
    
    for (i = 1; i <= y; i++)
        p = p * x;
    
    return p;
}



int main()  
{  
    int n;
    double sum;
    printf("Nhap N: ");
    scanf("%d",&n);
    sum = 0;
    while(n>0){
    	if(n%2 == 0){
    		sum += capSoCong(n)/power(n,n-1);
		}
		else{
			sum -= capSoCong(n)/power(n,n-1);
			
		}
		n--;
	}
    printf("Tong la %.2lf",sum);
    
    return 0;  
}  
