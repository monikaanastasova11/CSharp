﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.ViewModels
{
    public class CategoryInfoViewModel : ICategoryInfoViewModel
    {
        public CategoryInfoViewModel(int id, string name, int postCount )
        {
            this.Id = id;
            this.Name = name;
            this.PostCount = postCount;
        }
        public int Id { get; }

        public string Name { get; }

        public int PostCount { get; }
    }
}
