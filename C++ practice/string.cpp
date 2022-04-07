#include <iostream>

using namespace std;

void display(char s[])
{
    cout << "Entered char array is: " << s << endl;
}

void display(string s)
{
    cout << "Entered string is: " << s << endl;
}


int main()
{
    string str1;
    char str2[100];
    cout << "Enter a string: ";
    getline(cin, str1);
    cout << "Enter another string: ";
    cin.get(str2, 100, '\n');
    display(str1);
    display(str2);
    return 0;
}


