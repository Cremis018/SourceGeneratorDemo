using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GeneratorDemo;

[Generator(LanguageNames.CSharp)]
public class ComponentGenerator : IIncrementalGenerator
{
    private const string AttributeMetadataName = "GeneratorDemo.ComponentAttribute";
    
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var componentClass = context.SyntaxProvider
            .ForAttributeWithMetadataName(AttributeMetadataName,
                static (node,_)=>node is ClassDeclarationSyntax,
                static (context, _) =>
                {
                    var classDecl = context.TargetNode;
                    var model = context.SemanticModel;
                    return model.GetDeclaredSymbol(classDecl) is INamedTypeSymbol { } 
                        symbol ? new { Symbol = symbol, ClassDecl = classDecl } : null;
                })
            .Where(static x => x is not null);
        
        context.RegisterSourceOutput(componentClass, static (spc, data) =>
        {
            var symbol = data!.Symbol;
            var classDecl = data.ClassDecl;
        });
    }
}