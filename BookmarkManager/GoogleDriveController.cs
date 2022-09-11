using BookmarkManager.Model;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace BookmarkManager
{
    public class GoogleDriveController
    {
        public string filePath = @"C:\Users\OMMAR\Desktop\Prueba\DataBase.json";
        public Repository DataBase = new Repository();

        public DriveService GetServiceDrive()
        {
            string[] scopes = { DriveService.Scope.Drive };
            UserCredential credential;
            using (var stream =
                   new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credentialPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credentialPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credentialPath);
            }
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });
            return service;
        }

        public void GetDataBase()
        {
            var request = GetServiceDrive().Files.Get("1JNn_YgWdAQHLNrTJwa8qv7eHjIAKHr-j");
            var stream = new MemoryStream();
            request.Download(stream);

            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }

        public Repository GetListDrive()
        {
            using (StreamReader jsonStream = File.OpenText(filePath))
            {
                var jsonR = jsonStream.ReadToEnd();
                this.DataBase = JsonConvert.DeserializeObject<Repository>(jsonR);
            }
            return this.DataBase;
        }

        public async Task UpdateDataBase()
        {
            string updateFileId = "1JNn_YgWdAQHLNrTJwa8qv7eHjIAKHr-j";
            var updateFile = await GetServiceDrive().Files.Get(updateFileId).ExecuteAsync();

            var updateFileBody = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "DataBase.json"
            };
            await using (var uploadStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var updateRequest = GetServiceDrive().Files.Update(updateFileBody, updateFile.Id, uploadStream, "application/json");
                var result = await updateRequest.UploadAsync(CancellationToken.None);
            }
        }

        public async Task SaveChange(Repository repository)
        {
            string json = JsonConvert.SerializeObject(repository);
            File.WriteAllText(filePath, json);
            await this.UpdateDataBase();
        }

        public async void DeleteCollection(int id)
        {
            var dataBase = new Repository();
            foreach (var collection in this.GetListDrive().CollectionList)
            {
                if(collection.Id != id)
                {
                    dataBase.CollectionList.Add(collection);
                }
            }
            foreach(var bookmark in this.GetListDrive().BookmarkList)
            {
                if (bookmark.CollectionId != id)
                {
                    dataBase.BookmarkList.Add(bookmark);
                }
            }

            await this.SaveChange(dataBase);
        }

        public async void DeleteBookmark(Bookmark bookmark)
        {
            var dataBase = this.GetListDrive();
            dataBase.BookmarkList.RemoveAll(x => x.Id == bookmark.Id);

            await this.SaveChange(dataBase);
        }

        public async void EditCollection(Collection collection)
        {
            var dataBase = this.GetListDrive();
            foreach (var collection1 in dataBase.CollectionList)
            {
                if (collection1.Id == collection.Id)
                {
                    collection1.Name = collection.Name;
                }
            }

            await this.SaveChange(dataBase);
        }

        public async void EditBookmark(Bookmark bookmark1)
        {
            var dataBase = this.GetListDrive();
            foreach (var bookmark in dataBase.BookmarkList)
            {
                if (bookmark.Id == bookmark1.Id)
                {
                    bookmark.Name = bookmark1.Name;
                    bookmark.Path = bookmark1.Path;
                }
            }

            await this.SaveChange(dataBase);
        }

        public async void CreateCollection(Collection collection)
        {
            DataBase.CollectionList.Add(collection);

            await this.SaveChange(DataBase);
        }

        public async void CreateBookmark(Bookmark bookmark)
        {
            DataBase.BookmarkList.Add(bookmark);

            await this.SaveChange(DataBase);
        }
    }
}
