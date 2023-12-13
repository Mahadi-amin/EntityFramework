using AdonetPractice;

string[] parts = Console.ReadLine().Split(',');

string connectionString = "Server=DESKTOP-N8A2ENF\\SQLEXPRESS;Database=CSharpB15;User Id=csharpb15;Password=12345; Trust Server Certificate = True;";
string insertSql = "insert into students (name, address, cgpa) values(@name, @address, @cgpa)";
string updateSql = "update students set name = 'Hossain' where name = 'hossain'";
string deleteSql = "delete from students where id = 3";

Dictionary<string, object> parameters = new Dictionary<string, object>();
parameters.Add("name", parts[0]);
parameters.Add("address", parts[1]);
parameters.Add("cgpa", double.Parse(parts[2]));

AdonetUtility adonetUtility = new AdonetUtility(connectionString);
adonetUtility.ExecuteSql(insertSql, parameters);

int id = int.Parse(Console.ReadLine());

Dictionary<string, object> parameters2 = new Dictionary<string, object>();
parameters2.Add("id", id);


string selectSql = "select * from students where id = @id";
IList<Dictionary<string, object>> result = adonetUtility.GetData(selectSql, parameters2);

foreach (var row in result)
{
    foreach (var col in row)
    {
        Console.Write(col.Value);
        Console.Write(' ');
    }
    Console.WriteLine();
}

Console.WriteLine("Done");