using System.Collections;
using System.Collections.Concurrent;

int[] array = Array.Empty<int>();

// IList
List<int> list = new() { 1, 5, 2, 3, 7, 3, 5, 6, 8 };
Console.WriteLine(string.Join(",", list));
IOrderedEnumerable<int> orderedEnumerable = list.OrderBy(x => x);
Console.WriteLine(string.Join(",", orderedEnumerable));
Console.WriteLine(list.BinarySearch(5, new IntComparer()));
Console.WriteLine(list.OrderBy(x => x).ToList().BinarySearch(5, new IntComparer()));

List<int> orderedList = orderedEnumerable.ToList();
int i1 = orderedList.IndexOf(5);

Console.WriteLine(string.Join(",", orderedList.GetRange(i1, orderedList.Count - i1)));
orderedList.IndexOf(5);
orderedList.LastIndexOf(5);

list.IndexOf(5);
list.LastIndexOf(5);

ArrayList arrayList = new();
LinkedList<int> linkedList = new();

// ISet
HashSet<int> hashset = new();
SortedSet<int> sortedSet = new();

// IDictionary
IDictionary<int, int> concurrentDictionary = new ConcurrentDictionary<int, int>();
IDictionary<int, int> dictionary = new Dictionary<int, int>();

// Queue
Queue<int> queue = new();

// Stack
Stack<int> stack = new();

public class IntComparer : IComparer<int>
{
    public int Compare(int x, int y) => x - y;
}