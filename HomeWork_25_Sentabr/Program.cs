using HomeWork_25_Sentabr;
using Newtonsoft.Json;
using System.Text;

var book_1 = new Library
{
    Name = "Sohil",
    AutorName = "Pushkin",
};

var book_2 = new Library
{
    Name = "Ocean",
    AutorName = "Lenin"
};

 
var json = JsonConvert.SerializeObject(book_1);
var data = new StringContent(json, Encoding.UTF8, "application/json");
var url = "http://localhost:5258/api/Companies/";
using var client = new HttpClient();

//Create
var response = await client.PostAsync(url, data);
var result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);

//Get
response = await client.GetAsync(url);
result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);

var json1 = JsonConvert.SerializeObject(book_2);
var datas = new StringContent(json1, Encoding.UTF8, "application/json");
using var clients = new HttpClient();

string id = Console.ReadLine();
Guid guId = Guid.Parse(id);

var urls = $"http://localhost:5258/api/Libraries?id={guId}";

//Update
var putResponse = await client.PutAsync(urls, datas);
var putResult = await putResponse.Content.ReadAsStringAsync();
Console.WriteLine(putResult);


////Delete
//var response = await client.DeleteAsync(url);
//var deleteResult = await response.Content.ReadAsStringAsync();
//Console.WriteLine(deleteResult);