#include <iostream>

using namespace std;

int main()
{
	double store, pricedrop, price;
	int i = 1;
	cout<<"What is the price: ";
	cin>>price;
	while (i <= 7)
	{
		pricedrop = price - (price * 10/100);
		cout<<"Price for day "<<i<<" is RM"<<pricedrop<<endl;
		price = pricedrop;
		i++;
	}
	return 0;
}
