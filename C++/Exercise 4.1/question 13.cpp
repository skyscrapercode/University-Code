#include <iostream>

using namespace std;

int main()
{
	int num, sum = 0, i = 0, highest, lowest;
	
	cout<<"\nEnter the volume of rain this month: ";
	cin>>num;
	
	highest = num;
	lowest = num;
	
	while(i != 12)
	{
		i++;
		
		sum = sum + num;
		
		cout<<"\nEnter the volume of rain this month: ";
		cin>>num;
		
		if (num > highest)
		{
			highest = num;
		}
		
		if (num < lowest)
		{
			lowest = num;
		}
		
	}
	
	cout<<"\nThe total volume of rain in this city is "<<sum;
	cout<<"\nThe average rain you received is "<<sum / i;
	cout<<"\nThe highest rain you received is "<<highest;
	cout<<"\nThe lowest rain you received is "<<lowest;
	cout<<"\nThis difference between the highest and lowest rain is "<<highest - lowest;
}
