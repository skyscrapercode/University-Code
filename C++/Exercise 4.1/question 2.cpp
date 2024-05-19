#include <iostream>

using namespace std;

int main()
{
	int people = 9870, years = 0;
	while (people <= 30000 )
	{
		people = people + (people * 10/100);
		years++;
	}
	cout<<"It took "<<years<<" years to reach "<<people<<" population";
	return 0;
}
