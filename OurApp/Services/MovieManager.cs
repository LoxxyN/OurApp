using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OurApp.Services
{
    public static class MovieManager
    {
        public static ObservableCollection<string> Movies { get; } = new();
    }
}
