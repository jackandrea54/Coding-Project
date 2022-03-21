#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <ctype.h>

int main () {
    char str[80] = "This is - www.tutorialspoint.com - website   ";
    const char s[3] = " -";
    char *token;
    char str_cont[80];
   
   /* get the first token */
   token = strtok(str, s);
   strcpy(str_cont,token);
   /* walk through other tokens */
    while(token!= NULL) {
       	token = strtok(NULL,s);
       	if(token != NULL)
       		strcat(str_cont,token);
    }
   
   printf("%s",str_cont);
   return(0);
}
