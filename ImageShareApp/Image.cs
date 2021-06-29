using System;
using System.Collections.Generic;
using System.Text;

namespace ImageShareApp
{
    public class Image
    {
        Ishare share;

        public Image(Ishare image)
        {
            this.share = image;
        }

        public void Share()
        {
            share.Send();
        }
    }
}