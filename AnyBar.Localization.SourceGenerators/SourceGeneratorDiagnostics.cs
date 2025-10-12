using AnyBar.Localization.Shared;
using Microsoft.CodeAnalysis;

namespace AnyBar.Localization.SourceGenerators
{
    public static class SourceGeneratorDiagnostics
    {
        public static readonly DiagnosticDescriptor CouldNotFindResourceDictionaries = new DiagnosticDescriptor(
            "ABSG0001",
            "Could not find resource dictionaries",
            "Could not find resource dictionaries. There must be a `en.xaml` file under `Language` folder.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor CouldNotFindPluginEntryClass = new DiagnosticDescriptor(
            "ABSG0002",
            "Could not find the main class of plugin",
            $"Could not find the main class of your plugin. It must implement `{Constants.PluginInterfaceName}`.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor CouldNotFindContextProperty = new DiagnosticDescriptor(
            "ABSG0003",
            "Could not find plugin context property",
            $"Could not find a property of type `{Constants.PluginContextTypeName}` in `{{0}}`. It must be a public static or internal static property of the main class of your plugin.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor ContextPropertyNotStatic = new DiagnosticDescriptor(
            "ABSG0004",
            "Plugin context property is not static",
            "Context property `{0}` is not static. It must be static.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor ContextPropertyIsPrivate = new DiagnosticDescriptor(
            "ABSG0005",
            "Plugin context property is private",
            "Context property `{0}` is private. It must be either internal or public.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor ContextPropertyIsProtected = new DiagnosticDescriptor(
            "ABSG0006",
            "Plugin context property is protected",
            "Context property `{0}` is protected. It must be either internal or public.",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor LocalizationKeyUnused = new DiagnosticDescriptor(
            "ABSG0007",
            "Localization key is unused",
            $"Method `{Constants.ClassName}.{{0}}` is never used",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );

        public static readonly DiagnosticDescriptor EnumFieldLocalizationKeyValueInvalid = new DiagnosticDescriptor(
            "ABSG0008",
            "Enum field localization key and value invalid",
            $"Enum field `{{0}}` does not have a valid localization key or value",
            "Localization",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true
        );
    }
}
