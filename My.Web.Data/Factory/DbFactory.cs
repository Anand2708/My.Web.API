//using System;
//using System.Collections.Generic;
//using System.Text;


//namespace My.Web.Data.Factory
//{
//    public class DbFactory : Disposable, IDbFactory
//    {
//        private PatientDbContext _dbContext;

//        public PatientDbContext Init()
//        {
//            return _dbContext ?? (_dbContext = new PatientDbContext());
//        }

//        protected override void DisposeCore()
//        {
//            if (_dbContext != null)
//                _dbContext.Dispose();
//        }
//    }
//}
