using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
public class MssqlLogger : LoggerServiceBase
{
    public MssqlLogger()
    {
        MSSqlServerSinkOptions sinkOptions = new()
        { TableName = "Logs", AutoCreateSqlTable = true };

        ColumnOptions columnOptions = new();
        global::Serilog.Core.Logger serilogConfig = new LoggerConfiguration().WriteTo
            .MSSqlServer("Server=DESKTOP-PBE5IS4\\SQLEXPRESS;Database=TobetoRentACarDb;Trusted_Connection=true;TrustServerCertificate =true", sinkOptions, columnOptions: columnOptions).CreateLogger();
        Logger = serilogConfig;
    }
}
