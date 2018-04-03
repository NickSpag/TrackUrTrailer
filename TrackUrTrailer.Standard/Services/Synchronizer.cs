//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
////using LiteDB;
//using Microsoft.Azure.Documents;

//namespace TrackUrTrailer.Standard
//{
//    public class Synchronizer
//    {
//        public Synchronizer()
//        {
//            if (string.IsNullOrWhiteSpace(CosmosAuthKey))
//                throw new Exception("You must call SyncClient.Init and provide your CosmosAuthKey");
//        }

//        static string CosmosAuthKey { get; set; }
//        public static List<string> RegisteredTypes { get; internal set; } = new List<string>();
//        public static LiteDatabase localDb { get; internal set; }

//        static Synchronizer instance = new Synchronizer();
//        public static Synchronizer Instance
//        {
//            get => instance;
//            private set => instance = value;
//        }

//        public static void Init(string cosmosAuthKey, string localConnectionString)
//        {
//            CosmosAuthKey = cosmosAuthKey;
//            localDb = new LiteDatabase(localConnectionString);
//        }

//        public void Register<T>(string databaseId, string collectionId) where T : TUTModel
//        {
//            //don't want to register twice because x, y, z. 
//            if (RegisteredTypes.Contains(nameof(T))) return;

//            //CosmosManager<T>.Manager.InitializeCollection(databaseId, collectionId, CosmosAuthKey);
//            RegisteredTypes.Add(nameof(T));
//        }

//        public async Task PullAsync<T>() where T : TUTModel
//        {
//            //var items = await CosmosManager<T>.Manager.GetItems();
//            //var localItemCollection = localDb.GetCollection<T>(nameof(T));
//            //var syncConflicts = new Dictionary<T, LiteException>();

//            //foreach (var item in items)
//            //{
//            //    try
//            //    {
//            //        localItemCollection.Insert(item);
//            //    }
//            //    catch (LiteException dbExcep)
//            //    {
//            //        syncConflicts.Add(item, dbExcep);
//            //    }
//            //}

//            //if (syncConflicts.Count > 0)
//            //{
//            //    //Handle conflicts here
//            //}
//        }

//        //todo determine what happens if syncronization can't happen for whatever reason.
//        //send local push notification as part of long-running background task? if it fails
//        //waiting to synchronize notice?

//        public async Task PushAsync<T>() where T : TUTModel
//        {
//            var localItemCollection = localDb.GetCollection<T>(nameof(T));
//            var items = localItemCollection.FindAll();
//            var syncConflicts = new Dictionary<T, DocumentClientException>();

//            foreach (var item in items)
//            {
//                //try
//                //{
//                //    await CosmosManager<T>.Manager.InsertItemAsync(item);
//                //}
//                //catch (DocumentClientException docClientExcep)
//                //{
//                //    syncConflicts.Add(item, docClientExcep);
//                //}
//            }

//            if (syncConflicts.Count > 0)
//            {
//                //Handle conflicts here
//            }
//        }
//    }
//}
