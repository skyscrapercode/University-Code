#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double dividend1,dividend2, priceOfShares, profitRate, ihsan, mubarak;
	cout<<"What is the current share price: ";
	cin>>priceOfShares;
	cout<<"How much shares does Ihsan hold: ";
	cin>>ihsan;
	cout<<"How much shares does mubarak hold: ";
	cin>>mubarak;
	
	if (ihsan < 1000)
	{
		dividend1 = priceOfShares * ihsan * (priceOfShares * 7.0/100);
	}
	else if (ihsan >= 1000)
	{
		dividend1 = priceOfShares * ihsan * (priceOfShares * 17.0/100);
	}
	
	if (mubarak <= 2000)
	{
		dividend2 = priceOfShares * mubarak * (priceOfShares * 12.0/100);
	}
	else if (mubarak > 2000)
	{
		dividend2 = priceOfShares * mubarak * (priceOfShares * 21.0/100);
	}
	
	cout<<"Ihsan owns "<<ihsan<<" shares and mubarak owns "<<mubarak<<" shares. Currently the share price is RM"<<priceOfShares<<", The devidend for ihsan is RM"<<dividend1<<" and for mubarak it is RM"<<dividend2;
}
