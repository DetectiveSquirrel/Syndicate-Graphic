using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using SharpDX;

namespace Syndicate_Graphic
{
    public class Settings : SettingsBase
    {
        [Menu("X")]
        public RangeNode<int> XPos { get; set; } = new RangeNode<int>(41, 0, 2000);
        [Menu("Y")]
        public RangeNode<int> YPos { get; set; } = new RangeNode<int>(136, 0, 2000);
        [Menu("Width")]
        public RangeNode<int> Width { get; set; } = new RangeNode<int>(1827, 0, 2000);
        [Menu("Height")]
        public RangeNode<int> Height { get; set; } = new RangeNode<int>(742, 0, 2000);

        [Menu("Transparency")]
        public RangeNode<int> Transparency { get; set; } = new RangeNode<int>(100, 0, 255);
    }
}