#include <iostream>
#include <math.h>

using namespace std;

int main() 
{
	char inputChar;
	cout << "Please enter a character: ";
    cin >> inputChar;

    if (inputChar >= 'a' && inputChar <= 'z') 
	{
        cout << "The character is a small letter" <<endl;
    }
	 else if (inputChar >= 'A' && inputChar <= 'Z') 
	{
        cout << "The character is a capital letter" <<endl;
    }
	 else
	{
        cout << "The character is not a letter" <<endl;
    }

    return 0;
}

