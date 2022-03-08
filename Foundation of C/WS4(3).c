#include <stdio.h>

void fibonacci(int n){
	int t1=1, t2=1, f=1, i;
	if(n == 1) printf("1 \n");
	else if(n>=2) printf("1 1 ");
    for(i= 3;i<=n; i++) {
       f = t1 + t2;
       t1= t2;
       t2=f;
       printf("%d ",f); 
	};
	printf("\n\n");
}

int validDate(int d,int m, int y){
	int maxd = 31;
	if ( d<1 || d>31 || m<1 || m>12) return 0;
	if( m==4 || m==6 || m==9 || m==11){
		maxd=30;
	} 
	else if (m==2) {
	            if ( y%400==0 || ( y%4 ==0 && y%100 !=0)){
	            	maxd=29;
				}
	            else{
				 	maxd=28;
				}
	       }
	return d<=maxd;
}

void sumInt(int n){
	int i,sum = 0;
    while(i<=n){
    	sum+= i;
    	i++;
	}
	printf("Sum of %d numbers: %d\n\n",n,sum);
    return 0;

}

void swapNum(int* num1,int *num2){
	*num1 = *num1 + *num2;
	*num2 = *num1 - *num2;
	*num1 = *num1 - *num2;
}

int main(){
	int choice,n,d,m,y,num1,num2;
	do{
		printf("1- Print out the first n Fibonacci numbers\n");
		printf("2- Validate a date\n");
		printf("3- Print sum of first N interger\n");
		printf("4- Swap two numbers\n");
		printf("5- Quit\n");
		printf("Select an operation: ");
		scanf("%d",&choice);
		printf("\n");
		switch(choice){
			case 1:
				do{
					printf("Nhap N: ");
					scanf("%d",&n);
				}
				while(n<0);
				fibonacci(n);
				break;
			case 2:
				printf("Nhap Ngay Thang Nam: ");
				scanf("%d %d %d",&d,&m,&y);								
				if(validDate(d,m,y)==1) printf("It is a date.\n\n");
				else printf("It is not a valid date\n\n");
				break;	
			case 3:
				do{
					printf("Nhap N: ");
					scanf("%d",&n);
				}
				while(n<0);
				sumInt(n);
				break;
			case 4:
				do{
					printf("Nhap num1 va num2: ");
					scanf("%d %d",&num1,&num2);
				}
				while(num1 == num2);
				printf("Before Swap:\n Num1: %d  Num2: %d\n",num1,num2);
				swapNum(&num1,&num2);
				printf("After Swap:\n Num1: %d  Num2: %d\n\n",num1,num2);
				break;
		}

	}
	while(choice > 0 && choice < 5);
	
	return 0;
}
