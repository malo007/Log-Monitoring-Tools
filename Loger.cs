namespace <Dein Namespace>
{
    public class Logger
    {
        // Pfad zur Log-Datei
        string logFilePath = @"<Dein Pfard zur log.txt>";

        // Methode zum Schreiben in die Log-Datei
        public void Log(string logMessage)
        {
            // Schreibe die Nachricht in die Log-Datei
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(String.Format(DateTime.Now.ToString() + ": " + logMessage));
            }
        }
    }
}
