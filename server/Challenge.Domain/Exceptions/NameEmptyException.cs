namespace Challenge.Domain.Exceptions
{
    public class NameEmptyException : BusinessException
    {
        public NameEmptyException() : base(ErrorCodes.InvalidObject, "Item not contains name") { }
    }
}
