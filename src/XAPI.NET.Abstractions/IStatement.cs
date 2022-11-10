namespace XAPI.NET.Abstractions;

public interface IStatement<TId> where TId : struct
{
    public TId Id { get; init; }
}
