#include <iostream>

using namespace std;

int main()
{
	int w = 0;
	for (int i = 0; i < 4; i++)
	{
		w = 2 + w * 5 – i; // need to account for operator precedence 
		cout << w << “ “; //ans 10,9,8,7
	}
	cout << endl;
}

