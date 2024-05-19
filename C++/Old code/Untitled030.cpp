#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int choice;
	double area, perimeter, length, width ;
	cout<<"Enter the length and width: ";
	cin>>length>>width;
	
	cout<<"Enter number (1 for area, 2 for perimeter): ";
	cin>>choice;
	
	if (choice == 1)
	{

		area = length * width;
		cout<<"The area is "<<area;
	}
	else if (choice == 2)
	{
		perimeter = (length * 2) + (width * 2);
		cout<<"The perimeter is "<<perimeter;
	}
	else
	{
		cout<<"You entered the wrong choice";
	}
		
	return 0;
}
