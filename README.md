# Simple examples how to parse command line arguments in .NET Core

Different ways of parsing command line parameters passed to a .NET Core application.

## Manually parse arguments

Naive (and not recommended version) can be found [here](src/CommandLineDemo). This example is soley here to show why this is a topic at all.
I.e, to do this manually is painful so using existing solutions to solve this problems is highly recommended.

## Use of Command Line Parser Library

According to the repository website, this is "The best C# command line parser that brings standardized *nix getopt style, for .NET".
Somewhat subjective, but certainly a good library to consider and allow for almost all configurations you will ever need. You can find
the sample implementation [here](src/CommandLineParserDemo). For more information, please have a look at the official
[library website](https://github.com/commandlineparser/commandline)

## Use of System.CommandLine package

