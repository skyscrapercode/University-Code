#include <iostream>
#include <math.h>

double calcArea (double length, double width );  //function prototype: return value function without parameter;
double perimeter (double length, double width );

using namespace std;
int main()
{
	double length, width, area, perimeter1;
	cout<<"Enter length: ";
	cin>>length;
	cout<<"Enter Width: ";
	cin>>width;
	area = calcArea (length, width);
	perimeter1 = perimeter (length, width);
	cout<<"\nThe area is "<<area;
	cout<<"\nThe perimeter is "<<perimeter1;
}

double calcArea (double length, double width )			//define function calcArea
{
	double area;
	area = length * width;
	return area;
}

double perimeter (double length, double width )
{
	double perimeter;
	perimeter = (length * 2) + (width * 2);
	return perimeter;
}
