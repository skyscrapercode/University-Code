#include <iostream>
#include <string.h>

void QuizPer(double &);
void LabPer(double &);
void TestPer(double &);
void ProPer(double &);
void FinalPer(double &);

using namespace std;

int main()
{
	double totalQuiz, labAssignment, totalScore, totalProject, totalScoreFinal, totalScorePercent;
	char grade[1];
	cout<<"What is the total score of your quiz: ";
	cin>>totalQuiz;
	
	QuizPer(totalQuiz);
	
	cout<<"What is the total score of your lab assigment: ";
	cin>>labAssignment;
	
	LabPer(labAssignment);
	
	cout<<"What is the total score of all tests: ";
	cin>>totalScore;
	
	TestPer(totalScore);
	
	cout<<"What is the total score of your project: ";
	cin>>totalProject;
	
	ProPer(totalProject);
	
	cout<<"What is the total score for your final: ";
	cin>>totalScoreFinal;
	
	FinalPer(totalScoreFinal);
	
	totalScorePercent = totalQuiz + labAssignment + totalScore + totalProject + totalScoreFinal;
	
	
	if (totalScorePercent > 90 && totalScorePercent <= 100)
	{
		strcpy(grade, "A");
	}
	else if (totalScorePercent > 80 && totalScorePercent <= 90)
	{
		strcpy(grade, "B");
	}
		else if (totalScorePercent > 70 && totalScorePercent <= 80)
	{
		strcpy(grade, "C");
	}
		else if (totalScorePercent > 60 && totalScorePercent <= 70)
	{
		strcpy(grade, "D");
	}
		else if (totalScorePercent > 0 && totalScorePercent <= 60)
	{
		strcpy(grade, "F");
	}
	
	cout<<"Quiz Percentage: "<<totalQuiz<<"%"<<endl;
	cout<<"Lab Percentage: "<<labAssignment<<"%"<<endl;
	cout<<"Test Percentage: "<<totalScore<<"%"<<endl;
	cout<<"Project Percentage: "<<totalProject<<"%"<<endl;
	cout<<"Final Percentage: "<<totalScoreFinal<<"%"<<endl;
	cout<<"Total Percentage: "<<totalScorePercent<<"%"<<endl;
	cout<<"Grade: "<<grade<<endl;
	
	
}

void QuizPer(double &totalQuiz)
{
	totalQuiz = totalQuiz * 15/100;
}

void LabPer(double &labAssignment)
{
	labAssignment = labAssignment * 5/100;
}

void TestPer(double &totalScore)
{
	totalScore = totalScore * 20/100;
}

void ProPer(double &totalProject)
{
	totalProject = totalProject * 10/100;
}

void FinalPer(double &totalScoreFinal)
{
	totalScoreFinal = totalScoreFinal * 50/100;
}
