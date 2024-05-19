#include <iostream>

using namespace std;

int main()
{
	double area, length, width;
	for (int i = 0; i < 6; i++)
	{
		cout<<"What is the length: ";
		cin>>length;
		cout<<"What is the width: ";
		cin>>width;
		area = length * width;
		cout<<"The area is "<<area<<endl;
	}
	return 0;
}
