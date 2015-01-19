using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_FavoriteViews
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_FavoriteViewsExtension : IVsixPluginExtension { }
}