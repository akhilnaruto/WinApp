using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class TransactionTypeDao
    {
        public List<TransactionType> GetAllTransactionTypes()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<TransactionType>("SELECT * FROM TransactionType").ToList();
            }
        }
    }
}