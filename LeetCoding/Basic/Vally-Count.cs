/*
 An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly steps, for every step it was noted if it was an uphill, U , or a downhill, D step. Hikes always start and end at sea level, and each step up or down represents a 1 unit change in altitude. We define the following terms:

    A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
    A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.

Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

Example Steps = 8, path = DDUUUUDD

The hiker first enters a valley 2 units deep. Then they climb out and up onto a mountain 2 units high. Finally, the hiker returns to sea level and ends the hike. 
 */

using System;

namespace LeetCoding.Basic;

internal class VallyCount
{
    public static int countingValleys(int steps, string path)
    {
        var pathSteps = path.ToCharArray();
        var level = 0;
        var startDown = false;
        var track = 0;

        foreach (var ch in pathSteps)
        {
            track += ch == 'U' ? 1 : -1;
            if (track < 0)
            {
                startDown = true;
            }

            if (startDown && track == 0)
            {
                level++;
                startDown = false;
            }
        }
        return level;
    }

    public static void Main(string[] args)
    {
        int steps = 8;
        string path = "UDDDUDUU";

        int result = VallyCount.countingValleys(steps, path);
        Console.WriteLine(result);
    }
}
