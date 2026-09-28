#:project ../src/Algorithms/Algorithms.csproj

using IntLinkedList = Algorithms.DataStructures.Immutable.LinkedList<int>;

var list = IntLinkedList.Empty.Push(10).Push(20).Push(30).Push(40).Push(50);
var list2 = list.Reverse();

Console.WriteLine(list);
Console.WriteLine(list2);
