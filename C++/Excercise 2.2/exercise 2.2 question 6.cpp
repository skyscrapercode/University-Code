#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double second, minute, hour;
	cout<<"Input the travel time in seconds: ";
	cin>>second;
	hour = second / 3600.0;
	minute = (second - (3600 * hour)) / 60;
	second = second - (3600 * hour) - (minute * 60);
	
	cout<<"\nTotal "<<second<<"in hours, minutes and seconds is "<<hour<<" hour, "<<minute<<" minute, and "<<second<<" second";
	
}
