public class Solution {
    public bool IsRobotBounded(string instructions) {
        int x = 0;
        int y = 0;
        char direction = 'N';

        for (int j = 0; j < 4; j++)
        {
            for(int i = 0; i < instructions.Length; i++)
            {
                if (instructions[i] == 'G')
                {
                    switch (direction)
                    {
                        case 'N':
                            y += 1;
                            break;
                        case 'W':
                            x -= 1;
                            break;
                        case 'S':
                            y -= 1;
                            break;
                        case 'E':
                            x += 1;
                            break;
                    }
                }
    
                if (instructions[i] == 'L')
                {
                    switch (direction)
                    {
                        case 'N':
                            direction = 'W';
                            break;
                        case 'W':
                            direction = 'S';
                            break;
                        case 'S':
                            direction = 'E';
                            break;
                        case 'E':
                            direction = 'N';
                            break;
                    }
                }
    
                if (instructions[i] == 'R')
                {
                    switch (direction)
                    {
                        case 'N':
                            direction = 'E';
                            break;
                        case 'W':
                            direction = 'N';
                            break;
                        case 'S':
                            direction = 'W';
                            break;
                        case 'E':
                            direction = 'S';
                            break;
                    }
                }

            }
        }
        return (x == 0 && y == 0) ? true : false;
    }
}
