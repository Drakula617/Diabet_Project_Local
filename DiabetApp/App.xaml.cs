using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace DiabetApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Window.AddProductInLine addProductInLine;



        public static DiabetDBEntities2 db = new DiabetDBEntities2();



        public static Diary_View diary_View = new Diary_View();
    }
}
