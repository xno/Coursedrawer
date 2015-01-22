namespace ModCommader.ModLoader
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Xml;

    public class ModDetail
    {
        public bool IsActivated { get; set; }
        public bool Multiplayer { get; set; }

        public long FileSize { get; set; }

        public double Price { get; set; }
        public double Upkeep { get; set; }

        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public string MachineType { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string XmlFileName { get; set; }
        public string BrandImagePath { get; set; }
        public string Hash { get; set; }
        public string FullPath { get; set; }

        public Bitmap Image { get; set; }
        public Bitmap BrandImage { get; set; }

        public List<ModDetail> ShopItems { get; set; }

        public ModDetail()
        {
            ShopItems = new List<ModDetail>();
        }
    }
}
