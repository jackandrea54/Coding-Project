/*
Assignment 2 - IIncome tax bill and summary report with Files
Class ID : SE1716
Student ID : HE172579
Student Name : Nguyen Dinh Nghia
Due Date : 27 March 2022
I declare that this assignment is my own work
in accordance with FPT Policy.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define personal_allowance 4000
#define pension_rate 0.05
#define insurance_rate 0.01
#define dependant_rate 1600
#define TAX_RATE1 0.05
#define TAX_RATE2 0.1
#define TAX_RATE3 0.15
#define TAX_RATE4 0.2
#define TAX_RATE5 0.25
#define TAX_RATE6 0.3
#define TAX_RATE7 0.35

// Print error message (Finished)
void errorMess(){
	printf("Invalid input, try again.\n");
}

// Clear buffer until a newline (Finished)
void clear(){
	while(getchar() != '\n');
}

//Check if request is yes or no (Finished)
int checkRequest(){
	char request;
	do{
		printf("Do you want to continue (y/n)?: ");
		scanf("%c",&request);
		if(request != 'Y' && request != 'y' && request != 'N' && request != 'n')
			printf("You must press 'Y' or 'N' only, try again\n");
		clear();
	}while(request != 'Y' && request != 'y' && request != 'N' && request != 'n');
	if(request == 'Y' || request == 'y') return 1;
	else return 0;
}

// Check if input is yes or no 
int checkYN(char request){
	if(request != 'Y' && request != 'y' && request != 'N' && request != 'n'){
		printf("You must press 'Y' or 'N' only, try again\n\n");
		return -1;
	}
	else if(request == 'Y' || request == 'y') return 1;
	else if(request == 'N' || request == 'n') return 0;
} 

// Check if input is integer
int checkInt(){
	int num=0;
	char c;
	scanf("%d%c",&num,&c);
	if(c != '\n'){
		errorMess();
		clear();
		return -1;
	} 
	else if(num<0){
		printf("Please input a positive integer!\n\n");
		return -1;
	}
	else
		return num;
}

//Check if input is float
float checkFloat(){
	float num=0;
	char c;
	scanf("%f%c",&num,&c);
	if(c != '\n'){
		errorMess();
		clear();
		return -1;
	} 
	else if(num<0){
		printf("Please input a positive number!\n\n");
		return -1;
	}
	else
		return num;
}


// Print the menu (Finished)
void print_menu(){
	printf("Choose one of the following options:\n");
	printf("1. Load data from file\n");
	printf("2. Enter a list of taxpayers\n");
	printf("3. Save data to file \n");
	printf("4. Display tax information\n");
	printf("5. Save tax information to file \n");
	printf("6. Search a taxpayer by code \n");
	printf("7. Sort by code \n");
	printf("0. Exit \n");
	printf("Your selection <0 -> 7>: ");
}

// Count the taxable income, tax income and net income (Finished)
void count_tax(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	int deduction = personal_allowance;
	
	// Count taxable income
	deduction += dependant_rate * depend[n] + charity[n];
	if(pens[n] == 'Y') deduction += (float)income[n] * pension_rate;
	if(ins[n] == 'Y') deduction += (float)income[n] * insurance_rate;
	if(income[n] > deduction) taxable[n] = income[n] - deduction;
	else taxable[n] = 0;
	
	// Count tax amount
	if(taxable[n] <= 5000) tax[n] = taxable[n] * TAX_RATE1;
	else if(taxable[n] <= 10000) tax[n] = 5000 * TAX_RATE1 + (taxable[n] - 5000) * TAX_RATE2;
	else if(taxable[n] <= 18000) tax[n] = 5000 * TAX_RATE1 + 5000 * TAX_RATE2 + (taxable[n] - 10000) * TAX_RATE3;
	else if(taxable[n] <= 32000) tax[n] = 5000 * TAX_RATE1 + 5000 * TAX_RATE2 + 8000 * TAX_RATE3 + (taxable[n] - 18000) * TAX_RATE4;
	else if(taxable[n] <= 52000) tax[n] = 5000 * TAX_RATE1 + 5000 * TAX_RATE2 + 8000 * TAX_RATE3 + 14000 * TAX_RATE4 + (taxable[n] - 32000) * TAX_RATE5;
	else if(taxable[n] <= 80000) tax[n] = 5000 * TAX_RATE1 + 5000 * TAX_RATE2 + 8000 * TAX_RATE3 + 14000 * TAX_RATE4 + 20000 * TAX_RATE5 + (taxable[n] - 52000) * TAX_RATE6;
	else tax[n] = 5000 * TAX_RATE1 + 5000 * TAX_RATE2 + 8000 * TAX_RATE3 + 14000 * TAX_RATE4 + 20000 * TAX_RATE5 + 28000 * TAX_RATE6 + (taxable[n] - 80000) * TAX_RATE7;
	
	// Count net income
	net[n] = income[n] - tax[n];
}

// Load data from file tax.txt (Finished)
void load_data(int *n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	int i=0;
	char input[100],request = 'y';
	char check[] = "tax.txt";
	FILE *readfile = NULL;
	
	printf("Enter file name (tax.txt): ");
	scanf("%[^\n]%*c",input);
	
	if(strcmp(input,check) != 0)
		printf("File %s not found.",input);
	else{
		if(*n != 0){
			printf("Current data will be replaced by loaded data.\n");
			if(checkRequest() == 0) request = 'N';
		}
		if(request == 'y'){
			*n = 0; // Reset index to 0
			readfile = fopen("tax.txt","r");
			while(fscanf(readfile, "%d |%7s |%d | %c | %c |%d |%d%*c",&code[*n], &name[*n], &income[*n], &pens[*n], &ins[*n], &depend[*n], &charity[*n]) != EOF){
				count_tax(*n,code,name,income,pens,ins,depend,charity,taxable,tax,net);						
				*n = *n+1;
			}
			fclose(readfile);	
			printf("\nLoad file successful!\n");
		}
		
	}
}

// Enter a list of taxpayers
void add(int *n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	short int check;
	int inputCode,i;
	float inputF;
	char inputC;
	do{
		// Valid taxpayer's code
		do{
			printf("\n Enter code: (press 0 to stop): ");
			inputCode = checkInt();
			//Check if code already existed
			if(inputCode != 0)
				for(i=0; i < *n && inputCode > 0;i++)
					if(code[i]==inputCode){
						printf("The code already exists, please reenter!\n");
						inputCode = -1;
					}	
		}while(inputCode < 0);
		
		if(inputCode != 0){
			//Append code
			code[*n] = inputCode;
			
			//Get name
			printf(" Enter name: ");
			scanf("%7[^\n]",&name[*n]);
			clear();
			//Get gross income
			do{
				printf(" Income for the current month (in thousand VND): ");
				income[*n] = checkFloat();
				if(income[*n]==0) errorMess();
			}while(income[*n] <= 0);
			// Pension contributions
			do{
				printf(" Pension contributions (5%%) y/n?: ");
				scanf("%c",&inputC);
				clear();
				check = checkYN(inputC);
				if(check == 1) pens[*n] = 'Y';
				else if(check == 0) pens[*n] = 'N';				
			}while(check == -1);
			
			// Health insurance
			do{
				printf(" Health insurance (1%%) y/n ?: ");
				scanf("%c",&inputC);
				clear();
				check = checkYN(inputC);
				if(check == 1) ins[*n] = 'Y';
				else if(check == 0) ins[*n] = 'N';				
			}while(check == -1);
			
			//Dependent children
			do{
				printf(" Number of dependants < 18 years old: ");
				check = checkInt();
				if(check >= 0) depend[*n] = check;
			}while(check < 0);
			
			//Money for charity
			do{
				printf(" Gift of charity: ");
				charity[*n] = checkFloat();
				if(charity[*n] > income[*n]){
					printf(" Charity money more then income! Please re-enter charity money!\n");
					charity[*n] = -1;
				}	
			}while(charity[*n] < 0);
			count_tax(*n,code,name,income,pens,ins,depend,charity,taxable,tax,net);	
			*n = *n + 1;
		}	
		
	}while(inputCode != 0);
}

// Save to file tax.txt (Finished)
void save_tax(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	FILE *writefile = NULL;
	int i;
	char input[100];
	char check[] = "tax.txt";
	if(n==0) printf("You should enter data first! ");
	else{
		printf("Enter file name (tax.txt): ");
		scanf("%[^\n]%*c",input);
	
		if(strcmp(input,check) != 0)
			printf("File %s not found.",input);
		else{
			printf("Data on the file tax.txt  will be replaced by saved data.\n");
			if(checkRequest()){
				writefile = fopen("tax.txt","w");
				if(writefile != NULL){
					for(i = 0;i < n;i++){
						fprintf(writefile,"%03d  |     %-7s|%8d | %c | %c |%4d |%8d\n",code[i],name[i],income[i],pens[i],ins[i],depend[i],charity[i]);
					}
					fclose(writefile);
				}
				else{
					printf("Unable to open file");
				}
			}
		}
	}
}

// Display current data (Finished)
void display(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	int i;
	if(n==0) printf("You should enter data first! ");
	else{
		printf(" Code  name     income  pens  ins  depend  charity  taxable   tax    net\n");
		printf("--------------------------------------------------------------------------\n");
		for(i=0;i<n;i++)
			printf(" %03d  %-7s%8d    %c     %c    %2d%10d%9d%8d%8d\n",code[i],name[i],income[i],pens[i],ins[i],depend[i],charity[i],taxable[i],tax[i],net[i]);	
	}
}

// Save to file report.txt (Finished)
void save_report(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	FILE *writefile;
	int i;
	if(n==0) printf("You should enter data first! ");
	else{
		printf("Data on the file report.txt  will be replaced by saved data.\n");
		if(checkRequest()){
			writefile = fopen("report.txt","w");
			if(writefile != NULL){
				fprintf(writefile," Code  name     income  pens  ins  depend  charity  taxable   tax    net\n--------------------------------------------------------------------------\n");
				for(i = 0;i < n;i++)
					fprintf(writefile," %03d  %-7s%8d    %c     %c    %2d%10d%9d%8d%8d\n",code[i],name[i],income[i],pens[i],ins[i],depend[i],charity[i],taxable[i],tax[i],net[i]);	
				fclose(writefile);
			}
			else
				printf("Unable to open file");		
		}
	}
}

// Search a taxpayer by code (Finished)
void search(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	int input,i,index=-1;
	int deduction = personal_allowance;
	if(n==0) printf("You should enter data first!");
	else{
		//Check input code
		do{
			printf("Enter code to be searched: ");
			input = checkInt();
		}while(input == -1);
		// Search
		for(i=0;i<n;i++){
			if(code[i]==input)
				index = i;
		}
		if(index == -1) printf("\n\nCode not found!\n");
		else{
			printf("\nFound at position %d:\n\n",index);
			printf("Code:                          	%-03d\n",code[index]);
			printf("Name:                        	%-7s\n",name[index]);
			printf("Gross income:                   %-10.1f\n",(float)income[index]);
			printf("Deduction:\n");
			printf("    Personal allownace:         %-.1f\n",(float)personal_allowance);
			if(pens[index]== 'Y'){
				printf("    Pension contributions:      %-.1f\n",(float)income[index]*pension_rate);
				deduction += income[index]*pension_rate;
			}	
			else printf("    Pension contributions:      %-.1f\n",0);
			if(ins[index]== 'Y'){
				printf("    Health insurance:           %-.1f\n",(float)income[index]*insurance_rate);
				deduction += income[index]*insurance_rate;
			}
			else printf("    Health insurance:           %-.1f\n",0);
			printf("    Dependant:                  %.1f\n",(float)depend[index]);
			deduction += (float)depend[index]*dependant_rate;
			printf("    Charity:                    %.1f\n",(float)charity[index]);
			deduction += (float)charity[index];
			printf("---------------------------------------------------\n");
			printf("Total:                          %.1f\n",(float)deduction);	
			printf("Taxable Income:                 %.1f\n",(float)taxable[index]);
			printf("Tax:                            %.1f\n",(float)tax[index]);
			printf("Net:                            %.1f\n",(float)net[index]);
		}
		
	}
	
	
	
}

// Print the list sorted by taxpayers' codes (Finished)
void sorted_print(int n, int code[], char name[][8], int income[], char pens[], char ins[], int depend[], int charity[], int taxable[], int tax[], int net[]){
	int i,j,index[100],temp;
	for(i=0;i<n;i++){
		index[i] = i;
	}
	for(i=0;i < n - 1;i++)
		for(j = n - 1; j > i; j--){
			if(code[index[j]]<code[index[j-1]]){
				temp = index[j];
				index[j] = index[j-1];
				index[j-1] = temp;
			}
		}
	printf(" Code  name     income  pens  ins  depend  charity  taxable   tax    net\n");
	printf("--------------------------------------------------------------------------\n");
	for(i=0;i < n;i++)
		printf(" %03d  %-7s%8d    %c     %c    %2d%10d%9d%8d%8d\n",code[index[i]],name[index[i]],income[index[i]],pens[index[i]],ins[index[i]],depend[index[i]],charity[index[i]],taxable[index[i]],tax[index[i]],net[index[i]]);
}

int main(){
	int choice,n=0;
	int code[100], depend[100], charity[100],income[100],taxable[100],tax[100],net[100];
	char name[100][8], pens[100], ins[100],check;
	do
	{
		system("cls"); // for windows
		print_menu();
		scanf("%d%c", &choice,&check);
		if(check != '\n'){
			printf("**Invalid input! Please try again!\n");
			clear();
		}
		else if(choice < 0){
			printf("**Invalid input! Please try again!\n");
		}
		else{
			switch(choice)
			{
				case 1:
					load_data(&n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 2:
					add(&n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 3:
					save_tax(n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 4:
					display(n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 5:
					save_report(n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 6:
					search(n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;
				case 7:
					sorted_print(n,code,name,income,pens,ins,depend,charity,taxable,tax,net);
					break;			
			}
		}
		if (choice != 0){
			printf("\n\n---\n");
			printf("Press any key to back to main menu...\n");
			getchar();
		}
		
	}
	while (choice != 0);

	
	return 0;
}
