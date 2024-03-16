using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade percentage: ");
        string grade = Console.ReadLine();
        

        int gradeN = int.Parse(grade);
        string letter = "NaN";
        
        if (gradeN < 60) {
            letter = "F";
        }
        else if (gradeN >= 60 && gradeN <= 63) {
            letter = "D-";
        }
        else if (gradeN >= 64 && gradeN <= 67) {
            letter = "D";
        }      
        else if (gradeN >= 67 && gradeN < 70) {
            letter = "D+";
        }          
        else if (gradeN >= 70 && gradeN < 74) {
            letter = "C-";
        }
        else if (gradeN >= 74 && gradeN <= 77) {
            letter = "C";
        }
        else if (gradeN >= 77 && gradeN <= 80) {
            letter = "C+";
        }                
        else if (gradeN >= 80 && gradeN < 84) {
            letter = "B-";
        }
        else if (gradeN >= 84 && gradeN < 87) {
            letter = "B";
        }
        else if (gradeN >= 87 && gradeN <= 90) {
            letter = "B+";
        }                      
        else if (gradeN >= 90 && gradeN < 94) {
            letter = "A-";
        }
        else if (gradeN >= 94) {
            letter = "A";
        }        
        else {
            Console.WriteLine("This is not a number.");
        }
        Console.WriteLine($"You have an {letter}");
        if (gradeN < 70) {
            Console.WriteLine($"You need 70 or more to pass, keep practicing and studying!");
        }
        else if (gradeN >= 70){
            Console.WriteLine("Congratulations! you passed the course, keep it up!");
        }
        

    }
}