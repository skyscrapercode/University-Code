#include <iostream>
#include <math.h>

using namespace std;

int main() 
{
    int num1, num2, num3;
    cout << "Enter three numbers: ";
    cin >> num1 >> num2 >> num3;

    if(num1 >= num2 && num1 >= num3)
    {
        cout << "Largest number: " << num1;
	}
    else if(num2 >= num1 && num2 >= num3)
    {
        cout << "Largest number: " << num2;
	}
    else
    {
        cout << "Largest number is " << num3;
	}

    return 0;
}

