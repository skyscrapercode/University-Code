#include <iostream>

using namespace std;

int main()
{
	int i = 0, score, student, totalScore;
	
	cout<<"How many students do you have: ";
	cin>>student;
	
	while (i < student)
	{
		cout<<"What is the score: ";
		cin>>score;
		
		if (score >= 90 && score <= 100)
		{
			cout<<"Your score is outstanding!"<<endl;
		}
		else if (score >= 60 && score <= 89)
		{
			cout<<"Your score is satisfactory"<<endl;
		}
		else if (score >= 0 && score <= 59)
		{
			cout<<"Your score is unsatisfactory"<<endl;
		}
		else
		{
			cout<<"Wrong Input!!!";
			continue;
		}
		
		totalScore = totalScore + score;
		i++;
	
	}
	
	cout<<"\nThe average score of "<<student<<" students is "<<totalScore / i;
	
}
