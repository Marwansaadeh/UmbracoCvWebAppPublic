using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoCvWebApp.Helpers
{
    public static class ModelHelper 
    {
        //public class Model
        //{
        //     public class Home
        //    {
        //        public IPublishedElement Title { get; set; }
        //    }

           

        //}

        public static void GetModel<T>(this UmbracoViewPage<T> page) where T : class
        {
           
        }
        public class MarwanModel
        {

            public class Services<TModel> : WebViewPage
            {
                public override void Execute()
                {
                    throw new System.NotImplementedException();
                }
            }


        }
        public class ServicesModel
        {
            public string Id { get;set; }
        }
        public class MarwanModel<T>: WebViewPage<T>
        {
            public MarwanModel(UmbracoViewPage<T> page) : base()
            {
                Work = page.Model;
            }
           
            public override void Execute()
            {
                throw new NotImplementedException();
            }
        }

    }
}