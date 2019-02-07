//Matthew Dobbs
//CSC 150 - 11 am MWF
//Assignment 6 - Using a string to scan a name and capitalize frist and last name 
#include <stdio.h> 
#define SIZE 50

// Function main begins function execution 
int main(void)
{
	int i = 1;	
	char string[SIZE]; // reserves spaces

	// read string from user
	printf( "Enter your first and last names in lower case with an _ between them" ); 
	scanf( "%s", string ); 
	printf(" You entered: %s\n", string );
	
	string[0] = string[0] - 32;
	
	while( string[i] != '_')
	{
		i++;
	}	
	
	string[i] = ' ';
	string[i + 1] = string[i + 1] - 32;

	printf(" Your name is: %s\n", string );
 
	

} // end main
