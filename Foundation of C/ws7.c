#include <stdio.h>
#include <string.h>

void add(char arr[][31], int *n){
	char input[31];
	int i,j;
	printf("Enter a student name : ");
	scanf("%30[^\n]%*c",&input);
	// Turn to uppercase
	strupr(input);
	// Remove blanks
	for (i = 0, j = 0; i <= strlen(input); i++)
	    if (input[i] != ' ')
	        input[j++] = input[i];  
	// Add     
	strcpy(arr[*n],input);
	*n = *n + 1;
}

void removeStudent(char arr[][31], int *n){
	int i,j;
	char input[31];
	printf("Remove a student name: ");
	scanf("%30[^\n]%*c",&input);
	// Turn to uppercase
	strupr(input);
	// Remove blanks
	for (i = 0, j = 0; i <= strlen(input); i++)
	    if (input[i] != ' ')
	        input[j++] = input[i];  
	// Find student then remove
	for(i = 0; i < *n; i++)
		if(strcmp(input,arr[i])==0){
			for(j=i; j < *n-1; j++)
				strcpy(arr[j],arr[j+1]);				
			*n = *n - 1;
		}	
}

void search(char arr[][31], int n){
	int i,j;
	char input[31];
	printf("Search a student name : ");
	scanf("%30[^\n]%*c",&input);
	// Turn to uppercase
	strupr(input);
	// Remove blanks
	for (i = 0, j = 0; i <= strlen(input); i++)
	    if (input[i] != ' ')
	        input[j++] = input[i];  
	
	for(i = 0; i<n; i++)
		if(strcmp(input,arr[i])==0)
			printf("The student %s is in position: %d",input,i);
}

void print_arr_order(char arr[][31], int n){
	char *ptr[100], *temp;
	int i,j;
	for(i = 0;i < n ;i++)
		ptr[i] = &arr[i];
	for(i = 0;i < n-1 ;i++)
		for(j = n-1; j > i; j--)
			if(strcmp(ptr[j],ptr[j-1]) < 0){
				temp = ptr[j];
				ptr[j] = ptr[j-1];
				ptr[j-1] = temp;
			}
	printf("All names of list in ascending order: ");	
	for(i = 0; i<n; i++){
		if(i == n-1)
			printf("%s.\n",ptr[i]);
		else
			printf("%s, ",ptr[i]);
	}	
}

void print_menu(){
	printf("Choose 1- Add a student\n");
	printf("Choose 2- Remove a student\n");
	printf("Choose 3- Search a student\n");
	printf("Choose 4- Print the list in ascending order\n");
	printf("Choose 5- Quit\n");
	printf("===========================\nChoose an option to operate: ");
}

int main(){	
	int choice, n = 0;
	char arr[100][31];
	do{
		system("cls");
		print_menu();
		scanf("%d%*c",&choice);
		switch(choice){
			case 1:
				add(arr,&n);
				break;	
			case 2:
				removeStudent(arr,&n);
				break;
			case 3:
				search(arr,n);
				break;
			case 4:
				print_arr_order(arr,n);
				break;
		}
		
		if (choice < 5 && choice > 0){
			printf("\n---\n");
			printf("Press any key to back to main menu....");
			getchar();
		}	
	}while(choice < 5 && choice > 0);
	
	return 0;
}

