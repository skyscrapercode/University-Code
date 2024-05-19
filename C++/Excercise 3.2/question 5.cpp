#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double sales, income;
	cout<<"What is your monthly sales: ";
	cin>>sales;
	
	if (sales < 10000)
	{
		income = 200 + (sales * 3.0/100);
	}
	else if (sales >= 10000 && sales < 20000)
	{
		income = 250 + (sales * 5.0/100);
	}
	else if (sales >= 20000 && sales < 30000)
	{
		income = 300 + (sales * 9.0/100);
	}
	else if (sales > 30000)
	{
		income = 325 + (sales * 12.0/100);
	}
	else
	{
		cout<<"DATA ERROR";
		return 0;
	}
	
	cout<<"Your commission is RM"<<income;
	return 0;
}
