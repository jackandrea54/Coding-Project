#include <stdio.h>
#include <string.h>

void clear(){
	while(getchar() != '\n');
}

void add(char name[][21], char make[][21], int vol[], int price[],int dur[], int *n){
	printf("Enter soft drink name: ");
	scanf("%20[^\n]", &name[*n]);
	clear();
	printf("Enter make: ");
	scanf("%20[^\n]", &make[*n]);
	clear();
	printf("Enter volume: ");
	scanf("%d", &vol[*n]);
	clear();
	printf("Enter price: ");
	scanf("%d", &price[*n]);
	clear();
	printf("Enter duration: ");
	scanf("%d%*c", &dur[*n]);
	*n = *n + 1;
}

void makeSim(char name[][21], char make[][21], int vol[], int price[],int dur[], int n ){
	char input[21];
	int i,check = 0;
	printf("Enter a make: ");
	scanf("%20[^\n]",&input);
	clear();
	for(i=0;i<n;i++)
		if(strcmp(input,make[i])==0){
			if(check==0)
				printf("                Name|                Make|    Volume|     Price|  Duration\n");
			printf("%20s|%20s|%10d|%10d|%10d\n",name[i],make[i],vol[i],price[i],dur[i]); 
			check++;
		}
	if(check == 0)
		printf("--Not found--\n");
}

void print_between(char name[][21], char make[][21], int vol[], int price[],int dur[], int n ){
	int v1,v2,i,check=0;
	printf("Enter minimum volume: ");
	scanf("%d",&v1);
	printf("Enter maximum volume: ");
	scanf("%d%*c",&v2);	
	for(i = 0; i < n; i++)
		if(vol[i] >= v1 && vol[i] <= v2){
			if(check==0)
				printf("                Name|                Make|    Volume|     Price|  Duration\n");
			printf("%20s|%20s|%10d|%10d|%10d\n",name[i],make[i],vol[i],price[i],dur[i]); 
			check++;
		}
	if(check == 0)
		printf("--Not found--\n");
}

void print_ascend(char name[][21], char make[][21], int vol[], int price[],int dur[], int n ){
	int i,j, index[100],temp;
	double sum[100];	
	for(i=0;i<n;i++){
		index[i] = i;
	}		
	printf("                Name|                Make|    Volume|     Price|  Duration\n");
	for(i=0;i < n - 1;i++)
		for(j = n - 1; j > i; j--){
			if(vol[index[j]] < vol[index[j-1]] ){
				temp = index[j];
				index[j] = index[j-1];
				index[j-1] = temp;
			}
			else if(vol[index[j]] == vol[index[j-1]]){
					if(price[index[j]] < price[index[j-1]]){
						temp = index[j];
						index[j] = index[j-1];
						index[j-1] = temp;
					}
				}		
		}	
	for(i=0;i < n;i++)
		printf("%20s|%20s|%10d|%10d|%10d\n",name[index[i]],make[index[i]],vol[index[i]],price[index[i]],dur[index[i]]);
}

void print_menu(){
	printf("Choose 1- Add a new soft drink\n");
	printf("Choose 2- Find similar make soft drinks\n");
	printf("Choose 3- Print the list items whose volumes are between V1 and V2\n");
	printf("Choose 4- Print the list in ascending order\n");
	printf("Choose 5- Quit\n");
	printf("===========================\nChoose an option to operate: ");
}

int main(){	
	int choice, n = 0,vol[100],price[100],dur[100];
	char name[100][21], make[100][21];
	
	do{
		system("cls");
		print_menu();
		scanf("%d%*c",&choice);
		switch(choice){
			case 1:
				add(name,make,vol,price,dur,&n);
				break;	
			case 2:
				makeSim(name,make,vol,price,dur,n);
				break;
			case 3:
				print_between(name,make,vol,price,dur,n);
				break;
			case 4:
				print_ascend(name,make,vol,price,dur,n);
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
