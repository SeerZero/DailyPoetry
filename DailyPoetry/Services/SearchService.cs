﻿using DailyPoetry.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace DailyPoetry.Services
{
    public class SearchService
    {
        private KnowledgeService _knowledgeService;

        public SearchService(KnowledgeService knowledgeService)
        {
            _knowledgeService = knowledgeService;
        }


    }

}
