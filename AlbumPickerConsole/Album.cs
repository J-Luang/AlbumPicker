using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumPickerConsole
{
    class Album
    {
        int albumId;
        int id;
        string title;
        string url;
        string thumbnailUrl;

        public int AlbumId { get => albumId; set => albumId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Url { get => url; set => url = value; }
        public string ThumbnailUrl { get => thumbnailUrl; set => thumbnailUrl = value; }
    }
}
