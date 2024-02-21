namespace Core.Utilities.Results
{
    public interface IDataResult<T>: IResult //Interface Interface'i extend eder.
    {
        public T Data { get; }
    }
}
