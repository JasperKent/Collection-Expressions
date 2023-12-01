using CollectionExpressions;

int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
var a2 = new int[] { 1, 2, 3, 4, 5 };
int[] a3 = { 1, 2, 3, 4, 5 };

var l1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> l2 = new (){ 1, 2, 3, 4, 5 };
//List<int> l3 = { 1, 2, 3, 4, 5 };

int[] a4 = { };
int[] a5 = new int[0];
int[] a6 = Array.Empty<int>();

List<int> l4 = new List<int>();
List<int> l5 = new ();

int[] a7 = [1, 2, 3, 4, 5];
//var a7 = [1, 2, 3, 4, 5];

List<int> l6 = [1, 2, 3, 4, 5];

List<int> l7 = [];
int[] a8 = [];

//Dictionary<int, string> d1 =
//[
//    [1] = "Giles",
//    [2] = "Buffy"
//];

Dictionary<int, string> d1 = [];

int[][] ma1 = [[1,2,3], [4,5,6], [7,8,9,10]];

List<int[]> ml1 = [[1, 2, 3], [4, 5, 6], [7, 8, 9, 10]];

//int[,] ma2 = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
int[,] ma2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int[][] ma3 = [a1, a2, a3];

int[] a9 = [..a1, ..a2, ..a3, 10, 11, 12];

IntList intList = new IntList();

int[] a10 = [..intList];

IntList intList2 = [1, 2, 3, 4, 5];
IntList intList3 = new IntList { 1, 2, 3, 4, 5 };

ImmutableIntList iil1 = new ImmutableIntList(1, 2, 3, 4, 5);
ImmutableIntList iil2 = [1, 2, 3, 4, 5];

foreach (int i in iil2)
    Console.WriteLine(i);