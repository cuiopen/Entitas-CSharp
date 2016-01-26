public static class PoolAComponentIds {
    public const int C = 0;
    public const int B = 1;
    public const int A = 2;

    public const int TotalComponents = 3;

    public static readonly string[] componentNames = {
        "C",
        "B",
        "A"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(CComponent),
        typeof(BComponent),
        typeof(AComponent)
    };
}