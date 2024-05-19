#include <iostream>
#include <iomanip>
#include <string.h>
using namespace std;

int main()
{
	double store, price;
	int i = 1;
	cout<<"What is the price: ";
	cin>>price;
	while (i <= 7)
	{
		price = price - (price * 10/100);
		cout <<"Price for day "<<setprecision(3)<< i<<" is RM"<<price<<endl;
		i++;
	}
	return 0;
}
