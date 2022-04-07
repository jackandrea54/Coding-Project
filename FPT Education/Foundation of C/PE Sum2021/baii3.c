#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <ctype.h>

// Nhap vao n phan tu, sap xep va in ra theo thu tu giam dan
void sort(int arr[], int n){
	int i,j,temp;
	for(i=0;i<n-1;i++)
		for(j=n-1; j>i;j--)
			if(arr[i] < arr[j]){
				temp = arr[i];
				arr[i] = arr[j]; 
				arr[j] = temp;
			}
}


int main() {
	system("cls");
	//INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
	int i,n,arr[100];
	scanf("%d",&n);
	
	for(i=0;i<n;i++)
		scanf("%d",&arr[i]);
	
  	sort(arr,n);
	// Fixed Do not edit anything here.
	printf("\nOUTPUT:\n");
	//@STUDENT: WRITE YOUR OUTPUT HERE:
	for(i=0;i<n;i++)
		printf("%d ",arr[i]);


  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
