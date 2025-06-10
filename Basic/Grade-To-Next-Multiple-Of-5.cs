/*
HackerLand University has the following grading policy:
* Every student receives a grade in the inclusive range from 0 to 100
* Any grade less than 40 is a failing grade.

Sam is a professor at the university and likes to round each student's grade according to these rules:
* If the difference between the grade and the next 5 multiple of is less than 3, round grade up to the next multiple of 5
* If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.

Examples
* grade = 84 round to 85(85 - 84 is less than 3)
* grade = 29 do not round (result is less than 40)
* grade = 57 do not round (60 - 57 is 3 or higher)

Function Description:
gradingStudents has the following parameter(s):
    int grades[n]: the grades before rounding

Returns
    int[n]: the grades after rounding as appropriate
*/

using System;
using System.Collections.Generic;
using System.Linq;

internal class GradeToNextMultiple
{
    public static List<int> gradingStudents(List<int> grades)
    {
        return grades.Select(t => ApplyRoundOff(t)).ToList();
    }

    private static int ApplyRoundOff(int grade)
    {
        if (grade < 38)
            return grade;

        var offset = grade / 5;
        var reminder = grade % 5;

        if (reminder >= 3)
        {
            grade += 5 - reminder;
        }

        return grade;
    }

    public static void Main()
    {
        List<int> result = GradeToNextMultiple.gradingStudents(new List<int> { 73, 67, 38, 33 });
        Console.WriteLine(string.Join("\t", result));
    }
}
