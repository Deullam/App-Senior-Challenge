namespace Challenge.Domain.Exceptions
{
    public class ClientNotFoundException : BusinessException
    {
        public ClientNotFoundException() : base(ErrorCodes.NotFound, "Client not found") { }
    }
}
