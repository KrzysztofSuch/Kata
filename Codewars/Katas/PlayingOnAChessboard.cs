using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Description:

With a friend we used to play the following game on a chessboard (8, rows, 8 columns). On the first row at the bottom we put numbers:

1/2, 2/3, 3/4, 4/5, 5/6, 6/7, 7/8, 8/9
1/3, 2/4, 3/5, 4/6, 5/7, 6/8, 7/9, 8/10
1/4, 2/5, 3/6, 4/7, 5/8, 6/9, 7/10, 8/11
1/5
1/6
1/7
1/8
1/9, 2/10, 3/11, 4/12, 5/13, 6/14, 7/15, 8/16

When all numbers are on the chessboard each in turn we toss a coin. The one who get "head" wins and the other gives him, in dollars, the sum of the numbers on the chessboard. We play for fun, the dollars come from a monopoly game!

How much can I (or my friend) win or loses for each game if the chessboard has n rows and n columns? Add all of the fractional values on an n by n sized board and give the answer as a simplified fraction.

Ruby, Python, JS, Coffee, Clojure:

The function called 'game' with parameter n (integer >= 0) returns as result an irreducible fraction written as an array of integers: [numerator, denominator]. If the denominator is 1 return [numerator].

Haskell:

'game' returns either a "Left Integer" if denominator is 1 otherwise "Right (Integer, Integer)"

Java, C#:

'game' returns a string that mimicks the array returned in Ruby, Python, JS, Coffee, Clojure.

(see Example Test Cases)

*/

namespace Katas
{
    public class PlayingOnAChessboard
    {
        public static string Game(long n)
        {

            var sum = 0;

            for(var i = 0; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i + 1;
                }
            }

            var extraTwo = "";
            if (n%2 == 1)
            {
                extraTwo = ", 2";
            }

            var output = "[" + sum + extraTwo + "]";

            return output;
        }

    }
}
