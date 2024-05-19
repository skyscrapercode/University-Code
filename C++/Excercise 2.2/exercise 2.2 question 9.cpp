#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	char name[20];
	double pitem, amountTendered, changed;
	cout<<"Enter the cashier's name: ";
	cin.getline(name, 20);
	cout<<"Enter the price of item: RM";
	cin>>pitem;
	cout<<"Enter the amount tendered: RM";
	cin>>amountTendered;
	changed = amountTendered - pitem;
	cout<<"****Receipt****" <<endl;
	cout<<"Cashier Name: " <<name <<endl;
	cout<<"Price : RM" <<pitem <<endl;
	cout<<"Amount Tendered: RM"<<amountTendered <<endl;
	cout<<"Amount Changed: RM"<<changed <<endl;
}
