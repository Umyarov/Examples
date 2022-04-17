int[] array = {12, 23, 35, 431, 15, 64561, 17, 18, 93};

int max = Max(Max (array[0], array[1], array[2]),
          Max(array[3], array[4], array[5]),
          Max(array[6], array[7], array[8]));
          
Console.WriteLine(max);
