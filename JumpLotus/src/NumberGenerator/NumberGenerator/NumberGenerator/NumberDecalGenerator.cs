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

            FillWithTransparency( g );
         }

         return bitmap;
      }

      private static void FillWithTransparency( Graphics g )
      {
         // Still not sure this is actually necessary--is it transparent by
         // default? Who knows! Ain't nobody got time for that!

         using ( var transparentBrush = new SolidBrush( Color.FromArgb( 0, Color.Transparent ) ) )
         {
            g.FillRectangle( transparentBrush, 0, 0, _decalSize, _decalSize );
         }
      }
   }
}
