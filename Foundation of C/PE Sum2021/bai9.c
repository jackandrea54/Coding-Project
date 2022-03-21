#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <ctype.h>
#include <stdbool.h>

// Nhap vao mot chuoi, xoa het cac ki tu và so

int main() {
	system("cls");
	//INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
	char str[100],s[100];
	scanf("%[^\n]", str); // Nhap vao chuoi
	int i,j;
	for(i=0, j=0; str[i] != '\0';i++)
		if( !(isalpha(str[i]) || isdigit(str[i])) )
			s[j++] = str[i];
			
	s[j] = '\0';
	// Fixed Do not edit anything here.
	printf("\nOUTPUT:\n");
	//@STUDENT: WRITE YOUR OUTPUT HERE:
	printf("%s\n", s); // In ra chuoi sau khi xoa
	



  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
