#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double bonus, employeePay, bonuspay = 0, years;
	cout<<"What is your pay: ";
	cin>>employeePay;
	cout<<"How many years you been working here: ";
	cin>>years;

	if (employeePay > 0 && employeePay < 500.00)
	{
		bonus = 15.0/100;
	}
	else if (employeePay > 500.00 && employeePay < 1000.00)
	{
		bonus = 7.5/100;
	}
	else 
	{
		bonus = 5.0/100;
	}
	if (years > 10)
	{
    bonuspay = employeePay + 200.00 + (employeePay * bonus);
	}
	else 
	{
    bonuspay = employeePay + (employeePay * bonus);
	}

	
	cout<<"Your current income is RM"<<employeePay<<" and you will receive "<<bonus*100<<"% bonus. Your new pay is RM"<<bonuspay;
	
	return 0;
	
}

