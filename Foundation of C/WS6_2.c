#include <stdio.h>

void add(float arr[], int *n){
	float input;
	printf("Enter a value : ");
	scanf("%f%*c",&input);
	arr[*n] = input;
	*n = *n + 1;
}

void print_exist(float arr[], int n){
	int i,exist=0;
	float input;	
	printf("Enter a value : ");
	scanf("%f%*c",&input);
	for(i=0;i<n;i++)
		if(arr[i] == input)
			exist+=1;
	
	printf("Number of existences of %.3f is %d",input,exist);
}

void print_arr(float arr[], int n){
	int i;
	printf("All values of array: ");
	for(i=0;i<n;i++)
		printf("%.3f, ",arr[i]);
}

void print_between(float arr[], int n){
	int i;
	float minVal, maxVal, temp;
	printf("Enter minVal and maxVal: ");
	scanf("%f %f%*c",&minVal,&maxVal);
	if(minVal> maxVal){
		temp = minVal;
		minVal = maxVal;
		maxVal = temp;
	}
	printf("All values between %.3f and %.3f is: ",minVal,maxVal);
	for(i=0;i<n;i++){
		if(arr[i] >= minVal && arr[i] <= maxVal)
			printf("%.3f, ",arr[i]);
	}
}

void print_arr_order(float arr[], int n){
	float *ptr[100], *temp;
	int i,j;
	for(i = 0;i < n ;i++)
		ptr[i] = &arr[i];
	for(i = 0;i < n-1 ;i++)
		for(j = n-1; j > i; j--)
			if(*ptr[j] < *ptr[j-1]){
				temp = ptr[j];
				ptr[j] = ptr[j-1];
				ptr[j-1] = temp;
			}
	printf("All values of array in ascending order: ");	
	for(i = 0; i<n; i++)
		printf("%.3f, ",*ptr[i]);
}

void print_menu(){
	printf("Choose 1- Enter a value to add to array\n");
	printf("Choose 2- Find existences\n");
	printf("Choose 3- Print array\n");
	printf("Choose 4- Print values between minVal and maxVal\n");
	printf("Choose 5- Print values in ascending order\n");
	printf("Others  - Quit\n");
	printf("===========================\nChoose an option to operate: ");
}

int main(){	
	int choice,n = 0;
	float arr[100];
	do{
		system("cls");
		print_menu();
		scanf("%d%*c",&choice);
		switch(choice){
			case 1:
				add(arr,&n);
				break;	
			case 2:
				print_exist(arr,n);
				break;
			case 3:
				print_arr(arr,n);
				break;
			case 4:
				print_between(arr,n);
				break;
			case 5:
				print_arr_order(arr,n);
				break;
		}
		
		if (choice < 6 && choice > 0){
			printf("\n---\n");
			printf("Press any key to back to main menu.");
			getchar();
		}	
	}while(choice < 6 && choice > 0);
	
	return 0;
}
