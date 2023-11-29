
//int[] numList = { 12,56,24,85,36,15,26};

//int largNum = numList[0];

//for (int i = 1; i < numList.Length; i++)
//{
//     if (numList[i] > largNum)
//    {
//       largNum = numList[i];
//    }
//}
//Console.WriteLine(largNum);

int[] numList = { 12, 56, 32, 412, 65, 32, 153, 2, 6, 2 };

int tempV ;

for (int i = 0; i < numList.Length ; i++)
{
	for (int a = i+1; a <numList.Length; a++)
	{
		if (numList[i] < numList[a] )
		{
			tempV = numList[i];
			numList[i] = numList[a];
			numList[a]= tempV;
	}
	}
}

for (int i = 0; i < numList.Length; i++)
{
	Console.WriteLine(numList[i]);
}
