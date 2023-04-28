using System;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    public static class TransactionsLoader
    {
        public static void LoadTransactions(DataContext context)
        {
            Pohikonto20230401(context); // Põhikonto rahade liikumine 01.04.2023
            LHVArvelduskonto345645633(context);
            LHVKasvukonto236554211(context);
            LHVVäärtpaberikonto973647626(context);
        }

        private static void Pohikonto20230401(DataContext context)
        {
            var swed = context.Accounts.GetByName("Põhikonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -20m,
                Securable = eur,
                Description = "PRISMA POS/XSD/9393873/9392" // Kommid
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -5m,
                Securable = eur,
                Description = "Ülekanne sõbrale" // Raha sõbrale
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -15m,
                Securable = eur,
                Description = "Arve B837378992/353535" // Telefoniarve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            swed.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == swed));
        }
        
        private static void LHVArvelduskonto345645633(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV arvelduskonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Raha arvelduseks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });
            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void LHVKasvukonto236554211(DataContext context)

        {
            var lhv = context.Accounts.GetByName("LHV kasvukonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 100m,
                Securable = eur,
                Description = "Raha kasvamiseks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });
            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void LHVVäärtpaberikonto973647626(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV väärtpaberikonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 100m,
                Securable = eur,
                Description = "Raha väärtpaberiteks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -50m,
                Securable = eur,
                Description = "Tesla väärtpaberid"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });
            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }
    }
}
