#include <iostream>

using namespace std;

int main()
{
	int num, sum = 0, i = 0, largest, smallest;
	
	cout<<"\nEnter number you want to add, and enter -999 to stop: ";
	cin>>num;
	
	largest = num;
	smallest = num;
	
	while(num != -999)
	{
		sum = sum + num;
		i++;
		
		if (num > largest)
		{
			largest = num;
		}
		
		if (num < smallest)
		{
			smallest = num;
		}
		
		cout<<"\nEnter number you want to add, and enter -999 to stop: ";
		cin>>num;
	}
	
	cout<<"\nThe number of looping is "<<i;
	cout<<"\nThe sum of the numbers you entered is "<<sum;
	cout<<"\nThe average of number you entered is "<<sum / i;
	cout<<"\nThe largest of number you entered is "<<largest;
	cout<<"\nThe smallest of number you entered is "<<smallest;
}
