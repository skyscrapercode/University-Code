#include <iostream>

using namespace std;

int main()
{
	int i = 0;
	double num = 0, num2, num3;
	while (i < 5)
	{
		cout<<"What is your number: ";
		cin>>num2;
		if (num2 < 0)
		{
			cout<<"You cannot input a negative number";
			return 0;
		}
		num = num + num2;
		i++;
	}
	num3 = num / 5;
	
	cout<<"Total = "<<num<<endl;
	cout<<"Average = "<<num3;
	
	return 0;
}
