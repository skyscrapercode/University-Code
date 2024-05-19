#include <iostream>

using namespace std;

int main()
{
	char input;
	int num;
	cout<<"What is your input: ";
	cin>>input>>num;
	
	for (int i = 0; i < num; i++)
	{
		for (int j = num; j > i; j--)
		{
			cout<<input;	
		}
		cout<<endl;
	}

}
