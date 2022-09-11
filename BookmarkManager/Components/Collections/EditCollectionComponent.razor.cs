using BookmarkManager.Model;

namespace BookmarkManager.Components.Collections
{
    partial class EditCollectionComponent
    {
        private string Title { get; set; }

        GoogleDriveController DriveService = new GoogleDriveController();
        private void EditCollection()
        {
            var collection = new Collection()
            {
                Id = this.IdCollection,
                Name = this.Title
            };
            this.IsOpened = false;
            this.Title = "";

            this.DriveService.EditCollection(collection);
        }
    }
}