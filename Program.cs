﻿using System;
using EncapsulationProject;

namespace project
{

    class Program
    {

        public static void Main()
        {
           Students students = new Students("Serhii", "Ryzhuk", 19);

            Shedule shedule = new Shedule();

            shedule.ShowShedule();

            students.Studentinfo();

            Teacher teacher = new Teacher();
            teacher.TeacherInfo();

            Classes classes = new Classes();

            classes.Students();

        }


           


    }


}

//private: закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.
//private protected: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.
//protected: такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.
//internal: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.
//protected internal: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.
//public: публичный, общедоступный компонент класса или структуры. Такой компонент доступен из любого места в коде, а также из других программ и сборок.

