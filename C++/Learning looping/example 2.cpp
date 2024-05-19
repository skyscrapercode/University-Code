#include <iostream>

using namespace std;

int main()
{
	int num, sum=0, i = 0;
	
	while (i<5) // counter controlled loop
	{
		cout<<"Enter a number: ";
		cin>>num;
		sum = sum + num;
		i++;
	}
	
	cout<<"The sum is "<<sum;
	return 0;
}
