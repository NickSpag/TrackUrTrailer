using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
//using Microsoft.Azure.Documents.Linq;

namespace TrackUrTrailer.Standard
{
    public class CosmosSynchronization
    {
        public CosmosSynchronization()
        {
        }

        Uri collectionLink;
        string databaseId;
        string collectionId;

        public DocumentClient Client { get; private set; }

        public void InitializeCollection(string databaseId, string collectionId, string authKey)
        {
            this.databaseId = databaseId;
            this.collectionId = collectionId;

            collectionLink = UriFactory.CreateDocumentCollectionUri(databaseId, collectionId);
            Client = new DocumentClient(UriFactory.CreateDocumentCollectionUri(databaseId, collectionId), authKey);
        }

        //public async Task<List<T>> GetItems<T>() where T : TUTModel
        //{
        //    //var query = Client.CreateDocumentQuery<T>(collectionLink, new FeedOptions { MaxItemCount = -1 })
        //    //                  .AsDocumentQuery();

        //    //var tList = new List<T>();
        //    //while (query.HasMoreResults)
        //    //{
        //    //    tList.AddRange(await query.ExecuteNextAsync<T>());
        //    //}

        //    //return tList;
        //}

        //public async Task<T> GetItem<T>(string documentId) where T : TUTModel
        //{
        //    var query = Client.CreateDocumentQuery(UriFactory.CreateDocumentUri(databaseId, collectionId, documentId))
        //                      .AsDocumentQuery();

        //    var item = await query.ExecuteNextAsync();

        //    return item?.FirstOrDefault();
        //}

        public async Task<T> InsertItemAsync<T>(T item) where T : TUTModel
        {
            var result = await Client.CreateDocumentAsync(collectionLink, item);
            item.id = result.Resource.Id;

            return item;
        }

    }
}
