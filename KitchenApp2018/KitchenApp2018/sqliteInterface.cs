using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenApp2018
{
    public interface sqliteInterface
    {
        SQLiteConnection GetConnection();
    }
}
