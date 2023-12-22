using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Crafting.SourceGenerator
{
    [Generator]
    public class FunctionGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider((c, _) => c is ClassDeclarationSyntax,
                transform: (n, _) => (ClassDeclarationSyntax)n.Node)
                .Where(m => m != null);

            var complication = context.CompilationProvider.Combine(provider.Collect());

            context.RegisterImplementationSourceOutput(complication, (spc, source) =>
            Execute(spc, source.Left, source.Right));
        }

        private void Execute(SourceProductionContext context, Compilation compilation, ImmutableArray<ClassDeclarationSyntax> typeList)
        {
            var code = "namespace Crafting.GeneratedCode" +
                "{" +
                "public static ClassNames" +
                "{" +
                "public static string s = \"Hello From Roslyn\";" +
                "}" +
                "}";

            context.AddSource("ClassNames.cs", code);
        }
    }
}
