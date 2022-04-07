#include<stdio.h> 
#include<stdlib.h>
int main()  
{ 
	int n=8;
 	int **ptr = (int**) calloc(n, sizeof(int*));
	int *temp;
	int arr[100] = {10,20,11,100,24,25,49,01},i,j;
	for(i = 0;i < n ;i++)
		ptr[i] = &arr[i];
	
	for(i = 0;i < n-1 ;i++)
		for(j = n-1; j > i; j--)
			if(*ptr[j] < *ptr[j-1] ){
				temp = ptr[j];
				ptr[j] = ptr[j-1];
				ptr[j-1] = temp;
			}
	printf("All names of list in ascending order: ");	
	for(i = 0; i<n; i++){
		if(i == n-1)
			printf("%d\n",*ptr[i]);
		else
			printf("%d, ",*ptr[i]);
	}
	return 0;
}
