#include <iostream>
#include <string.h>
#include <math.h>

using namespace std;

int main()
{
	char planet[10];
	double weight, total_weight;

	cout << "What planet would you like to compare your weight against: ";
	cin >> planet; 
	cout << "What is your weight: ";
	cin >> weight;

	if (strcmp(planet, "mercury") == 0) 
	{
		total_weight = weight * 0.37;
	}
	else if (strcmp(planet, "venus") == 0) 
	{
		total_weight = weight * 0.88;
	}
	else if (strcmp(planet, "mars") == 0) 
	{
		total_weight = weight * 0.38;
	}
	else if (strcmp(planet, "jupiter") == 0) 
	{
		total_weight = weight * 2.64;
	}
	else if (strcmp(planet, "saturn") == 0) 
	{
		total_weight = weight * 1.15;
	}
	else if (strcmp(planet, "uranus") == 0) 
	{
		total_weight = weight * 1.15;
	}
	else if (strcmp(planet, "neptune") == 0) 
	{
		total_weight = weight * 1.12;
	}
	else if (strcmp(planet, "pluto") == 0) 
	{
		total_weight = weight * 0.04;
	}
	else
	{
		cout << "You entered the wrong planet name";
		return 0;
	}

	cout << "Your weight on " << planet << " would be " << total_weight;
	return 0; 
}

