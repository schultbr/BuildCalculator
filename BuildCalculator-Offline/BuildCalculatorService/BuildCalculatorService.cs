using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


//using BuildCalculatorModel;

namespace BuildCalculatorService
{
    public class BuildCalculatorService
    {
        private BuildCalculatorModel.DOTA2BuildCalculatorEntities context;

        public BuildCalculatorService()
        {
            context = new BuildCalculatorModel.DOTA2BuildCalculatorEntities();
        }

        public List<BuildCalculatorModel.Champion> GetChampions()
        {
            List<BuildCalculatorModel.Champion> champs = (from c in context.Champions
                                                          orderby c.ChampionName
                                                          select c).ToList();

            return champs;
        }

        public List<BuildCalculatorModel.Item> GetItems()
        {
            List<BuildCalculatorModel.Item> items = (from i in context.Items
                                                          orderby i.ItemName
                                                          select i).ToList();

            return items;
        }

    }
}
