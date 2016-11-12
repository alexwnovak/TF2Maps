using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace NumberGenerator
{
   public static class NumberDecalGenerator
   {
      private const int _decalSize = 256;
      private const int _margin = 32;

      public static Image Draw( int number, int max )
      {
         var bitmap = new Bitmap( _decalSize, _decalSize );

         using ( Graphics g = Graphics.FromImage( bitmap ) )
         {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            FillWithTransparency( g );
            DrawCompleteRing( g );
            DrawDots( g, number, max );
            DrawArc( g, number, max );
            DrawDigit( g, number );
         }

         return bitmap;
      }

      private static void DrawDigit( Graphics g, int number )
      {
         const string fontFamily = "Segoe UI";
         const int fontSize = 80;

         using ( var font = new Font( fontFamily, fontSize ) )
         using ( var stringFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center } )
         {
            string text = number.ToString();
            var size = g.MeasureString( text, font );

            float x = ( _decalSize - size.Width ) / 2;
            float y = ( _decalSize - size.Height ) / 2;

            using ( var graphicsPath = new GraphicsPath() )
            using ( var pen = new Pen( Color.Black, 5 ) { LineJoin = LineJoin.Round } )
            {
               graphicsPath.AddString( text, new FontFamily( fontFamily ), (int) FontStyle.Regular, fontSize, new RectangleF( 0, 0, _decalSize, _decalSize ), stringFormat );
               g.DrawPath( pen, graphicsPath );
               g.FillPath( Brushes.White, graphicsPath );
            }
         }
      }

      private static void DrawArc( Graphics g, int number, int count )
      {
         using ( var pen = new Pen( Color.White, 6 ) )
         {
            float thetaDegrees = number * 360 / count;

            g.DrawArc( pen, _margin, _margin, _decalSize - _margin * 2, _decalSize - _margin * 2, -90, thetaDegrees );
         }
      }

      private static void DrawDots( Graphics g, int number, int count )
      {
         const double dotRadius = 16;
         const double filledDotRadius = 8;
         double x, y;
         double radius = _decalSize / 2.65;

         for ( int index = 0; index < count; index++ )
         {
            float thetaDegrees = index * 360 / count - 90;
            float theta = (float) MathHelper.ToRadians( thetaDegrees );

            x = ( _decalSize / 2 ) + radius * Math.Cos( theta );
            y = ( _decalSize / 2 ) + radius * Math.Sin( theta );

            g.FillEllipse( Brushes.Black, (int) ( x - dotRadius ), (int) ( y - dotRadius ), (int) ( dotRadius * 2 ), (int) ( dotRadius * 2 ) );

            if ( index <= number )
            {
               g.FillEllipse( Brushes.White, (int) ( x - filledDotRadius ), (int) ( y - filledDotRadius ), (int) ( filledDotRadius * 2 ), (int) ( filledDotRadius * 2 ) );
            }
         }
      }

      private static void DrawCompleteRing( Graphics g )
      {
         using ( var pen = new Pen( Color.Black, _decalSize / 16 ) )
         {
            g.DrawEllipse( pen, _margin, _margin, _decalSize - _margin * 2, _decalSize - _margin * 2 );
         }
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
