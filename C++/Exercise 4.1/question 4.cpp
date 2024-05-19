#include <iostream>
using namespace std;

int main() 
{
    int totalPoints = 0, questionNumber = 1, points;
    char answer;
    points = 0;
    
    while (questionNumber <= 20) 
	{
        cout << "Enter answer (C for correct, W for wrong) for question " << questionNumber << ": ";
        cin >> answer;

        if (questionNumber % 2 == 0) 
		{
            if (answer == 'C') 
			{
                points = points + 3;
            } 
			else if (answer == 'W') 
			{
                points = points + 0;
            }
        } 
		else 
		{
            if (answer == 'C') 
			{
                points = points + 5;
            }
			 else if (answer == 'W') 
			{
                points = points + 0;
            }
        }
        
        questionNumber++;
    }

    cout << "Total points: " << points << endl;
    return 0;
}

