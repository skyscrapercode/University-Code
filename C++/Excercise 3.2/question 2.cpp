#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double years;
	cout<<"How many years have you worked: ";
	cin>>years;
	
	if (years == 0)
	{
		cout<<"You have 0 week of vacation";
	}
	else if (years > 0 && years < 5)
	{
		cout<<"You have 1 week of vacation";
	}
	else if (years > 5 && years < 11)
	{
		cout<<"You have 2 weeks of vacation";
	}
	else if (years > 11)
	{
		cout<<"You have 3 weeks of vacation";
	}
	else
	{
		cout<<"Wrong Input";
	}
	
	return 0;
}
