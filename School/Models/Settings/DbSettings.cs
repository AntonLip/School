namespace School.Models.Settings
{
    public class DbSettings
    {
        public static string DbServer { get; set; }
        public static string DbPort { get; set; }
        public static string DbUser { get; set; }
        public static string DbPassword { get; set; }
        public static string Database { get; set; }


        public static string GetConnectionString()
        {
            return String.Format($"server={DbServer},{DbPort}; Initial Catalog={Database}; User ID={DbUser};Password={DbPassword}");
        }
    }
}
