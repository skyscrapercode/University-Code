#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double lastSalary, yearsOfService, retirementBonus;
	cout<<"What is your last salary: ";
	cin>>lastSalary;
	cout<<"How many years of service: ";
	cin>>yearsOfService;
	
	if (yearsOfService <= 10)
	{
		retirementBonus = (lastSalary * 10.0/100) * yearsOfService;	
	}
	else if (yearsOfService >= 10 && yearsOfService <= 15)
	{
		retirementBonus = (lastSalary * 20.0/100) * yearsOfService;	
	}
	else if (yearsOfService > 15)
	{
		retirementBonus = (lastSalary * 30.0/100) * yearsOfService;	
	}
	else
	{
		cout<<"Wrong input";
		return 0;
	}
	
	cout<<"Your retirement bonus is RM"<<retirementBonus;
}
