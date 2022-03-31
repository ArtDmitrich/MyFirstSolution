using Lesson12Library;
using Lesson12Library.NewsService;

//создаем новостной провайдер и добавим ему в черный список TUT.BY
var myProvider = new NewsProvider();
myProvider.AddInBlackList("TUT.BY");

//создадим несколько клиентов-подписчиков новостного провайдера. добавим категории новостей и черный список
var client1 = new Client("Jack", myProvider);
client1.ClietsCategory.Add("humor");
client1.ClietsCategory.Add("news");

var client2 = new Client("Bob", myProvider);
client2.ClietsCategory.Add("sport");

var client3 = new Client("Jesus", myProvider);
client3.ClietsCategory.AddRange(new List<string> { "news", "sport", "humor", "events" });
client3.AddInBlackList("БТ");
client3.AddInBlackList("ОНТ");

var client4 = new Client("OnlyWeatherMan", myProvider);
client4.ClietsCategory.Add("Weather");

//создаем несколько новостных порталов, сразу передавая ссылку на провайдера
var newsPortal1 = new NewsPortal("TIMES", myProvider);
var newsPortal2 = new NewsPortal("RAIN", myProvider);
var newsPortal3 = new NewsPortal("EUROSPORT", myProvider);
var newsPortal4 = new NewsPortal("БТ", myProvider);
var newsPortal5 = new NewsPortal("ОНТ", myProvider);
var newsPortal6 = new NewsPortal("TUT.BY", myProvider);

//добавим каждому новостному порталу по несколько новостей
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

newsPortal4.AddNewsInPortal(new News("news", "В мире", "Мирное небо"));
newsPortal4.AddNewsInPortal(new News("event", "Событие!", "Лимоны зацвели"));
newsPortal4.AddNewsInPortal(new News("sport", "Хоккей", "команда президента..."));
newsPortal4.AddNewsInPortal(new News("weather", "Погода в Минске", "Всегда ясно"));

newsPortal5.AddNewsInPortal(new News("event", "Оскар", "Хук справа"));
newsPortal5.AddNewsInPortal(new News("sport", "Биатлон", "Домрачева топ"));
newsPortal5.AddNewsInPortal(new News("humor", "Смешное", "Выборы"));
newsPortal5.AddNewsInPortal(new News("weather", "Погода Бел", "Безоблачное будущее"));

newsPortal6.AddNewsInPortal(new News("event", "Задержания медиков", "За что?"));
newsPortal6.AddNewsInPortal(new News("sport", "Олимпиада", "Белорусов не пустили"));
newsPortal6.AddNewsInPortal(new News("news", "Война", "С какой стороны летят ракеты?"));
newsPortal6.AddNewsInPortal(new News("weather", "Погода завтра", "Мерзковато"));

//точка - финиш проги, чтобы поставить брейк-поинт и посмотреть какие новости куда дошли, а какие нет
Console.WriteLine("FINISH");