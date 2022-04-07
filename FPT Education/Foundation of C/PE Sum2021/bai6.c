#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <ctype.h>

// Nhap 1 chuoi va tra ve so chu cai, chu so, va ki tu dac biet xuat hien trong chuoi

int main() {
	system("cls");
	//INPUT - @STUDENT:ADD YOUR CODE FOR INPUT HERE:
	char s[100];
	scanf("%[^\n]",s);
	int i;
	int al, dig, spec;
	al = dig = spec = 0;
	for(i=0;s[i] != '\0';i++){
		if(isalpha(s[i]))
			al++;
		else if(isdigit(s[i]))
			dig++;
		else
			spec++;
	}
  
  
  
  
  
  
  // Fixed Do not edit anything here.
  printf("\nOUTPUT:\n");
  //@STUDENT: WRITE YOUR OUTPUT HERE:
  
	printf("%d %d %d",al,dig,spec);

  
  
  //--FIXED PART - DO NOT EDIT ANY THINGS HERE
  printf("\n");
  system ("pause");
  return(0);
}
