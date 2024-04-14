using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace BookReadingApp.Infrastructure.Interceptors
{
    public class DbCommandInterceptor : IDbCommandInterceptor
    {
        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            LogDbCommand(command);
        }

        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            LogDbCommand(command);
        }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            LogDbCommand(command);
        }

        private void LogDbCommand(DbCommand command)
        {
            Console.WriteLine($"DB Command: {command.CommandText}");
            foreach (DbParameter parameter in command.Parameters)
            {
                Console.WriteLine($"Parameter: {parameter.ParameterName} = {parameter.Value}");
            }
        }

        public InterceptionResult<DbCommand> CommandCreating(CommandCorrelatedEventData eventData, InterceptionResult<DbCommand> result)
        {
            throw new NotImplementedException();
        }

        public DbCommand CommandCreated(CommandEndEventData eventData, DbCommand result)
        {
            throw new NotImplementedException();
        }

        public InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
            throw new NotImplementedException();
        }

        public InterceptionResult<object> ScalarExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<object> result)
        {
            throw new NotImplementedException();
        }

        public InterceptionResult<int> NonQueryExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
        {
            throw new NotImplementedException();
        }

        public ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<InterceptionResult<object>> ScalarExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<object> result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
        {
            throw new NotImplementedException();
        }

        public object ScalarExecuted(DbCommand command, CommandExecutedEventData eventData, object result)
        {
            throw new NotImplementedException();
        }

        public int NonQueryExecuted(DbCommand command, CommandExecutedEventData eventData, int result)
        {
            throw new NotImplementedException();
        }

        public ValueTask<DbDataReader> ReaderExecutedAsync(DbCommand command, CommandExecutedEventData eventData, DbDataReader result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<object> ScalarExecutedAsync(DbCommand command, CommandExecutedEventData eventData, object result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> NonQueryExecutedAsync(DbCommand command, CommandExecutedEventData eventData, int result, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void CommandFailed(DbCommand command, CommandErrorEventData eventData)
        {
            throw new NotImplementedException();
        }

        public Task CommandFailedAsync(DbCommand command, CommandErrorEventData eventData, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public InterceptionResult DataReaderDisposing(DbCommand command, DataReaderDisposingEventData eventData, InterceptionResult result)
        {
            throw new NotImplementedException();
        }

        // Implement other methods of IDbCommandInterceptor if needed

        // If you're using async database operations, you can also implement the async versions of the methods
    }
}
