public class Counter
{
    private int count = 0;
    private int increment;

    public Counter(int increment)
    {
        this.increment = increment;
    }

    public int GetAndIncrement()
    {
        this.count += this.increment;
        return this.count;
    }
}

public class DocumentNameCreator
{
    private string prefix;
    private Counter _counter;

    public DocumentNameCreator(Counter counter, string prefix)
    {
        this.prefix = prefix;
        this._counter = counter;
    }

    public string GetNewDocumentName()
    {
        return prefix + _counter.GetAndIncrement();
    }
}
