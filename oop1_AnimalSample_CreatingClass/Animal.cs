using System;

namespace oop1_AnimalSample_CreatingClass
{
    class Animal
    {
        //поля
        public string name;    //кличка
        public float mass = 0; //вес
        public char color;     //цвет

        //конструкторы
        public Animal() { }
        public Animal(string name1, float mass1, char color1)
        {
            name = name1;
            mass = mass1;
            color = color1;
        }
        public Animal(string name, float mass)
        {
            this.name = name;
            this.mass = mass;
        }

        //методы
        public virtual void say()
        {
            Console.WriteLine($"{name} ({color}, {mass}) says:");
            Console.WriteLine("Abstract voice"); //издать абстрактный звук
        }
    }
//    Домашка
//        1) Создать класс автомобиль
//          Добавить поля:
//            -Марка машины (string)
//            -Модель машины (string)
//            -Год выпуска (DateTime)
//            -Год выпуска (DateTime)
//            -Количество владельцев (int)
//            -Имя текущего владельца (string) (или написанный нами ранее Person)
//          Добавить методы
//            -Новый владелец
//              На вход поступает имя нового владельца,
//              поле текущеговладельца меняет значение на новое
//              количество владельцев увеличивается на 1
//        2)
//
}
