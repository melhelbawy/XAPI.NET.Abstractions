namespace XAPI.NET.Abstractions
{
    public interface IPushStatement<TStatement, TId> where TStatement : IStatement<TId> where TId : struct
    {
        Task<bool> PushStatementAsync(TStatement statement);
    }
}
