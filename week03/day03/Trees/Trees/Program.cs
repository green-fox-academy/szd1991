/*
Create 5 trees
Store the data of them in variables in your program
for every tree the program should store its'
type
leaf color
age
sex
you can use just variables, or lists and/or maps
*/

using System;

namespace Trees
{
    class Trees
    {
        private string _type;
        private byte _leafColor;
        private int _age;
        private bool _sex;

        public Trees(string type, byte leafColor, int age, bool sex)
        {
            _type = type;
            _leafColor = leafColor;
            _age = age;
            _sex = sex;
        }

        public string GetTreeData()
        {
            return $"{_type} {_leafColor} {_age} {_sex}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trees trees = new Trees("Pine", 166, 89, true);
        }
    }
}
