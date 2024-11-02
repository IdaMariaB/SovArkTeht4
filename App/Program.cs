using AppLogger;
using Humanizer;
string word = "kissa";
string luku = 1000.ToWords();
DateTime datetime = DateTime.Now.AddDays(4);
string newDate = datetime.Humanize();
Logger.Log(word);
Logger.Log(luku);
Logger.Log(newDate);