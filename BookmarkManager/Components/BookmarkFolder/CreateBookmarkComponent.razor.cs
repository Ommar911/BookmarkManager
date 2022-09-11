using BookmarkManager.Model;
using Newtonsoft.Json;
using System.IO;

namespace BookmarkManager.Components.BookmarkFolder
{
    partial class CreateBookmarkComponent
    {
        private string NamePage { get; set; }
        private string Path { get; set; }

        GoogleDriveController DriveService = new GoogleDriveController();
        private void CreateBookmark()
        {
            this.IsOpened = false;
            var bookmark = new Bookmark
            {
                Id = DriveService.GetListDrive().BookmarkList.Count,
                Name = this.NamePage,
                Path = this.Path,
                CollectionId = this.IdCollection
            };
            this.NamePage = "";
            this.Path = "";
            
            this.DriveService.CreateBookmark(bookmark);
        }
    }
}
