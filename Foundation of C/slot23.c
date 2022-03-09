#include <stdio.h>
#include <math.h>

unsigned int checkPrime(int num){
	int i;
	if(num < 2) 
		return 0;
	for(i=2; i <= sqrt(num); i++)
		if(num%i==0)
			return 0;
	return 1;
}

void printThreePrime(){
	FILE *fp;
	int n,i,count = 0;
	fp  = fopen("inp.txt", "r");
	fscanf(fp, "%d", &n);
	fclose(fp);
	fp = fopen("out.txt", "w");
	i = n + 1;
	do{
		if(checkPrime(i) == 1){
			fprintf(fp,"%d ",i);			
			count++;
		}
		i++;
	}while(count < 3);
		
	
	fclose(fp);
}


int main(){
	printThreePrime();
	
	return 0;
}
