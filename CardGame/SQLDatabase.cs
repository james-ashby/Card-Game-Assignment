using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class SQLDatabase
    {
        public class DatabaseRow
        {
            Dictionary<string, string> Fields;

            public DatabaseRow()
            {
                Fields = new Dictionary<string, string>();
            }

            public void Add(string column_name, string field)
            {
                Fields.Add(column_name, field);
            }

            /// <summary>Gets or sets the item at the given column.</summary>
            /// <param name="s">String index representing column name to access.</param>
            /// <returns>String containing the item at this position.</returns>
            public string this[string column_name]
            {
                get
                {
                    return Fields[column_name];
                }
                set
                {
                    Fields[column_name] = value;
                }
            }

            /// <summary>Gets or sets the item at the given index (zero based).</summary>
            /// <param name="n">Index (zero based).</param>
            /// <returns>String containing the item at this position.</returns>
            public string this[int n]
            {
                get
                {
                    return Fields.ElementAt(n).Value;
                }
                set
                {
                    Fields[GetFieldName(n)] = value;
                }
            }

            public string GetFieldName(int n)
            {
                return Fields.ElementAt(n).Key;
            }

            public int RowLength
            {
                get
                {
                    return Fields.Count;
                }
            }

            public bool ContainsField(string field)
            {
                return Fields.Keys.Contains(field);
            }
        }

        public class DatabaseTable
        {
            private List<string> ColumnNames;
            private List<DatabaseRow> Rows;

            /// <summary>
            /// Load the given table from the database.
            /// </summary>
            /// <param name="table_name"></param>
            public DatabaseTable(string table_name)
            {
                Load(table_name, "SELECT * FROM " + table_name);
            }


            public DatabaseTable(string table_name, string sql_query)
            {
                Load(table_name, sql_query);
            }


            private void Load(string table_name, string sql_query)
            {
                ColumnNames = new List<string>();
                Rows = new List<DatabaseRow>();

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);    // Grab the conection string for accessing the database.

                SqlCommand command = new SqlCommand(sql_query, connection);    // Associate the given sql query with the connection.

                connection.Open();

                SqlDataReader reader = command.ExecuteReader(); // Send the sql query to the database for processing.

                for (int n = 0; n < reader.FieldCount; ++n)
                {
                    ColumnNames.Add(reader.GetName(n));
                }

                while (reader.Read())   // Access each student in turn (continue until there are no students left to read).
                {
                    DatabaseRow dr = new DatabaseRow();

                    for (int column = 0; column < ColumnCount; ++column)
                    {
                        dr.Add(ColumnNames[column], reader[column].ToString());
                    }

                    Rows.Add(dr);
                }

                connection.Close();
            }

            public DatabaseRow FindRow(string field, string value)
            {
                for (int r = 0; r < RowCount; ++r)
                {
                    DatabaseRow dr = GetRow(r);

                    if (dr.ContainsField(field))
                    {
                        if (dr[field] == value) return dr;
                    }
                }

                return null;
            }


            public int ColumnCount
            {
                get
                {
                    return ColumnNames.Count;
                }
            }

            public DatabaseRow GetRow(int n)
            {
                return Rows[n];
            }

            public int RowCount
            {
                get
                {
                    return Rows.Count;
                }
            }
        }
    }
}