#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double x1, y1, x2, y2, distance;
	cout<<"Enter the first coordinate(x,y): " ;
	cin>>x1>>y1;
	cout<<"(" <<x1<< "," <<y1<< ")" <<endl;
	cout<<"Enter the second coordinate(x,y): ";
	cin>>x2>>y2;
	cout<<"(" <<x2<< "," <<y2<< ")" <<endl;
	distance = ( pow( x2 - x1, 1.0/2) + pow( y2 - y1, 1.0/2)   ); //Can also do sqrt((pow(x2-x1,2) + pow(y2-y1,2))
	cout<<"The distance between two points is: " <<distance;
	
	
	
}
