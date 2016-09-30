﻿using SPICA.Formats.H3D.Contents.Texture;
using SPICA.Serialization.BinaryAttributes;

namespace SPICA.Formats.H3D.Contents
{
    class H3DTextures
    {
        [PointerOf("PointerTable")]
        private uint PointerTableAddress;

        [CountOf("Textures"), CountOf("NameTree", 1)]
        private uint Count;

        [PointerOf("NameTree")]
        private uint NameTreeAddress;

        [TargetSection("DescriptorsSection", 1)]
        public H3DTreeNode[] NameTree;

        [TargetSection("DescriptorsSection", 1), PointerOf("Textures")]
        private uint[] PointerTable;

        [TargetSection("DescriptorsSection", 4)]
        public H3DTexture[] Textures;

        public H3DTexture this[int Index]
        {
            get { return Textures[Index]; }
            set { Textures[Index] = value; }
        }
    }
}
