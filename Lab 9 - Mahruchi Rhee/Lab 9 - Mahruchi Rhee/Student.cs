using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_Mahruchi_Rhee
{
    class Student
    {
        // These three variables below are instance variables.
        // We set to public because this exists in this whole class.
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavColor;

        public Student(string name, string homeTown, string favoriteFood, string favoriteColor)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavColor = favoriteColor;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }

        public string GetColor()
        {
            return FavColor;
        }
    }
}
