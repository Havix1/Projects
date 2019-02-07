//Matthew Dobbs
//CSC 150 - 11 am MWF
//Assignment 5 - Printing two random numbers and identifying each as even or odd
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>

bool isOdd ( int i );
bool isEven ( int i);
void testForOdd ( int num1, int num2 );
void testForBothEven ( int num1, int num2 );
	
int main (void)
{
	
	unsigned int counter;
	unsigned int seed;
	unsigned int num1;
	unsigned int num2;

	srand(time(NULL));

	// loop 10 times
	for ( counter =1; counter <=10; ++counter )
	{ // begin for

		num1 = 1 + (rand() % 10);
		num2 = 1 + (rand() % 10);
		printf( "\nThe two random numbers are %d and %d\n ", num1, num2);
		
		
		testForOdd( num1, num2);
		testForBothEven( num1, num2);
	}// end for
}

bool isOdd (int i)
{
if( i % 2 == 0){
	return false;
	}
	else{
	return true;
	}
} // end function is even

bool isEven (int i)
{
if( i % 2 == 0) 
	{
	return true;
	}//end if
	else
	{
	return false;
	}//end else
} // end function is even

void testForOdd ( int num1, int num2 )
{
	if( isOdd( num1 ) && isOdd(num2))
		printf( "Both of these numbers %d and %d are odd.\n");
		
	else if( isOdd(num1 ) || isOdd(num2))
		printf( "At least one of these numbers, %d and %d, is odd.\n",num1,num2);	
	
}

void testForBothEven( int num1, int num2 )
{
	if( isEven( num1 ) && isEven(num2))
		printf( "Both numbers of these numbers, %d and %d are even.\n",num1,num2);
		
	
}


