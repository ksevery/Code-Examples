namespace Examples.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExamplesModel : DbContext
    {
        // Your context has been configured to use a 'ExamplesModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Examples.Data.ExamplesModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ExamplesModel' 
        // connection string in the application configuration file.
        public ExamplesModel()
            : base("name=ExamplesModel")
        {
        }

        public virtual DbSet<Example> Examples { get; set; }
    }
}