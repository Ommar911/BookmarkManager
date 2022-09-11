using BookmarkManager.Model;

namespace BookmarkManager.Components.Collections
{
    partial class CreateCollectionComponent
    {
        private string NameCollection { get; set; }

        GoogleDriveController DriveService = new GoogleDriveController();
        private async void CreateCollection()
        {
            await this.onResult.InvokeAsync(false);
            var collection = new Collection
            {
                Id = this.DriveService.GetListDrive().CollectionList.Count,
                Name = this.NameCollection
            };

            this.DriveService.CreateCollection(collection);
        }
    }
}
