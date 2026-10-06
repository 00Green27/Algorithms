namespace Algorithms.Utils;

public static class Extensions
{
	public static string Comma<T>(this IEnumerable<T> items) =>
		string.Join(',', items);

	public static string Bracket<T>(this IEnumerable<T> items) =>
		"[" + items.Comma() + "]";
}
