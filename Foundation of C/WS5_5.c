#include <stdio.h>
#include <math.h>
int quadraticEquation(){
	double a,b,c,delta,x1,x2;
	printf("\nax^2 + bx + c = 0\n");
	printf("Nhap a b c:");
	scanf("%lf %lf %lf",&a,&b,&c);
	delta = b*b - 4*a*c;
	if(delta < 0){
		printf("There is no solution\n\n");
	}else if(delta == 0){
		printf("There is an unique solution: x1 = x2 = %lf\n\n",-b/(2*a));
	}else if (delta > 0){
		x1 = (-b+sqrt(delta))/2*a;
		x2 = (-b-sqrt(delta))/2*a;
		printf("There are two solution:\nx1 = %lf, x2 = %lf\n\n",x1,x2);
	}
	
	return 0;
}

void deposit(){
	double depo,rate,amount;
	int year;
	do{
		printf("Deposit: ");
		scanf("%lf",&depo);	
	}while(depo <= 0.0);	
	do{
		printf("Yearly rate: ");
		scanf("%lf",&rate);	
	}while(rate <= 0.0 || rate >= 1.0);
	do{
		printf("Number of year: ");
		scanf("%d",&year);	
	}while(year <= 0);	
	amount = depo*pow(1+rate,year);
	printf("Amount at the %d(th) year: %lf\n\n",year,amount);
}

int main(){
	int choice,check;
	do{
		printf("1- Quadratic equation\n");
		printf("2- Bank deposit problem\n");
		printf("3- Quit\n");
		printf("Select an operation: ");
		scanf("%d",&choice);
		switch(choice){
			case 1:
				quadraticEquation();
				printf("\n");
				break;	
			case 2:
				deposit();
				printf("\n");
				break;	
		}
	}
	while(choice > 0 && choice < 3);
	return 0;
}
