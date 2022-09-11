using System.Collections.Generic;

namespace BookmarkManager.Model
{
    public class Repository
    {
        public List<Collection> CollectionList { get; set; } = new List<Collection>();
        public List<Bookmark> BookmarkList { get; set; } = new List<Bookmark>();
    }
}
