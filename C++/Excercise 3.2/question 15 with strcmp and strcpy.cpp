#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char planet[20];
	double weight, planetWeight;
	
	cout<<"What is your weight: ";
	cin>>weight;
	cout<<"MERCURY, VENUS, MARS, JUPITER, SATURN, URANUS, NEPTUNE, PLUTO"<<endl;
	cout<<"Which planet would you like to compare against: ";
	cin>>planet;
	
	if (strcmp(planet, "MERCURY") == 0 )
	{
		planetWeight = weight * 0.37;
	}
	else if (strcmp(planet, "VENUS") == 0 )
	{
		planetWeight = weight * 0.88;
	}
	else if (strcmp(planet, "MARS") == 0)
	{
		planetWeight = weight * 0.38;
	}
	else if (strcmp(planet, "JUPITER") == 0)
	{
		planetWeight = weight * 2.54;
	}
	else if (strcmp(planet, "SATURN") == 0)
	{
		planetWeight = weight * 1.15;
	}
	else if (strcmp(planet, "URANUS") == 0)
	{
		planetWeight = weight * 1.15;
	}
	else if (strcmp(planet, "NEPTUNE") == 0)
	{
		planetWeight = weight * 1.12;
	}
	else if (strcmp(planet, "PLUTO") == 0 )
	{
		planetWeight = weight * 0.94;
	}
	else
	{
		cout<<"Wrong Input!";
		return 0;
	}
	
	cout<<"The planet you choose is "<<planet<<" and your weight on that planet is "<<planetWeight<<"KG";
	return 0;
}
