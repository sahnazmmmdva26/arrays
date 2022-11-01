#region task1
//Ədədlərdən ibarət arrayın ən kiçik elementini tapın
int[] numbers = {2,4,21,58,1,2,32,4,15};
int min = numbers[0];
for (int i=1;i<numbers.Length;i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine(min);

#endregion
#region task2
//Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin 
int[] numbers2 = { 2, 4, 21, 58, 1, 2, 32, 4, 15 };
int count = 0;
for (int i = 0; i < numbers2.Length; i++)
{
    if (numbers2[i]<=9)
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion