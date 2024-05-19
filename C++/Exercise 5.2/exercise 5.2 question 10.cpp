#include <iostream>

double SumofNumbers(int);

using namespace std;

int main()
{
	int n;
	double sum;
	cout<<"How many number would you like to add: ";
	cin>>n;
	sum = SumofNumbers(n);
	cout<<"The sum of those numbers is "<<sum<<endl;
}

double SumofNumbers(int n)
{
	double i = 0, num, total;
	cout<<"Insert Number: ";
	cin>>num;
	while (i < n)
	{
		num = num + i;
		total += num;
		i++;
		cout<<num<<endl;
	}
	return total;
}
