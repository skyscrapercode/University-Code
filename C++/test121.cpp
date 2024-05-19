#include <iostream>

using namespace std;

int main()
{
	int put, i, j;
	cin>>put;
	i=0;
	while (i<put)
	{
		j=put;
		while (j>i)
		{
			cout<<"#";
			j--;
		}
		i++;
		cout<<endl;
	}
}
