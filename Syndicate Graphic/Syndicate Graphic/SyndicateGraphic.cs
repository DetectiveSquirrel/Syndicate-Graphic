using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Plugins;
using SharpDX;

namespace Syndicate_Graphic
{
    public class SyndicateGraphic : BaseSettingsPlugin<Settings>
    {
        public SyndicateGraphic()
        {
            PluginName = "Syndicate Graphic";
        }

        public override void Render()
        {
            var window = GameController.Window.GetWindowRectangleReal().TopLeft;
            var CursorPos = Mouse.GetCursorPositionVector() - window;
            var CusorBox = new RectangleF(CursorPos.X, CursorPos.Y, 30, 30);
            var TopLeftRegion = new RectangleF(0, 0, 80, 80);

#if DEBUG
#endif

            if (!GameController.Game.IngameState.UIRoot.Children[1].Children[61].IsVisible)
                return;

            Graphics.DrawBox(TopLeftRegion, new Color(50, 50, 50, 100));

            if (CusorBox.Intersects(TopLeftRegion))
            {
                //LogMessage("LOGGING", 1);
                Graphics.DrawPluginImage(PluginDirectory + "\\InfoImage.png", new RectangleF(Settings.XPos, Settings.YPos, Settings.Width, Settings.Height), new Color(255, 255, 255, Settings.Transparency));
            }
        }
    }
}
