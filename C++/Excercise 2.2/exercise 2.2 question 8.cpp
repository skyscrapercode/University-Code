#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double govtax, service_charge, price, total_price;
	cout<<"Welcome to EziPizzi Station!" <<endl;
	cout<<"Input the orginal price: RM";
	cin>>price;
	govtax = price * 10/100;
	service_charge = price * 6/100;
	total_price = price + (govtax + service_charge);
	cout<<"The total selling price is RM"<<total_price ;
}
