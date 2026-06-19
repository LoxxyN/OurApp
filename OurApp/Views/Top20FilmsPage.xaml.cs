using System.Collections.ObjectModel;

namespace OurApp.Views;

public partial class Top20FilmsPage : ContentPage
{
    public class FilmModel
    {
        public string Title { get; set; }
        public string YearAndGenre { get; set; }
        public string ImageUrl { get; set; }
    }

    public ObservableCollection<FilmModel> Films { get; set; }

    public Top20FilmsPage()
    {
        InitializeComponent();

        Films = new ObservableCollection<FilmModel>
        {
            new FilmModel {
                Title = "1. Аватар: Огонь и пепел",
                YearAndGenre = "2025 • Фантастика, Экшен",
                ImageUrl = "avatar.jpeg"  // ? Только имя файла
            },
            new FilmModel {
                Title = "2. Микки 17",
                YearAndGenre = "2025 • Фантастика, Драма",
                ImageUrl = "mikki17.jpeg"
            },
            new FilmModel {
                Title = "3. Супермен",
                YearAndGenre = "2025 • Фэнтези, Экшен",
                ImageUrl = "superman.jpeg"
            },
            new FilmModel {
                Title = "4. Громовержцы",
                YearAndGenre = "2025 • Экшен, Комедия",
                ImageUrl = "thunderbolt.jpeg"
            },
            new FilmModel {
                Title = "5. Фантастическая четвёрка",
                YearAndGenre = "2025 • Фантастика, Приключения",
                ImageUrl = "fantastic4.jpeg"
            },
            new FilmModel {
                Title = "6. Шрек 5",
                YearAndGenre = "2026 • Мультфильм, Комедия",
                ImageUrl = "shrek5poster.jpeg"
            },
            new FilmModel {
                Title = "7. Бэтмен: Часть 2",
                YearAndGenre = "2026 • Детектив, Криминал",
                ImageUrl = "batman2.jpeg"
            },
            new FilmModel {
                Title = "8. Мандалорец и Грогу",
                YearAndGenre = "2026 • Фантастика, Приключения",
                ImageUrl = "grogu2.jpeg"
            },
            new FilmModel {
                Title = "9. Мстители: Судный день",
                YearAndGenre = "2026 • Экшен, Фантастика",
                ImageUrl = "avengers.jpeg"
            },
            new FilmModel {
                Title = "10. История игрушек 5",
                YearAndGenre = "2026 • Мультфильм, Семейный",
                ImageUrl = "historytoy5.jpeg"
            },
            new FilmModel {
                Title = "11. Дюна: Пророчество",
                YearAndGenre = "2025 • Фантастика, Драма",
                ImageUrl = "duna.jpeg"
            },
            new FilmModel {
                Title = "12. Блэйд",
                YearAndGenre = "2025 • Ужасы, Экшен",
                ImageUrl = "blade.jpeg"
            },
            new FilmModel {
                Title = "13. Джон Уик: Предыстория",
                YearAndGenre = "2026 • Боевик, Триллер",
                ImageUrl = "johnwick.jpeg"
            },
            new FilmModel {
                Title = "14. Годзилла против Конга 3",
                YearAndGenre = "2026 • Экшен, Фантастика",
                ImageUrl = "godzilla.jpeg"
            },
            new FilmModel {
                Title = "15. Трон: Арес",
                YearAndGenre = "2025 • Фантастика, Киберпанк",
                ImageUrl = "tron.jpeg"
            },
            new FilmModel {
                Title = "16. Вызов 2",
                YearAndGenre = "2026 • Драма, Космос",
                ImageUrl = "vizov.jpeg"
            },
            new FilmModel {
                Title = "17. Охотники за привидениями 6",
                YearAndGenre = "2026 • Комедия, Фэнтези",
                ImageUrl = "ghostbusters.jpeg"
            },
            new FilmModel {
                Title = "18. Minecraft: Фильм",
                YearAndGenre = "2025 • Приключения, Фэнтези",
                ImageUrl = "minecraft.jpeg"
            },
            new FilmModel {
                Title = "19. Смерть на Ниле 2",
                YearAndGenre = "2025 • Детектив",
                ImageUrl = "nil.jpeg"
            },
            new FilmModel {
                Title = "20. Секретные материалы: Перезагрузка",
                YearAndGenre = "2026 • Триллер, Фантастика",
                ImageUrl = "xfiles.jpeg"
            }
        };

        FilmsCarousel.ItemsSource = Films;
    }
}