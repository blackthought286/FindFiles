// See https://aka.ms/new-console-template for more information

using FindFiles;
using CommandLine;
using CommandLine.Text;

var results = Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(options =>
    {
        WriteLine($"Text: {options.Text}");
    });

results.WithNotParsed(_ => WriteLine(HelpText.RenderUsageText(results)));
