#include <iostream>

using namespace std;

int main()
{
	double interestRate, balance;
	int vacation, years;
	
	cout<<"Enter your estimated amount for vacation: ";
	cin>>vacation;
	
	cout<<"Enter your current balance: ";
	cin>>balance;
	
	cout<<"Enter interest rate (percentage): ";
	cin>>interestRate;
	
	while (balance <= vacation)
	{
		balance = balance + (balance * interestRate/100);
		years++;
		
		cout<<"It's currently "<<years<<" years and your balance is RM"<<balance<<endl;
	}
	
}
