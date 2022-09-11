using BookmarkManager.Model;
namespace BookmarkManager.Components.BookmarkFolder
{
    partial class EditBookmarkComponent
    {
        private string Name { get; set; }
        private string Path { get; set; }

        GoogleDriveController DriveService = new GoogleDriveController();
        private void EditCollection()
        {
            this.IsOpened = false;
            var bookmark = new Bookmark
            {
                Id = this.IdCard,
                Name = this.Name,
                Path = this.Path
            };

            this.DriveService.EditBookmark(bookmark);
        }
    }
}
