#include <stdio.h>
#include <string.h>

void clear(){
	while(getchar() != '\n');
}

void add(char code[][9], char name[][21], double salary[], double allow[], int *n ){
	printf("Enter employee code: ");
	scanf("%8[^\n]", &code[*n]);
	clear();
	printf("Enter employee name: ");
	scanf("%20[^\n]", &name[*n]);
	clear();
	printf("Enter employee salary: ");
	scanf("%lf", &salary[*n]);
	clear();
	printf("Enter employee allowance: ");
	scanf("%lf%*c", &allow[*n]);
	*n = *n + 1;
}

void find(char code[][9], char name[][21],double salary[], double allow[], int n ){
	char input[21];
	int i,check = 0;
	printf("Enter employee name: ");
	scanf("%20[^\n]",&input);
	clear();
	for(i=0;i<n;i++)
		if(strcmp(input,name[i])==0){
			printf("    Code|                Name|              Salary|           Allowance\n");
			printf("%8s|%20s|%20.3lf|%20.3lf",code[i],name[i],salary[i],allow[i]);
			check = 1;
			break;
		}
	if(check == 0)
		printf("--Not found--\n");
}

void removeEmp(char code[][9], char name[][21],double salary[], double allow[], int *n ){
	char input[9];
	int i,j;
	printf("Enter employee code: ");
	scanf("%8[^\n]",&input);
	clear();
	for(i = 0; i < *n;i++){
		if(strcmp(input,code[i])==0){
			for(j = i; j < *n-1;j++){
				strcpy(code[j],code[j+1]);
				strcpy(name[j],name[j+1]);
				salary[j] = salary[j+1];
				allow[j] = allow[j+1];
			}
			*n = *n - 1;
		}		
	}
	
}

void print_descend(char code[][9], char name[][21],double salary[], double allow[], int n ){
	int i;
	double sum[100];
	for(i=0;i<n;i++)
		sum[i] = salary[i] + allow[i];
	printf("    Code|                Name|              Salary|           Allowance\n");
	
}

void print_menu(){
	printf("Choose 1- Add a new employee\n");
	printf("Choose 2- Find data about employees\n");
	printf("Choose 3- Remove an employee\n");
	printf("Choose 4- Print the list in descending order\n");
	printf("Choose 5- Quit\n");
	printf("===========================\nChoose an option to operate: ");
}

int main(){	
	int choice, n = 0;
	char code[100][9], name[100][21];
	double salary[100], allow[100];
	do{
		system("cls");
		print_menu();
		scanf("%d%*c",&choice);
		switch(choice){
			case 1:
				add(code,name,salary,allow,&n);
				break;	
			case 2:
				find(code,name,salary,allow,n);
				break;
			case 3:
				removeEmp(code,name,salary,allow,&n);
				break;
			case 4:
				print_descend(code,name,salary,allow,n);
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
