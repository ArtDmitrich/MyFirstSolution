using Lesson12Library;
using Lesson12Library.NewsService;
using Lesson12Library.Enums;

//создаем новостной провайдер и добавим ему в черный список TUT.BY
var myProvider = new NewsProvider();
myProvider.AddInBlackList("TUT.BY");

//создадим несколько клиентов-подписчиков новостного провайдера. добавим категории новостей и черный список
var client1 = new Client("Jack", myProvider);
client1.AddNewsCategories(NewsCategories.News);
client1.AddNewsCategories(NewsCategories.Weather);
var client1Categories = client1.GetClientsCategories();
Console.WriteLine($"{client1.Name} categories: {client1Categories}");

var client2 = new Client("Bob", myProvider);
client2.AddNewsCategories(NewsCategories.Sport);
client2.AddNewsCategories(NewsCategories.Weather);
var client2Categories = client2.GetClientsCategories();
Console.WriteLine($"{client2.Name} categories: {client2Categories}");

var client3 = new Client("Jesus", myProvider);
client3.AddNewsCategories(NewsCategories.News);
client3.AddNewsCategories(NewsCategories.Sport);
client3.AddNewsCategories(NewsCategories.Humor);
client3.AddNewsCategories(NewsCategories.Events);

client3.AddInBlackList("БТ");
client3.AddInBlackList("ОНТ");

client3.RemoveNewsCategories(NewsCategories.News);
var client3Categories = client3.GetClientsCategories();
Console.WriteLine($"{client3.Name} categories: {client3Categories}");

var client4 = new Client("OnlyWeatherMan", myProvider);
client4.AddNewsCategories(NewsCategories.Weather);
var client4Categories = client1.GetClientsCategories();
Console.WriteLine($"{client4.Name} categories: {client4Categories}");

//создаем несколько новостных порталов, сразу передавая ссылку на провайдера
var newsPortal1 = new NewsPortal("TIMES", myProvider);
var newsPortal2 = new NewsPortal("RAIN", myProvider);
var newsPortal3 = new NewsPortal("EUROSPORT", myProvider);
var newsPortal4 = new NewsPortal("БТ", myProvider);
var newsPortal5 = new NewsPortal("ОНТ", myProvider);
var newsPortal6 = new NewsPortal("TUT.BY", myProvider);

//добавим каждому новостному порталу по несколько новостей
newsPortal1.AddNewsInPortal(new News(NewsCategories.News, "Посевная", "Опять все посеяли"));
newsPortal1.AddNewsInPortal(new News(NewsCategories.News, "Политика", "Выборы?"));
newsPortal1.AddNewsInPortal(new News(NewsCategories.Events, "ЧП в море", "Горит вода"));
newsPortal1.AddNewsInPortal(new News(NewsCategories.Weather, "Погода", "Дожди"));

newsPortal2.AddNewsInPortal(new News(NewsCategories.Humor, "New Joke", "*joke*"));
newsPortal2.AddNewsInPortal(new News(NewsCategories.Humor, "Пул Первого", "*facepalm*"));
newsPortal2.AddNewsInPortal(new News(NewsCategories.News, "Речь Его Величества", "*facepalm*"));
newsPortal2.AddNewsInPortal(new News(NewsCategories.Weather, "Погода вчера", "Снег"));

newsPortal3.AddNewsInPortal(new News(NewsCategories.Sport, "Boxing", "Хук справа"));
newsPortal3.AddNewsInPortal(new News(NewsCategories.Sport, "Биатлон", "Все выиграли"));
newsPortal3.AddNewsInPortal(new News(NewsCategories.Sport, "Хоккей", "Чья же команда победила?"));
newsPortal3.AddNewsInPortal(new News(NewsCategories.Weather, "Погода завтра", "Град"));

newsPortal4.AddNewsInPortal(new News(NewsCategories.News, "В мире", "Мирное небо"));
newsPortal4.AddNewsInPortal(new News(NewsCategories.Events, "Событие!", "Лимоны зацвели"));
newsPortal4.AddNewsInPortal(new News(NewsCategories.Sport, "Хоккей", "команда президента..."));
newsPortal4.AddNewsInPortal(new News(NewsCategories.Weather, "Погода в Минске", "Всегда ясно"));

newsPortal5.AddNewsInPortal(new News(NewsCategories.Events, "Оскар", "Хук справа"));
newsPortal5.AddNewsInPortal(new News(NewsCategories.Sport, "Биатлон", "Домрачева топ"));
newsPortal5.AddNewsInPortal(new News(NewsCategories.Humor, "Смешное", "Выборы"));
newsPortal5.AddNewsInPortal(new News(NewsCategories.Weather, "Погода Бел", "Безоблачное будущее"));

newsPortal6.AddNewsInPortal(new News(NewsCategories.Events, "Задержания медиков", "За что?"));
newsPortal6.AddNewsInPortal(new News(NewsCategories.Sport, "Олимпиада", "Белорусов не пустили"));
newsPortal6.AddNewsInPortal(new News(NewsCategories.News, "Война", "С какой стороны летят ракеты?"));
newsPortal6.AddNewsInPortal(new News(NewsCategories.Weather, "Погода завтра", "Мерзковато"));


//точка - финиш проги, чтобы поставить брейк-поинт и посмотреть какие новости куда дошли, а какие нет
Console.WriteLine("FINISH");