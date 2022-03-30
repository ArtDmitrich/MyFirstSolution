using Lesson12Library;
using Lesson12Library.NewsService;

var myProvider = new NewsProvider();

var client1 = new Client("Jack", myProvider);
client1.ClietsCategory.Add("humor");
client1.ClietsCategory.Add("news");

var client2 = new Client("Bob", myProvider);
client2.ClietsCategory.Add("sport");
client2.ClietsCategory.Add("events");

var client3 = new Client("Jesus", myProvider);
client3.ClietsCategory.AddRange(new List<string> { "news", "sport", "humor", "events" });

var client4 = new Client("OnlyWeatherMan", myProvider);
client4.ClietsCategory.Add("Weather");

var newsPortal1 = new NewsPortal("TIMES", myProvider);
var newsPortal2 = new NewsPortal("RAIN", myProvider);
var newsPortal3 = new NewsPortal("EUROSPORT", myProvider);


newsPortal1.AddNewsInPortal(new News("news", "Посевная", "Опять все посеяли"));
newsPortal1.AddNewsInPortal(new News("news", "Политика", "Выборы?"));
newsPortal1.AddNewsInPortal(new News("events", "ЧП в море", "Горит вода"));
newsPortal1.AddNewsInPortal(new News("weather", "Погода", "Дожди"));


newsPortal2.AddNewsInPortal(new News("humor", "New Joke", "*joke*"));
newsPortal2.AddNewsInPortal(new News("humor", "Пул Первого", "*facepalm*"));
newsPortal2.AddNewsInPortal(new News("news", "Речь Его Величества", "*facepalm*"));
newsPortal2.AddNewsInPortal(new News("weather", "Погода вчера", "Снег"));


newsPortal3.AddNewsInPortal(new News("sport", "Boxing", "Хук справа"));
newsPortal3.AddNewsInPortal(new News("sport", "Биатлон", "Все выиграли"));
newsPortal3.AddNewsInPortal(new News("sport", "Хоккей", "Чья же команда победила?"));
newsPortal3.AddNewsInPortal(new News("weather", "Погода завтра", "Град"));



Console.WriteLine("FINISH");