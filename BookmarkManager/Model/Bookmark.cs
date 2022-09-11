﻿namespace BookmarkManager.Model
{
    public class Bookmark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int CollectionId { get; set; }
    }
}
