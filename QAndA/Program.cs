








//Console.WriteLine(increasing_array(new int[] { 3, 2, 5, 1, 7 }));//5
//Console.WriteLine(increasing_array(new int[] { 1, 1, 1, 1 }));//0
//Console.WriteLine(increasing_array(new int[] { 5, 4, 3, 2, 1 }));//10
//Console.WriteLine(increasing_array(new int[] { 1, 2, 3, 4, 5 }));//0
//static int increasing_array(int[] arr)
//{
//    int points = 0;
//    for (int i = 1; i < arr.Length; i++)
//    {
//        while (arr[i] < arr[i - 1])
//        {
//            arr[i]++;
//            points++;
//        }
//    }
//    return points;
//}


//Console.WriteLine(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }));
//Console.WriteLine(TotalPoints(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }));
//Console.WriteLine(TotalPoints(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }));



//static int TotalPoints(string[] games)
//{
//    int points = 0;

//    foreach (var item in games)
//    {

//        points += Convert.ToInt64(item[0]) > Convert.ToInt64(item[item.Length - 1]) ?
//                  3 : Convert.ToInt64(item[0]) < Convert.ToInt64(item[item.Length - 1]) ?
//                  0 : 1;
//    }

//    return points;
//}




















//int[][] data = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
//Console.WriteLine(data[0].Length);
//IEnumerable<string> _queryParameters = OpenOrSenior(data);

//foreach (var item in _queryParameters)
//{
//    Console.Write(item + " ");
//}


//static IEnumerable<string> OpenOrSenior(int[][] data)
//{
//    List<string> result = new List<string>();

//    for (int i = 0; i < data.Length; i++)
//    {
//        for (int j = 0; j < data[i].Length - 1; j++)
//        {
//            if (data[i][j] >= 55 & data[i][j + 1] > 7)
//            {
//                result.Add("Senior");
//            }
//            else
//            {
//                result.Add("Open");
//            }
//        }

//    }
//    return result;
//}






//Console.WriteLine(ReplaceWithAlphbetPostion("The sunset sets at twelve o' clock."));
//Console.WriteLine(ReplaceWithAlphbetPostion("The narwhal bacons at midnight."));


//static string ReplaceWithAlphbetPostion(string text)
//{

//    if (string.IsNullOrEmpty(text))
//        return "error";

//    string newText = string.Empty;

//    for (global::System.Int32 i = 0; i < text.Length; i++)
//    {
//        if (text[i] >= 'A' && text[i] <= 'z')
//        {
//            newText += BinarySearch(char.ToLower(text[i])).ToString();
//            if (i != text.Length - 1)
//                newText += " ";
//        }
//    }

//    return newText;
//}


//static int BinarySearch(char c)
//{
//    char[] alphabetArray = {
//            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
//            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
//        };
//    int left = 0;
//    int right = alphabetArray.Length - 1;
//    int middle;



//    while (left <= right)
//    {
//        int mid = left + (right - left) / 2;

//        // Check if target is present at mid
//        if (alphabetArray[mid] == c)
//        {
//            return mid + 1;
//        }

//        // If target greater, ignore left half
//        if (alphabetArray[mid] < c)
//        {
//            left = mid + 1;
//        }
//        // If target is smaller, ignore right half
//        else
//        {
//            right = mid - 1;
//        }
//    }
//    return -1;

//}


//string[] words = new string[] { "eye", "12321", "level", "was it a cat i saw" };
//string[] words2 = new string[] { "Dubi", "amman", "cairo", "fas" };

//string text = "was it a cat i saw";
//Console.WriteLine(text.Replace(" ", ""));
//Console.WriteLine(reverse(text));
//Console.WriteLine(longestPlaindrome(words));
//Console.WriteLine(longestPlaindrome(words2));


//static string longestPlaindrome(string[] words)
//{
//    string? longestPlaindrome = null;

//    foreach (var item in words)
//    {
//        if (isPlaindrome(item))
//        {
//            if (longestPlaindrome == null)
//            {
//                longestPlaindrome = item;
//            }

//            if (longestPlaindrome.Length < item.Length)
//            {
//                longestPlaindrome = item;
//            }

//        }
//    }

//    return longestPlaindrome == null ? "-1" : longestPlaindrome;

//}


//static bool isPlaindrome(string text)
//{
//    return text.Replace(" ", "") == reverse(text);
//}

//static string reverse(string text)
//{
//    if (text == null)
//        return "text is null";

//    string reverseText = string.Empty;

//    for (global::System.Int32 i = text.Length - 1; i >= 0; i--)
//    {
//        reverseText += text[i];
//    }
//    return reverseText.Replace(" ", "");

//}


//static int nonRepeatingChar(string text)
//{
//    int targtIndex = 0;
//    bool nonRepeatingFlag = true;

//    for (int i = 0; i < text.Length; i++)
//    {

//        char currentChar = text[i];

//        for (int j = 0; j < text.Length; j++)
//        {
//            if (targtIndex == j)
//                continue;

//            if (text[j] == currentChar)
//            {
//                nonRepeatingFlag = false;
//            }

//        }

//        if (nonRepeatingFlag)
//        {
//            return targtIndex;
//        }

//        targtIndex++;
//        nonRepeatingFlag = true;

//    }

//    return -1;
//}