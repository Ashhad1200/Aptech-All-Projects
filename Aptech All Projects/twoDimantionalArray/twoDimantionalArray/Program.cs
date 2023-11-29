int[ , ] twoDArray = new int[3, 4];

twoDArray[0 , 0] = 10;
twoDArray[0 , 1] = 56;
twoDArray[0 , 2] = 85;
twoDArray[0 , 3] = 26;

twoDArray[1 , 0] = 7;
twoDArray[1 , 1] = 36;
twoDArray[1 , 2] = 33;
twoDArray[1 , 3] = 16;

twoDArray[2, 0] = 56;
twoDArray[2, 1] = 85;
twoDArray[2, 2] = 95;
twoDArray[2, 3] = 15;

Console.WriteLine("BS");

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{
        Console.Write(twoDArray[i,j] + "\t");
    }
    Console.WriteLine("\n");
}


//for (int i = 0; i < twoDArray.Length; i++)
//{
//    for (int j = i+1 ; j < twoDArray.Length; j++)
//    {
    
//    }
//}

Array.Sort(twoDArray);

Console.WriteLine("AS");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(twoDArray[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
