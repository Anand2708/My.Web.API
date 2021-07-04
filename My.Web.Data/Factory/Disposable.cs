//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace My.Web.Data.Factory
//{
//    public class Disposable : IDisposable
//    {
//        ~Disposable()
//        {
//            Dispose(false);
//        }
//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                // clean up all managed resources, also child objects that implements IDisposable
//                DisposeCore();
//            }
//        }

//        protected virtual void DisposeCore()
//        {

//        }
//    }
//}
