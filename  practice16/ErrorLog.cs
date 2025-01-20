public class ErrorLog
{
     public void LogInfo(string info)
        {
            File.AppendAllText(@"c:\log\log.txt", string.Concat("INFO: ", info));
        }

        public void LogWarning(string warning)
        {
            File.AppendAllText(@"c:\log\log.txt", string.Concat("WARNING: ", warning));
        }

        public void LogError(string error)
        {
            File.AppendAllText(@"c:\log\log.txt", string.Concat("ERROR: ", error));
        }
}