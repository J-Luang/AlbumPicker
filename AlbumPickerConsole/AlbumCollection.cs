using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumPickerConsole
{
    class AlbumCollection
    {
        private List<Album> alubums;
        public List<Album> Alubums { get => alubums; set => alubums = value; }
    }
}
