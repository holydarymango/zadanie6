# практическая 6
Эта работа, выполнена Банзеруком Д.В, студентом группы П22-3.1, которая демонстрирует систему авторизации с использованием Entity Framework и SQL Server. Работа включает в себя окна для входа и регистрации пользователя.

## Функционал

- Окно входа: Позволяет пользователям входить в систему.
- Окно регистрации: Позволяет новым пользователят создатвать учетную запись.
- Успешная регистрация:Подтверждение успешной регистрации.
- Успешный вход: Подтверждение успешного входа в учетную запись.


## Скриншоты

1. Окно входа:
   
   ![](https://github.com/Durax66/ItogOOP-Tusk6---/blob/master/screenshots/screen%201.jpeg)

2.Окно регистрации: 

   ![](https://github.com/Durax66/ItogOOP-Tusk6---/blob/master/screenshots/screen%202.jpeg)
## Установка

1. Клонируйте репозиторий:
   
   git clone https://github.com/holydarymango/zadanie6
    
   2. Откройте проект в Visual Studio:
   - Запустите Visual Studio.
   - Выберите "Открыть проект" и перейдите к папке, куда вы клонировали репозиторий.
   - Выберите файл решения (.sln) и откройте его.

3. Убедитесь, что у вас установлен SQL Server и Entity Framework:
   - Убедитесь, что у вас установлен SQL Server (можно использовать SQL Server Express).
   - Убедитесь, что у вас установлены необходимые пакеты NuGet для Entity Framework.

4. Настройте строку подключения в файле appsettings.json:
   - Откройте файл appsettings.json в корне проекта.
   - Найдите раздел ConnectionStrings и измените строку подключения на вашу, например:
     
     "ConnectionStrings": {
         "DefaultConnection": "Server=your_server;Database=your_database;User   Id=your_username;Password=your_password;"
     }
     

5. Обновите базу данных:
   - Откройте консоль диспетчера пакетов (Tools > NuGet Package Manager > Package Manager Console).
   - Выполните команду для применения миграций:
     
     Update-Database
     

6. Запустите проект:
   - Нажмите F5 или выберите "Запустить" в меню, чтобы запустить приложение.
