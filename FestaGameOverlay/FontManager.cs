using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace FestaGameOverlay
{
    public enum FontType
    {
        Light = 0,
        Regular = 1,
        Bold = 2,
    }

    public class FontManager
    {
        private static void LoadFont(PrivateFontCollection pfc, byte[] font)
        {
            IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
            Marshal.Copy(font, 0, fontBuffer, font.Length);
            pfc.AddMemoryFont(fontBuffer, font.Length);

            Marshal.FreeHGlobal(fontBuffer);
        }

        public static Font GetFont(FontType type, float fontSize)
        {
            PrivateFontCollection pfc = new();

            if (type == FontType.Light)
            {
                LoadFont(pfc, Properties.Resources.NEXON_Lv2_Gothic_Light);
            }
            else if (type == FontType.Regular)
            {
                LoadFont(pfc, Properties.Resources.NEXON_Lv2_Gothic);
            }
            else
            {
                LoadFont(pfc, Properties.Resources.NEXON_Lv2_Gothic_Bold);
            }

            return new Font(
                pfc.Families[0],
                fontSize,
                FontStyle.Regular,
                GraphicsUnit.Point,
                129
            );
        }
    }
}
