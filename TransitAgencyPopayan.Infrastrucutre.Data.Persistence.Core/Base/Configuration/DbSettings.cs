namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base.Configuration
{
    public class DbSettings
    {
        public string ConnectionString { get; set; }

        public void CopyFrom(DbSettings options)
        {
            if (options == default || options == null)
                throw new ArgumentNullException(nameof(options));

            ConnectionString = options.ConnectionString ?? throw new ArgumentNullException();
        }
    }
}