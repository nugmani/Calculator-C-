#Данная программа представляет собой часы, позволяющая работать с временем.
Мы можем ввести своё время, перевести часы вперёд, также назад  и сравнить наше время с каким-нибудь другим.

Структура класса

В классе time используются следующие данные:
-приватные
private long sec //секунды
private long min //минуты
private long hour //часы
private void add //функция сложения
private void sub //функция вычитания
private void flash //функция обнуления параметров
private long perevodsec //функция перевода в секунды
        
-конструктор
public time //создаёт экземпляр класса


public void normalize //для нормализации времени
public long get_hour //использование функции normolize для часов
public long get_min// использование функции normolize для минут
public long get_sec// использование функции normolize для секунд
public static time operator+ //перегрузка оператора +
public static time operator – // перегрузка оператора -
public static bool operator > // перегрузка оператора >
public static bool operator < // перегрузка оператора <
public static bool operator >= // перегрузка оператора >=
public static bool operator <= // перегрузка оператора <=
public static bool operator == // перегрузка оператора ==
public static bool operator != // перегрузка оператора !=
