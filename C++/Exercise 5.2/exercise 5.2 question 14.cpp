#include <iostream>

void SumOfNumbers(int);

using namespace std;

int main()
{
	int num, odd, even;
	cout<<"How many number would you like to add: ";
	cin>>num;
	
	SumOfNumbers(num);
	
	cout<<"The sum of all odd numbers is "<<odd<<endl;
	cout<<"The sum of all even number is "<<even<<endl;
}

void SumOfNumbers(int num, int &odd, int &even)
{
	int i = 0, num2;
	while (i < num)
	{
		cout<<"Insert Number: ";
		cin>>num2;
		if (num2 % 2)
		{
			even++;
		}
		else
		{
			odd++;
		}
		i++;
	}
}
