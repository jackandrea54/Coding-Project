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
#define TAX_RATE1 0.05
#define TAX_RATE2 0.1
#define TAX_RATE3 0.15
#define TAX_RATE4 0.2
#define TAX_RATE5 0.25
#define TAX_RATE6 0.3
#define TAX_RATE7 0.35

void print_menu(){
	printf("Choice 1");
}

int main(){
	int choice;

	do
	{
		system("cls"); // for windows
		print_menu();
		scanf("%d%*c", &choice);

		printf("INCOME TAX\n");
		printf("==============\n\n");

		switch(choice)
		{
			case 1:
//				load_data();
				break;
			case 2:
				
				break;
			case 3:
				
				break;
			case 4:
				
				break;
			case 5:
				
				break;
			case 6:
				
				break;
			case 7:
			
				break;			
		}
		
		if (choice != 0)
		{
			printf("\n\n---\n");
			printf("Press any key to back to main menu.");
			getchar();
		}
	}
	while (choice != 0);

	
	return 0;
}
