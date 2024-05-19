#include <iostream>
#include <math.h>

using namespace std;


using namespace std;

int main()
{
	int modelNum;

	cout << "Our TVs come in three models. We have only 3 models: 100, 200, 300\n";
	cin >> modelNum;

	cout << "That model has the following features:\n";
	switch (modelNum)
	{
	case 300:
		cout << "\tPicture-in-picture.\n"; 
		break;
	case 200:
		cout << "\tStereo sound.\n"; 
		break;
	case 100:
		cout << "\tRemote control.\n";
		break;
	default:
		cout << "You can only choose the 100, 200 and 300.\n";
		break;
	}
	return 0;
}
