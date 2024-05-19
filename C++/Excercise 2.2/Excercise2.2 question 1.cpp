#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

int main()
{
	int radius;
	double volume;
	cout<<"Enter radius: ";
	cin>>radius;
	volume = ( 4.0 / 3 * 3.142 * pow(radius, 3) );
	cout<<"Volume of sphere : "<<volume;
	
}
