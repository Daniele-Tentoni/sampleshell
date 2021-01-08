using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: NeutralResourcesLanguage("en-US")]

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: ExportFont("font_awesome_5_brand_regular_400.otf", Alias = "fab")]
[assembly: ExportFont("font_awesome_5_regular_400.otf", Alias = "far")]
[assembly: ExportFont("font_awesome_5_solid_900.otf", Alias = "fas")]

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}