# dz

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Для решения задачи воспользуемся языком программирования C#
Решение задачи представлено в одном классе, в котором находится один массив Main()
Поскольку используемая программа подразумевает универсальное решение для различных количеств элементов массива и различных значений элементов массива,
используя Console.Write или Console.WriteLine организуем процесс взаимодействия пользователя с программой

В программе будут использоваться 3 массива - strings[], result[], finalResult[]
strings[] - массив исходных введённых значений массива пользователем, количество которых будет заранее известно, поскольку пользователь ввёдет их изначально параметром "n"
result[] - массив является местом хранения значений, которые получаются путём проведения цикла сравнений (strings[i].Length <= 3)
finalResult[] - итоговый массив решения программы, который выводится в консоли (количество элементов массива основано на счётчике, который указывает на количество элементов, удовлетворяющих условию)

Основное вычисление подразумевается в данных строках:
for (int i = 0; i < n; i++)  // создание цикла
        {
            if (strings[i].Length <= 3)  // условие, которое подразумевает, что длина строки не должна превышать 3-х символов 
            {
                result[count] = strings[i]; // если длина строки удовлетворяет условию - True, то значение массива strings[] записывается в массив result[]
                count++; // счётчик, который выводит итоговое _количество_ получившегося массива, и на основе которого формируется finalResult[]
            }
        }
