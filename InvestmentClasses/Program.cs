using System;
using InvestmentClasses.Data;
using InvestmentClasses.Data.InMemoryData;

namespace InvestmentClasses
{
    class Program
    {
        private static DataContext _dataContext = new DataContext();

        static void Main(string[] args)
        {
            IDataLoader loader = new InMemoryDataLoader();
            loader.LoadData(_dataContext);


        }
    }
}
