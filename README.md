# Test-11-23
Тестовое задание на позицию Стажер-программист C#

Необходимо реализовать Winformsприложение на NetFramework 4.8 в среде VisualStudio, состоящее из одной формы. 
Форма состоит из двух полей ввода и двух кнопок.
Поле 1 – имя пользователя.
Поле 2 – пароль.
Кнопка 1 – проверить.
Кнопка 2 – добавить.

При нажатии на кнопку «проверить», приложение должно сверяться с прикрепленным к письму JSON-файлом и проверить существует ли пользователь с указанными в «поле 1» и «поле 2» данными. Должно появиться всплывающее окно с текстом «пользователь существует» или «пользователя не существует» соответственно.

При нажатии на кнопку «Добавить», JSON-файл должен обновляться с добавлением нового пользователя с указанными данными. 

Необходимо предусмотреть проверку заполнения обоих полей, которая не позволяет совершать какие-либо действия, если одно из полей не заполнено.

Использовать Nuget пакет Newtonsoft.Json.

Срок: 2 дня.
