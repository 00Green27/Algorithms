#:project ../src/Algorithms/Algorithms.csproj


using Algorithms.DataStructures.Immutable;
using Algorithms.Utils;
using static System.Console;


WriteLine("A covariant immutable stack");

IImStack<Tiger> s1 = ImStack<Tiger>.Empty;
IImStack<Tiger> s2 = s1.Push(new Tiger());
IImStack<Tiger> s3 = s2.Push(new Tiger());
IImStack<Animal> s4 = s3;
IImStack<Animal> s5 = s4.Push(new Giraffe());

WriteLine(s5.Bracket());

class Animal
{
	public override string ToString() => GetType().Name;
}
class Tiger : Animal { }
class Giraffe : Animal { }
