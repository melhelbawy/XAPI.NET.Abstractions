# XAPI.NET.Abstractions

There are two interfaces
 - IStatement<TId> where TId : struct
 - IPushStatement<TStatement, TId> where TStatement : IStatement<TId> where TId : struct 
 
 ALL Statement must by type of IStatement, there are one method PushStatementAsyn(TStatement statement) which implemented to push the type of statement.
 
 
 ### This is core for simplifying work with XAPI by .NET.
