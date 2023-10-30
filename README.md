1.Мы начинаем с создания пустой строки ***shortString***, которая будет содержать короткие строки, заключенные в квадратные скобки.

2.Далее, у нас есть флаг ***addComma***, который используется для определения, нужно ли добавлять запятую перед добавлением следующей короткой строки. Изначально устанавливаем его в false, так как перед первой короткой строкой запятая не нужна.

3.Затем, мы вводим строки с клавиатуры с использованием Console.ReadLine(). Введенная строка разбивается на отдельные строки, используя метод ***Split***, с разделителями  и пробелами. Результатом является массив строк strings.

4.Далее мы начинаем перебирать строки в массиве strings с помощью цикла for. Мы проверяем каждую строку, и если длина строки меньше или равна 3 символам, мы добавляем ее к shortString.

5.Перед добавлением следующей короткой строки, мы проверяем флаг addComma. Если он true, добавляем запятую и пробел, иначе просто добавляем короткую строку.

6.В конце, после завершения цикла, мы закрываем квадратные скобки, получая итоговую строку, содержащую короткие строки.

7.Наконец, выводим результат на экран с помощью Console.WriteLine().