Custom Logger for ToolWatch
2020-08-16

Logger Interface
Defines the options for writing to the logs. These are grouped by log level but can also accept the log level if you want to define it. The log level is otherwise
based on the method name i.e. LogWarning() will automatically set the log level to Warning.

Using this logger
Inject at startup (Preferred)
Inject at constructor. Within the default class contructor, instantiate the desired implementation of this logger.

Example:
public class MyClass
{
	private ITooLogger logger;

	public MyClass()
	{
		logger = new LoggerLogToFile();
	}
}

Log Levels - Defines the category of the log record
Information
Warning
Error
Critical

TODO:
Implement log configurations using appsettings.json to store log configuration and inject.
Inject the logger at application startup.
Additional implementations for logging to datastore, Application Insights, etc.