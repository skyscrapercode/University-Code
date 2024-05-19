#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double discount , discountprice , discountprice2, marketprice;
	cout<<"The marketprice of the product is: ";
	cin>>marketprice;
	cout<<"Enter the product discount: ";
	cin>>discount;
	discountprice = ((discount/100.0) * marketprice);
	discountprice2 = marketprice - price;
	cout<<"The orginal selling price is "<<marketprice<< " and the discounted price is "<<price2 ;
}
