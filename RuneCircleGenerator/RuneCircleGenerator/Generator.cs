using System;
using System.Drawing;

namespace RuneCircleGenerator
{
   public class Generator : IDisposable
   {
      private const int _textureSize = 1024;
      private static readonly float _penWidth = _textureSize * 0.016f;

      private SolidBrush _transparentBrush = new SolidBrush( Color.Transparent );
      private Pen _greenPen = new Pen( Color.FromArgb( 255, 156, 255, 134 ), _penWidth );

      public Image GenerateRuneCircle()
      {
         var bitmap = new Bitmap( _textureSize, _textureSize );

         using ( var g = Graphics.FromImage( bitmap ) )
         {
            FillWithTransparency( g );

            RenderRings( g );
         }

         return bitmap;
      }

      private void RenderRings( Graphics g )
      {
         float outerMargin = _textureSize * 0.02f;
         float innerMargin = _textureSize * 0.13f;

         g.DrawEllipse( _greenPen, outerMargin, outerMargin, _textureSize - outerMargin * 2, _textureSize - outerMargin * 2 );
         g.DrawEllipse( _greenPen, innerMargin, innerMargin, _textureSize - innerMargin * 2, _textureSize - innerMargin * 2 );
      }

      private void FillWithTransparency( Graphics g )
         => g.FillRectangle( _transparentBrush, 0, 0, _textureSize, _textureSize );

      #region IDisposable members

      public void Dispose()
      {
         Dispose( true );
         GC.SuppressFinalize( this );
      }

      private void Dispose( bool disposing )
      {
         if ( disposing )
         {
            _transparentBrush?.Dispose();
            _greenPen?.Dispose();
         }
      }

      #endregion
   }
}
