#:project ../src/Algorithms/Algorithms.csproj

using static System.Console;
using IntLinkedList = Algorithms.DataStructures.Immutable.LinkedList<int>;

WriteLine("An immutable linked list");

var list = IntLinkedList.Empty.Push(10).Push(20).Push(30).Push(40).Push(50);
var list2 = list.Reverse();

WriteLine(list);
WriteLine(list2);
