// Вид 1 (не принимает, не возвращает)

//void Method1()
//{
    //Console.WriteLine("Автор УАФ");
//}
//Method1();



// Вид 2 (принимает и возвращает)

//void Method2(string msg)
//{
    //Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

//void Method21(string msg, int count)
//{
    //int i = 0;
    //while(i < count)
    //{
        //Console.WriteLine(msg);
        //i++;
    //}
    
//}
//Method21("Текст сообщения", 4);

//Method21(count: 5, msg: "Новый текст");

// Вид 3 (не принимает, но возвращает)

//int Method3()
//{
    //return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4 (принимает и возвращает)


//string Method4(int count, string text)
//{
    
    //string result = String.Empty;

     //for (int i = 0; i < count; i++)
    //{
        //result = result + text;
    //}
    //return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

// Таблица умножения 

//for (int i = 2; i <= 10; i++)
    //{
       //for (int j = 2; j <= 10; j++)
        //{
            //Console.WriteLine($"{i} x {j} = {i*j}");
        //}
        //Console.WriteLine();
    //}
    
    // Дан текст. В нём необходимо пробелы заменить черточками,
    // маленькие к заменить на большие К,
    // большие С заменить на маленькие с.
    
    //string text = "Третья молвила сестрица, "
                //+ "- Я б для батюшки-царя "
                //+ "Родила богатыря. "
                //+ "Только вымолвить успела, "
                //+ "Дверь тихонько заскрипела, "
                //+ "И в светлицу входит царь, "
                //+ "Стороны той государь. ";

    // string s = "qwerty";
    //             012345
    // s[3] || r

    //string Replace(string text, char oldValue, char newValue)
    //{
        //string result = String.Empty;
        //int lenth = text.Length;
        //for (int i = 0; i < lenth; i++)
        //{
            //if (text[i] == oldValue) result = result + $"{newValue}";
            //else result = result + $"{text[i]}";

        //}
        //return result;
    //}
    //string newText = Replace(text, ' ', '|');
    //Console.WriteLine(newText);
    //Console.WriteLine();
    //newText = Replace(text, 'к', 'К');
    //Console.WriteLine(newText);
    //Console.WriteLine();
    //newText = Replace(text, 'с', 'С');
    //Console.WriteLine(newText);

    int[] arr = {5, 7, 9, 3, 6, 2, 8, 1, 4};

    void PrintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;

            }

            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
        Console.WriteLine();
    } 
    PrintArray(arr);
    SelectionSort(arr);
    PrintArray(arr);