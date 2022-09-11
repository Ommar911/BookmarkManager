namespace BookmarkManager.Components.BookmarkFolder
{
    partial class BookmarkComponent
    {
        GoogleDriveController DriveService = new GoogleDriveController();
        private void DeleteBookmark()
        {
            this.DriveService.DeleteBookmark(this.Bookmark);
        }
    }
}
