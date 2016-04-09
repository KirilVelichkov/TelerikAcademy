using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
sbyte  (-128 to 128)                     : signed    8-bit
byte   (0 to 255)                        : unsigned  8-bit
short  (-32,768 to 32,768)               : signed    16-bit
ushort (0 to 65,535)                     : unsigned  16-bit
int    (-2,147,483,648 to 2,147,483,648) : signed    32-bit 
uint   (0 to 4,294,967,295)              : unsigned  32-bit
long   (-9,223,372,036,854,775,808 to  ) : signed    64-bit
ulong  (0 to 18,446,744,073,709,551,615) : unsigned  64-bit

float  - 7 figures signed 32-bit
double - 15/16 figures signed 64-bit
decimal - 28/29 figures signed 128-bit

char - any unicode character - 16-bit
*/
/*
Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
Try to compile the code.
*/

class Program
{
    static void Main(string[] args)
    {
        int number1 = 52130;
        sbyte number2 = -115;
        long number3 = 4825932;
        sbyte number4 = 97;
        short number5 = -10000;
    }
}

