using System;
using System.Drawing;

namespace RuneCircleGenerator
{
   public class Generator : IDisposable
   {
      private const int _textureSize = 1024;

      private SolidBrush _transparentBrush = new SolidBrush( Color.Transparent );

      public Image GenerateRuneCircle()
      {
         var bitmap = new Bitmap( _textureSize, _textureSize );

         using ( var g = Graphics.FromImage( bitmap ) )
         {
            FillWithTransparency( g );
         }

         return bitmap;
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
         }
      }

      #endregion
   }
}
