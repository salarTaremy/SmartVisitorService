namespace SmartVisitor.Repositories
{
    public class BaseRepository {
        protected SmartVisitor.Data.SqlDb Db = new Data.SqlDb();
        protected string IMEI { get; set; }
        public BaseRepository( string  IMEI)
        {
            this.IMEI = IMEI;
        }

       

    }
}
