#include <stdio.h>
int main(int argc, char **argv)
{
	/*variable definition */
	int numDays;
	int userInput;
	int numWeeks;
	int numYears;
	int tempHolder; /*will be used to store remainders of division */
	
	/*Getting user input of a number of days */
	printf("Please input the number of days: \n");
	scanf("%i", &userInput);
	
	/*calculating number of years */
	numYears = userInput / 365;
	tempHolder = userInput % 365;
	
	/*calc num weeks */
	numWeeks = tempHolder / 7;
	
	/*calc num Days */
	numDays = tempHolder % 7;
	
	/*printing results */
	printf("Years: %i \nWeeks: %i \nDays: %i \n",numYears,numWeeks,numDays);
	
	return 0;
}
