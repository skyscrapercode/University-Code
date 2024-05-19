#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double celsius, fahrenheit;
	cout<<"What is the temperature in fahrenheit: ";
	cin>>fahrenheit;
	celsius = ( fahrenheit - 32 ) * 5/9 ;
	cout<<"The temperature in celsius is "<<celsius<< " and in fahrenheit is "<<fahrenheit; 
}
