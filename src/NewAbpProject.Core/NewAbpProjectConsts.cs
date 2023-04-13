using NewAbpProject.Debugging;

namespace NewAbpProject
{
    public class NewAbpProjectConsts
    {
        public const string LocalizationSourceName = "NewAbpProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "349c1a95020e4f3884e547f014ed0c84";
    }
}
