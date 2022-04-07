#include <stdio.h>

int main(){
	int i,j,a,b,c;
	printf("--------------------------------------------\n");
	for(j = 1; j<=9; j+=3){
		for(i = 1; i <= 9; i++){
			a = j;
			b = j+1;
			c = j+2;
			printf("|%2d x%2d = %2d |%2d x%2d = %2d |%2d x%2d = %2d |\n",a,i,a*i,b,i,b*i,c,i,c*i);
			
		}
	printf("--------------------------------------------\n");		
	}
	return 0;
}
