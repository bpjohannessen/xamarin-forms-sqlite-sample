using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Alus
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}