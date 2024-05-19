#include <iostream>

using namespace std;

int main()
{
	int num, sum = 0, i = 0, oddNum = 0, num5 = 0;
	
	cout<<"\nEnter number you want to add, and enter 0 to stop: ";
	cin>>num;
	
	
	while(num != 0)
	{
		
		cout<<"\nEnter number you want to add, and enter 0 to stop: ";
		cin>>num;
		
		i++;
		
		if (num > 0)
		{
			sum = sum + num;
		}
		
		if (num % 2 != 0)
		{
			oddNum++;
		}

		
		if (num % 5 == 0)
		{
			num5++;
		}
		
	}
	
	cout<<"\nThe number of looping is "<<i;
	cout<<"\nThe sum of positive numbers you entered is "<<num;
	cout<<"\nThe number of odd numbers you entered is "<<oddNum;
	cout<<"\nThe numbers that can be divisible by 5 is "<<num5;
}
