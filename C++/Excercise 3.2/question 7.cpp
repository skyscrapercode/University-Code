#include <iostream>
#include <math.h>

using namespace std;

int main ()
{
	double n;
	cout<<"What is the Ricter scale number: ";
	cin>>n;
	
	if (n < 5.0)
	{
		cout<<"There's little or no damage";
	}
	else if (n <= 5.0 && n < 5.5)
	{
		cout<<"There's some damage";
	}
	else if (n <= 5.5 && n < 6.5)
	{
		cout<<"There's serious damage, walls may crack or fall";
	}
	else if (n <= 6.5 && n < 7.5)
	{
		cout<<"There's disaster, houses and buildings may collapse";
	}
	else if (n > 7.5)
	{
		cout<<"There's catastrophe, most buildings destroyed";
	}
	else
	{
		cout<<"Wrong input";
		return 0;
	}
}
