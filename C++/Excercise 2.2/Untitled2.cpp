#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double discount , price , price2, marketprice;
	cout<<"The marketprice of the product is: ";
	cin>>marketprice;
	cout<<"Enter the product discount: ";
	cin>>discount;
	price = ((discount/100) * marketprice);
	price2 = marketprice - price;
	cout<<"The orginal selling price is "<<marketprice<< " and the discounted price is "<<price2 ;
}
