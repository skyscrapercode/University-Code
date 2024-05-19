#include <iostream>
#include <math.h>
#include <string.h>

using namespace std;

int main()
{
	double price;
	char activity[20];
	cout<<"Enter Activity (Waterpark / Indoor Game / Mint Zoo): ";
	cin.getline(activity, 20);
	
	if (strcmp(activity, "Waterpark") == 0)
	{
		price = 20;
	}
	else if (strcmp(activity, "Indoor Game") == 0)
	{
		price = 50;
	}
	else if (strcmp(activity, "Mint Zoo") == 0)
	{
		price = 60;
	}
	else
	{
		cout<<"Enter the correct activity!!";
		return 0;
	}
	
	cout<<"The activity is "<<activity<<endl;
	cout<<"The price is RM"<<price;
	return 0;
}
