#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double hour, wage, over40; 
	cout<<"Input the amount of hours you worked: ";
	cin>>hour;
	if (hour <= 40)
	{
		wage = 8.00 * hour;
		cout<<"Your wage is RM"<<wage;
	}
	else if (hour > 40 )
	{
		over40 = (hour - 40) * 12.00;
	    wage = 320.00 + over40;
		cout<<"Your wage is RM"<<wage;
	}
	
	return 0;
		
		
}

