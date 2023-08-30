# CommandLiner

Command line arguments parser for C# (.NET Framework).


## Usage:

### Comand line:

    your-executable -test 1 -name LoremIpsum --debug=true

### Your application:

    public class CommandLineArguments
    {
        [CommandLineArgument(DefaultValue = 9999)]
        public int Test { get; set; }

        [CommandLineArgument(DefaultValue = null)]
        public string Name { get; set; }

        [CommandLineArgument(DefaultValue = false)]
        public bool Debug { get; set; }

        override public string ToString()
        {
            return new JsonUtils(this.Debug).Serialize(this);
        }
    }
###
    public static void Main(string[] args)
    {
        CommandLineArguments arguments = new CommandLiner(args).fill(new CommandLineArguments());
        Console.WriteLine(arguments);
    }

### Result:

    {
        "Debug": true,
        "Test": 1,
        "Name": "LoremIpsum"
    }


## Dependencies:

- .NET Framework 4.6: https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net46-offline-installer
- .NET Standart 2.1: https://dotnet.microsoft.com/download/dotnet/2.1