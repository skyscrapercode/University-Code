#include <iostream>
using namespace std;

int main()
{
	double costToll, TotalTollCollected = 0, tollCollected;
	int year = 0;

	cout<<"Enter Cost of the Express Way: RM";
	cin>>costToll;

	for (int i = 0; i < costToll; i++)
	{
		cout<<"Enter toll collected every year: RM";
		cin>>tollCollected;
		TotalTollCollected = TotalTollCollected + tollCollected;
		year++;
		
		if (TotalTollCollected >= costToll)
		{
			i = TotalTollCollected;
		}
		if (year >= 10)
		{
			i = costToll;
		}
	}

	if (year >= 10)
	cout<<"\nThe express way is already 10 years old!!!";
	else
	cout<<"It take "<<year<<" to reach the cost of express way";

}
