using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace NumberGenerator
{
   public static class NumberDecalGenerator
   {
      private const int _decalSize = 256;

      public static Image Draw( int number, int max )
      {
         var bitmap = new Bitmap( _decalSize, _decalSize );

         using ( Graphics g = Graphics.FromImage( bitmap ) )
         {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
         }

         return bitmap;
      }
   }
}
