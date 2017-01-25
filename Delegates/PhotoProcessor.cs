using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);

        //public void Process(string path, PhotoFilterHandler filterHandler)
        //{
        //    var photo = Photo.Load(path);
        //    filterHandler(photo);
        //    photo.Save();
        //}
        //Use Func<Params,ReturnOut> 
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}