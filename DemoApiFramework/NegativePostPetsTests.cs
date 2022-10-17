using System.Net;
using System.Net.Http.Json;
using DemoApiFramework.models;

namespace DemoApiFramework;

public class NegativePostPetsTests
{
    private string Api = "https://petstore.swagger.io/v2/pet";

   /* [Test]
    public async Task PostPetsTesting()
    {
        HttpClient client = new HttpClient();
        Pets request = new Pets
        {
            Id = "testEror",
            Category = new Category
            {
                Id = 1,
                Name = "tyu"
            },
            Name = "",
            PhotoUrls = new string[]
            {
                "sad",
                "sadasd"
            },
            Status = "Avalibe"
        };

        HttpResponseMessage result = await client.PostAsJsonAsync(Api, request);
        Console.WriteLine(await result.Content.ReadAsStringAsync());
        Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");

        Pets testPet = new Pets
        {
            Id = "NoValidType",
            Category = new Category
            {
                Id = 1,
                Name = "Cat"
            },
            Name = "KitCat",
            PhotoUrls = new string[]
            {
                "sad",
                "sadasd"
            },
            Status = "Avalibe"
        };
        result = await client.PostAsJsonAsync(Api, testPet);
        Console.WriteLine(await result.Content.ReadAsStringAsync());
        Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");

        Pets testPetError = new Pets
        {
            Id = "105",
            Category = new Category
            {
                Id = 3,
                Name = "Cat"
            },
            Name = "KitCat",
            PhotoUrls = new string[]
            {
                "sad",
                "sadasd"
            },
            Status = "Avalibe"
        };
        result = await client.PostAsJsonAsync(Api, testPetError);
        Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Код ответа от апи не соответсвует ожидаемому");
        
    } */
}