#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double credit, tutionFee;
	cout<<"How many credit do you have: ";
	cin>>credit;
	
	if (credit > 0 && credit < 12)
	{
		tutionFee = credit * 250;
		cout<<"You are a part time student and your tution fee is RM"<<tutionFee;
		return 0;
	}
	else if (credit >= 12 && credit <= 20)
	{
		tutionFee = credit * 250;
		cout<<"You are a full time student and your tution fee is RM"<<tutionFee;
		return 0;
	}
	else if (credit > 20)
	{
		cout<<"The input is greater than 20";
		return 0;
	}
	else
	{
		cout<<"The input is negative";
		return 0;
	}
}
