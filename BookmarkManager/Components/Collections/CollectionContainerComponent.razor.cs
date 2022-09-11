using BookmarkManager.Model;

namespace BookmarkManager.Components.Collections
{
    partial class CollectionContainerComponent
    {
        private int IdCollection { get; set; }
        GoogleDriveController DriveService = new GoogleDriveController();

        private Repository GetListDrive()
        {
            BaseContext= this.DriveService.GetListDrive();
            return this.DriveService.GetListDrive();
        }

        private void DeleteCollection(int id)
        {
            this.DriveService.DeleteCollection(id);
        }
    }
}
