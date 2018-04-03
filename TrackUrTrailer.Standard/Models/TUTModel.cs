using System;
namespace TrackUrTrailer.Standard
{
    public class TUTModel : ICosmosEntity
    {
        #region ICosmosEntity Requirements
        public string id { get; set; }
        public string _etag { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        #endregion

        public TUTModel()
        {

        }
    }
}
