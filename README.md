1. Переходим на сайт github.com
2. Регестрируемся(sing up) или логинимся (sing in)
3. В праом верхнем углу ищем значек "+" и нажимаем на него 
4. В всплывающем меню нажимаем на кнопку "new repository"
5. Настраиваем репозиторий: присваиваем имя, добавляем описание и выбираем необходимые дополнительные опции.
6. Нажимаем на кнопку "Create repository"
7. Мы находимся на странице "подсказке". Чтобы законнектить репозиторий с вашим пк следуем одной из трех инструкций. (Первые две инструкции необходимо выполнять в терминале программы VSCode)
8. Создайте файл " README.md "
9. Добавьте файл " README.md " в отслеживание через команду " git add" 
10. Добавьте первый коммит через команду " git commit -m "Initial commit" 
11. Запуште изменения в удаленный репозиторий через команду " git push "
12. Если Вы ранее не синхронизировали ваш GitHub аккаунт в программе VSCode, программа попросит Вас авторизоваться.


Создаем массив (array1) с заданными значениями {"hello", "2", "word", ":-)"}
Создаем второй массив (array2) равный длине первого (= new string[array1.Length])

Создаем метод, который будет сортировать строки массива, если длина масива меньше 3х символов, то эта строка записывается во второй массив ( if(arr1[i].Lenght <= 3) arr2[count] = arr1[i];) увеличиваем сount на 1
Цикл сортировки продолжает проверять условие  всех эллементы массива.

Поскольку мы использовали метод void который, не возвращает значения нам нужен метод который будет печатать вывод в консоль. 

Создаем метод PrintArray. В котором указываем печать всех эллементов массива.
Поскольку в методе ArraySort мы сортировали элементы и записывали их во второй массив, нам осталось только вывести второй массив в печать.

Далее можем указать еще несколько массивов и используя методы сортировать и вывести все массивы в печать.
