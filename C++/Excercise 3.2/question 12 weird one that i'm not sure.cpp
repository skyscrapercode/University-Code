#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double tax, fund, taxedFund;
	cout<<"How much fund do you have: ";
	cin>>fund;
	
	if (fund <= 200000)
    {
        tax = fund * 10.0/100;
        taxedFund = fund - tax;
    }
    else if (fund <= 600000) 
    {
        tax = 200000 * 10.0/100 + (fund - 200000) * 15.0/100;
        taxedFund = fund - tax;
    }
    else
    {
        tax = 200000 * 10.0/100 + 400000 * 15.0/100 + (fund - 600000) * 20.0/100;
        taxedFund = fund - tax;
    }

	
	cout<<"You have RM"<<taxedFund<<", you are currently being taxed RM"<<tax;
}
