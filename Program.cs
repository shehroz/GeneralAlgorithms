using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GenericAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] array = { 2, 7, 11, 15 };
            ////int sum = 9;

            //int[] array = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            //int sum = 542;

            //int[] res = TwoSumClass.TwoSum(array, sum);
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}




            //int[] Array = { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 };
            //int[] res = SumofThreeConsecutiveNumbersClass.SumofThreeConsecutiveNumbers(Array,16);
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}


            //int[] Array = { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 } ;
            //int MaxSum = SumofThreeConsecutiveNumbersClass.FindMaxSumSubArray(Array, 3);
            //Console.WriteLine("Max Sum of Array is :[" + MaxSum + "]");

            //int[] Array = { 4, 2, 2, 7, 8, 1, 2, 8, 10 };
            //int SmallestSubArray = SumofThreeConsecutiveNumbersClass.SmallestSubArray(8,Array);
            //Console.WriteLine("Smallest Sub Array:[" + SmallestSubArray + "]");

            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            ////int[] arr = { 0,0, 0, 0 };
            ////int[] arr = { -1, 0, 1, 2, -1, -4 };
            //IList<IList<int>> res = ThreeSumClass.ThreeSum(arr);
            //for (int i = 0; i < res.Count; i++)
            //{
            //    //for (int j = 0; j < res[i].Count; j++)
            //    //{
            //    //    Console.WriteLine("Row:["+(i+1)+"] column:["+(j+1)+"] value is :["+res[i][j]+"]");
            //    //}
            //    Console.WriteLine("Row:[" + (i + 1) + "] column:[" + res[i][0] + "," + res[i][1] + "," + res[i][2] + "]");
            //}

            //string str = "{[()]}";
            //string str = "(]";
            //string str = "]";
            //if (ValidParenthesisClass.IsValid(str))
            //    Console.WriteLine("Stack is Valid");
            //else
            //    Console.WriteLine("Stack is not valid");



            //int x = 121;
            //if (PalindromeClass.IsValidIntegerPalindrome(121))
            //    Console.WriteLine("Valid Palindrome");
            //else
            //    Console.WriteLine("Invalid Palindrome");

            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int maxSum = SumofThreeConsecutiveNumbersClass.MaxSubArray(arr);
            //Console.WriteLine(maxSum);

            //string hayStack = "aaaaa";
            //string needle = "ll";
            //string hayStack = "hello";
            //string needle = "ll";
            //string hayStack = "a";
            //string needle = "";
            //string hayStack = "mississippi";
            //string needle = "issip";
            //string hayStack = "mississippi";
            //string needle = "issipi";
            //int index=StrStrClass.StrStr(hayStack, needle);
            //Console.WriteLine("Starting Index is :[" + index + "]");


            //int[] arr = { 2, 2, 1 };
            //int[] arr = { 4, 1, 2, 1, 2 };
            //int singleNumber = SingleNumberClass.SingleNumber(arr);
            //Console.WriteLine(singleNumber);



            //MinStack obj = new MinStack();
            //int x = 2;
            //obj.Push(x);
            //obj.Push(3);
            //obj.Push(4);
            //obj.Push(5);
            //obj.Push(6);
            ////obj.Pop();
            //int param_3 = obj.Top();
            //int param_4 = obj.GetMin();


            //int[] arr = { 1,2,3,1};
            //int[] arr = { 1, 3, 1 };
            //int[] arr = { 0, 0 };
            //RobClass rob = new RobClass();
            //int sum = rob.Rob(arr);
            //Console.WriteLine(sum);

            //int[] arr = { 5, 7, 7, 8, 8, 10 };
            //int target = 8;
            //int target = 6;
            //int[] arr = { 1 };
            //int target = 0;
            //int target = 1;
            //int[] arr = { 1,3 };
            //int target = 1;
            //int[] arr = { 1, 2, 2, 3, 4, 4, 4 };
            //int target = 4;
            //int[] arr = { 0, 0, 0, 1, 2, 3 };
            //int target = 0;

            //int[] res=SearchRangeClass.SearchRange(arr,target);
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}


            //string str = "babad";
            //if (PalindromeClass.IsValidStringPalindrome(str))
            //    Console.WriteLine("valid palindrome");
            //else
            //    Console.WriteLine("invalid palindroe");
            //Console.WriteLine(LengthOfLongestSubstringClass.LongestSubstring(str));
            //string str = "babad";
            //string str = "cbbd";
            //string str = "race e car";
            //string str = "ibvjkmpyzsifuxcabqqpahjdeuzaybqsrsmbfplxycsafogotliyvhxjtkrbzqxlyfwujzhkdafhebvsdhkkdbhlhmaoxmbkqiwiusngkbdhlvxdyvnjrzvxmukvdfobzlmvnbnilnsyrgoygfdzjlymhprcpxsnxpcafctikxxybcusgjwmfklkffehbvlhvxfiddznwumxosomfbgxoruoqrhezgsgidgcfzbtdftjxeahriirqgxbhicoxavquhbkaomrroghdnfkknyigsluqebaqrtcwgmlnvmxoagisdmsokeznjsnwpxygjjptvyjjkbmkxvlivinmpnpxgmmorkasebngirckqcawgevljplkkgextudqaodwqmfljljhrujoerycoojwwgtklypicgkyaboqjfivbeqdlonxeidgxsyzugkntoevwfuxovazcyayvwbcqswzhytlmtmrtwpikgacnpkbwgfmpavzyjoxughwhvlsxsgttbcyrlkaarngeoaldsdtjncivhcfsaohmdhgbwkuemcembmlwbwquxfaiukoqvzmgoeppieztdacvwngbkcxknbytvztodbfnjhbtwpjlzuajnlzfmmujhcggpdcwdquutdiubgcvnxvgspmfumeqrofewynizvynavjzkbpkuxxvkjujectdyfwygnfsukvzflcuxxzvxzravzznpxttduajhbsyiywpqunnarabcroljwcbdydagachbobkcvudkoddldaucwruobfylfhyvjuynjrosxczgjwudpxaqwnboxgxybnngxxhibesiaxkicinikzzmonftqkcudlzfzutplbycejmkpxcygsafzkgudy";
            //string str = "a";
            //int len = str.Length;
            //string result = PalindromeClass.FindLongestSubstring(str);
            //string result = PalindromeClass.LongestPalindrome(str);
            //Console.WriteLine(result);

            //int[] arr = {7, 4, 5 };
            ////string result = SumOfArrayClass.SumofTwoStrings("4", "6");
            ////Console.WriteLine(result);
            //int result = SumOfArrayClass.SumofArray(arr);
            //Console.WriteLine(result);


            //int[] arr = { 2, 3, 6, 7 };
            //int target = 7;
            //int[] arr = { 0,0, 0, 0 };
            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //int[] arr = { 10, 1, 2, 7, 6, 1, 5 };
            //int target = 8;
            //int[] arr = { 2, 5, 2, 1, 2 };
            //int target = 5;

            //IList <IList<int>> res = CombinationSumClass.CombinationSum2(arr, target);
            //for (int i = 0; i < res.Count; i++)
            //{
            //    Console.Write("row:[" + (i + 1)+"]");
            //    for (int j = 0; j < res[i].Count; j++)
            //    {
            //        Console.Write(","+ res[i][j]);
            //    }
            //    Console.WriteLine("");
            //    //console.writeline("row:[" + (i + 1) + "] column:[" + res[i][0] + "," + res[i][1] + "," + res[i][2] + "]");
            //}



            ////Amazon Demo
            /////GCD
            ////int[] arr = { 2, 4, 6, 8, 10 };
            //int[] arr = {2,3,4,5,6};
            ////int[] arr = { 13, 13, 13 };
            ////int[] arr = { 37, 600, 1 };
            ////int[] arr = { 98, 56, 48, 18 };
            //int num = 5;
            ////int[] arr = { 2 };

            //int outPut = Amazon_GCDClass.myGCD_one_test_case_not_passed(num, arr);
            //Console.WriteLine(outPut);


            //int[] Input1 = { 1, 0, 0, 0, 0, 1, 0 };
            //int[] Input1 = { 1, 0, 0, 0, 0, 1, 0, 0 };//test case1
            //int days = 1;
            //int[] Input1 = { 1, 1, 1, 0, 1, 1, 1, 1 };//test case2
            //int days = 2;
            //int[] output = Amzon_CellCompleteClass.cellCompete(Input1, days);
            //for (int i = 0; i < output.Length; i++)
            //{
            //    Console.Write(output[i]);
            //}




            //Demo Data
            //2D array
            int[,] twoDArray = new int[3, 4] {
            {0, 1, 2, 3} ,
            {4, 5, 6, 7} ,
            {8, 9, 10, 11}
            };

            //1darray
            int[] oneDarray = { 1, 2, 3, 4, 5 };
            //Demo Data

            //2d string
            string[,] Tablero = new string[3, 3];
            string[,] Tablero2 = new string[3, 3] {{"a","b","c"},
                                                   {"d","e","f"},
                                                   {"g","h","i"} };
            //2d string

            //1d char array
            char[] array1 = { 's', 'a', 'm' };
            char[] array2 = new char[] { 's', 'a', 'm' };
            char[] array3 = new char[3];

            //2d array
            char[,] twoDcharArray = new char[2, 2]
            {
                {'a','b' },
                {'d','f' }
            };




            //List<char> newlist = new List<char> { 'a','b','c'};
            //List<char> newlist = new List<char> { 'a', 'b', 'c' ,'a'};
            //List<char> newlist = new List<char> { 'a', 'b', 'a', 'b', 'c', 'b', 'a', 'c', 'a', 'd', 'e', 'f', 'e', 'g', 'd', 'e', 'h', 'i', 'j', 'h', 'k', 'l', 'i', 'j' };
            //List<char> newlist = new List<char> { 'a', 'b', 'a', 'b', 'c', 'b', 'a', 'c', 'a', 'd', 'e', 'f', 'e', 'g', 'd', 'e', 'h', 'i', 'j', 'h', 'k', 'l', 'i', 'j','a' };
            //List<int> res = AmzTestPracticeClass.lengthEachScene(newlist);
            //for (int i = 0; i < res.Count; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}


            //int numFeatures = 6, topFeatures = 2, numFeatureRequests=7;
            //List<string> possibleFeatures = new List<string> { "storage", "battery", "hover", "alexa", "waterproof", "solar" };
            //List<string> featureRequests = new List<string> {
            //   "I wish my kindle had even more storage!",
            //    "I wish the battery life om my kindle lasted 2 years",
            //    "I read in the bath and would enjoy a waterproof Kindle",
            //    "Waterproof and increased battery are my top two requests",
            //    "I want to take my Kindle into the shower.Waterproof please waterproof!",
            //    "It would be neat if my Kindle would hover on my desk when not in use",
            //    "How cool would it be if my Kindle charged in the sun via solar power?"

            //};
            //List<string> Result=AmzTestPracticeClass.popularNFeatures(numFeatures, topFeatures, possibleFeatures, numFeatureRequests, featureRequests);
            //for (int i = 0; i < Result.Count; i++)
            //{
            //    Console.WriteLine(Result[i]);
            //}

            //string a = "Waterproof";
            //string b = "waterproof";
            //bool isfound = a.Equals(b.ToLower());
            //if (isfound)
            //    Console.Write("true");
            //else
            //    Console.Write("false");

            //string[] words = new string[] {"i", "love", "leetcode", "i", "love", "coding"};
            //int k = 2;
            //string[] words = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            //int k = 4;
            //IList<string> result= TopKFrequentClass.TopKFrequent(words, k);
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}



            //int[,] grid = new int[,] {
            //                            {1,0,0,0,0},
            //                            {0,1,0,1,0},
            //                            {0,0,1,0,0},
            //                            {0,0,0,1,0},
            //                            {0,0,0,0,1}
            //};

            //int[,] grid = new int[,] {
            //                            {0, 0, 1, 0, 0, 0 },
            //                            {0, 0, 0, 0, 0, 0 },
            //                            {0, 0, 0, 0, 0, 1},
            //                            {0, 0, 0, 0, 0, 0},
            //                            {0, 1, 0, 0, 0, 0}
            //};

            //int[,] grid = new int[,] {
            //                            {0, 0, 1},
            //                            {0, 0, 0}
            //};

            //int numOfDays = Amazonhasa2DgridofCellTowersClass.DaystoUpgradeServer(2, 3, grid);

            ////int numOfDays = MinimumDays(rows, column, grid);
            //Console.WriteLine("Num of Days is :[" + numOfDays + "]");


            //char[][] islanc2d = new char[][]
            //{
            //    new char[]{'1','1','0','0','0' },
            //    new char[]{ '1', '1', '0', '0', '0' },
            //    new char[]{ '0', '0', '1', '0', '0' },
            //     new char[]{ '0', '0', '0', '1', '1' },
            //};

            //char[][] islanc2d = new char[][]
            //{
            //    new char[]{'1','1','1','1','0' },
            //    new char[]{ '1', '1', '0', '1', '0' },
            //    new char[]{ '1', '1', '0', '0', '0' },
            //     new char[]{ '0', '0', '0', '0', '0' },
            //};

            //char[][] islanc2d = new char[][]
            //{
            //    new char[]{'1' },
            //    new char[]{ '1' }
            //};

            //    char[][] islanc2d = new char[][] {

            //                 new char[]{'0','1', '0','1','0' },
            //                 new char[]{'0','0', '1','1','1'},
            //                 new char[]{'1','0', '0','1','0'},
            //                 new char[]{'0','1', '1','0','0' },
            //                 new char[]{'1','0', '1','0','1' }
            //                 }; 

            //int res=NumIslandsClass.NumIslands(islanc2d);
            //    Console.WriteLine(res);

            //int[][] islandArray = new int[][]
            //{

            //new int[]{0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            //new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            //new int[]{0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            //new int[]{0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
            //new int[]{0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
            //new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            //new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            //new int[]{ 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
            //};

            //int res= NumIslandsClass.MaxAreaOfIsland(islandArray);
            //Console.Write(res);

            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            //string[] banned=new string[]{ "hit" };
            //string paragraph = "Bob. hIt, baLl";
            //string[] banned = new string[] { "bob", "hit" };
            //string paragraph = "L, P!X!C; u!P ? w!P.G, S? l? X? D. w? m? f? v, x? i.z; x' m! U' M!j ? V; l.S!j ? r, K.O? k? p? p, H!t!z' X! v. u; F, h; s? X? K. y, Y! L; q! y? j, o? D' y? F' Z; E? W; W' W!n!p' U. N; w? V' y!Q; J, o!T ? g ? o!N' M? X? w! V. w? o' k.W.y, k; o' m! r; i, n. k, w; U? S? t; O' g' z. V. N? z, W? j! m? W! h; t! V' T!Z ? R' w, w? y? y; O' w; r? q. G, V.x? n, Y; Q.s? S. G.f, s!U ? l.o!i.L; Z' X! u. y, Q. q; Q, D; V. m. q. s? Y, U; p? u! q? h? O. W' y? Z!x!r.E, R, r' X' V, b.z, x!Q; y, g' j; j. q; W; v' X!J' H? i' o? n, Y. X!x ? h ? u; T? l!o ? z.K' z' s; L? p? V' r. L? Y; V! V' S.t? Z' T' Y.s? i? Y!G ? r; Y; T!h!K; M.k.U; A!V ? R ? C' x! X. M; z' V!w.N.T ? Y' w? n, Z, Z? Y' R; V' f; V' I; t? X? Z; l? R, Q!Z.R.R, O.S!w; p' T. u? U! n, V, M. p? Q, O? q' t.B, k.u.H' T; T? S; Y! S! i? q! K' z' S! v; L. x; q; W? m? y, Z! x. y. j? N' R' I? r? V! Z; s, O? s; V, I, e? U' w!T ? T!u; U!e ? w ? z; t!C!z ? U, p' p! r. x; U! Z; u! j; T! X! N' F? n!P' t, X. s; q'";
            //string[] banned ={"m", "i", "s", "w", "y", "d", "q", "l", "a", "p", "n", "t", "u", "b", "o", "e", "f", "g", "c", "x"};
            //string res= MostCommonWordClass.MostCommonWord(paragraph, banned);
            //Console.WriteLine(res);

            //string str = "42";
            //string str = "   -42";
            //string str = "4193 with words";
            //string str = "-91283472332";
            //string str = "3.14159";
            //string str = "";
            //string str = "+1";
            //string str = " ";
            //string str = "+-2";
            //string str = "  -0012a42";
            //string str = "2147483646";
            //string str = "-2147483647";
            //string str = "-91283472332";
            //string str = "2147483648";
            //string str= "-2147483648";
            //string str = "-6147483648";
            //string str = "-13+8";
            //int res = MyAtoiClass.atoi(str);
            //Console.WriteLine(res);


            //TreeNode tree = new TreeNode();
            //tree.val = 2;
            //tree.left=new TreeNode { val = 1 };
            //tree.right = new TreeNode { val = 3 };

            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = 1 };

            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = -1 };


            //TreeNode tree = new TreeNode();
            //tree.val = 10;
            //tree.left = new TreeNode { val = 5 };
            //tree.right = new TreeNode { val = 15 };
            //tree.right.left = new TreeNode { val = 6 };
            //tree.right.right = new TreeNode { val = 20 };

            //TreeNode tree = new TreeNode();
            //tree.val = 10;
            //tree.left = new TreeNode { val = 5 };
            //tree.right = new TreeNode { val = 15 };
            //tree.right.left = new TreeNode { val = 6 };
            //tree.right.right = new TreeNode { val = 20 };

            //TreeNode tree = new TreeNode();
            //tree.val = 3;
            //tree.right = new TreeNode { val = 30 };
            //tree.right.left = new TreeNode { val = 10 };
            //tree.right.left.right = new TreeNode { val = 15 };
            //tree.right.left.right.right = new TreeNode { val = 45 };

            //TreeNode tree = new TreeNode();
            //tree.val = 2147483647;
            //tree.left = new TreeNode { val = 2147483647 };
            //bool res = ValidateBinaryTreeClass.IsValidBST2(tree);


            //TreeNode tree = new TreeNode();
            //tree.val = int.MinValue;
            //tree.right = new TreeNode { val = int.MaxValue };
            //tree.right.left = new TreeNode { val = int.MinValue };
            //bool res = ValidateBinaryTreeClass.IsValidBST2(tree);

            //TreeNode tree = new TreeNode();
            //tree.val = int.MinValue;
            //bool res = ValidateBinaryTreeClass.IsValidBST2(tree);

            //TreeNode tree = new TreeNode();
            //tree.val = int.MinValue;
            //tree.left = new TreeNode { val = int.MinValue };
            //bool res = ValidateBinaryTreeClass.IsValidBST2(tree);


            //TreeNode tree = new TreeNode();
            //tree.val = 2147483647;
            //tree.left = new TreeNode { val = 2147483647 };
            //bool res = ValidateBinaryTreeClass.IsValidBST2(tree);

            //TreeNode tree = new TreeNode();
            //tree.val = int.MinValue;
            //tree.right = new TreeNode { val = int.MaxValue };
            //bool res = ValidateBinaryTreeClass.IsValidBST(tree);

            //Console.WriteLine(res);


            //TreeNode tree = new TreeNode();
            //tree.val = 3;
            //tree.left = new TreeNode { val = 9 };
            //tree.right = new TreeNode { val = 20 };
            //tree.right.left = new TreeNode { val = 15 };
            //tree.right.right = new TreeNode { val = 7 };
            //IList<IList<int>> res = LevelOrderClass.LevelOrder(tree);

            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = 2 };
            //tree.right = new TreeNode { val = 3 };
            //tree.left.left = new TreeNode { val = 4 };
            //tree.left.right = new TreeNode { val = 5 };

            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = 2 };
            //tree.right = new TreeNode { val = 3 };
            //tree.left.left = new TreeNode { val = 4 };
            //tree.right.right = new TreeNode { val = 5 };

            //TreeNode tree = new TreeNode();
            //tree.val = 3;
            //tree.left = new TreeNode { val = 9 };
            //tree.right = new TreeNode { val = 20 };
            //tree.right.left = new TreeNode { val = 15 };
            //tree.right.right = new TreeNode { val = 7 };

            //IList<IList<int>> res = ZigzagLevelOrderClass.ZigzagLevelOrder(tree);


            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = 2 };
            //tree.right = new TreeNode { val = 3 };

            //Console.WriteLine(HasPathSumClass.HasPathSum(tree, 6));


            //TreeNode tree = new TreeNode();
            //tree.val = 1;
            //tree.left = new TreeNode { val = 2 };
            //tree.right = new TreeNode { val = 3 };

            //TreeNode tree = new TreeNode();
            //tree.val = -10;
            ////tree.left = new TreeNode { val = 9 };
            //tree.right = new TreeNode { val = 20 };
            //tree.right.left = new TreeNode { val = 15 };
            //tree.right.right = new TreeNode { val = 7 };

            //Console.WriteLine(MaximumPathSumClass.MaxPathSum(tree));



            int num = 19;
            Console.WriteLine(IntegerToRomanClass.IntToRoman(num));

            Console.ReadKey();
        }

    }
}
