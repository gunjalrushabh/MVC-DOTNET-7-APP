namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBmanager
{

    public static string connstring = @"server=localhost;
                                port=3307;
                                user=root;
                                password=root123;
                                database=transflower";



/*UPDATE table_name
SET column1 = value1, column2 = value2, ...
WHERE condition; */

public static void update(int id ,string name,string location)
{
     MySqlConnection con =new MySqlConnection();
    con.ConnectionString=connstring;
     try{
          con.Open();
        string query= "UPDATE departments set name = '"
        +name+"',location = '"+ location+"' Where Id= "+id;
 MySqlCommand cmd=new MySqlCommand(query,con);
       
         cmd.ExecuteNonQuery();
        
    }
     catch(Exception e){Console.WriteLine(e.Message);}
    finally{
        con.Close();
    }
    return;
}


public static void Deletedb(int id)
{
    
    MySqlConnection con =new MySqlConnection();
    con.ConnectionString=connstring;
    try{
          con.Open();
        string query="delete from departments where id ="+id;
        MySqlCommand cmd=new MySqlCommand(query,con);
       
         cmd.ExecuteNonQuery();
         

    }
    catch(Exception e){Console.WriteLine(e.Message);}
    finally{
        con.Close();
    }
    return;
}


public static bool Insert(int id,string name,string location)
{

 bool  status=false;
    string query="insert into departments(id,name,location)"+"Values('"+id+"','"+name+"','"+location+"')";
  MySqlConnection con=new MySqlConnection();
    con.ConnectionString=connstring;
try{
con.Open();
MySqlCommand cmd=new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
status=true;

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally{
    con.Close();
}
return status;
}


public static List<Department> GetallDepartments()
{
    List<Department>list=new List<Department>();

MySqlConnection con=new MySqlConnection();
con.ConnectionString=connstring; //gets the mysql connection string which client is to be client


try{
con.Open();

MySqlCommand cmd=new MySqlCommand();
cmd.Connection=con;

string query="select * from departments";
cmd.CommandText=query;

MySqlDataReader reader=cmd.ExecuteReader();
    
    while(reader.Read())
    {
int id= int.Parse(reader["id"].ToString());
string name=reader["name"].ToString();
string location=reader["location"].ToString();
Department dobj=new Department{
    Id=id,
    Name=name,
    Location=location
    } ;
    list.Add(dobj);
    }
   }
catch(Exception e){Console.WriteLine(e.Message);}
finally{
con.Close();
}
    
    return list;
}
}