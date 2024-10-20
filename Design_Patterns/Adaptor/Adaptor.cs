using Design_Patterns.Adaptor.AdaptorPattern.Core;
using System.Text;
using System.Text.Json;

namespace Design_Patterns.Adaptor
{
    internal class Adaptor
    {
        public static async Task  AdaptorToRun()
        {
            var PayRollCalculate_url = "https://localhost:7185/api/PayrollCalculator";
            var Reader = new EmployeesDateReader();

            var employees = Reader.GEtAllEmployees();
            var client = new HttpClient();

            foreach (var employee in employees)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, PayRollCalculate_url);
                var empolyeeAdaptor = new PayrollSystemEmployeeAdaptor(employee);
                request.Content = new StringContent(JsonSerializer.Serialize(empolyeeAdaptor), Encoding.UTF8, "application/json");


                var response = await client.SendAsync(request);
                var responseJson = await response.Content.ReadAsStringAsync();
                var salary = decimal.Parse(responseJson);

                Console.WriteLine($"Salary for Employee {employee.FullName} as of today = {salary}");

            }

            //foreach (var employee in employees)
            //{
            //    var employeeAdaptor = new PayrollSystemEmployeeAdaptor(employee);

            //    var jsonContent = JsonSerializer.Serialize(employeeAdaptor, new JsonSerializerOptions
            //    {
            //        WriteIndented = true // Optional: for easy reading in logs
            //    });

            //    // Log or print the JSON content to debug
            //    Console.WriteLine("Request JSON: ");
            //    Console.WriteLine(jsonContent);

            //    var request = new HttpRequestMessage(HttpMethod.Post, PayRollCalculate_url)
            //    {
            //        Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            //    };

            //    var response = await client.SendAsync(request);

            //    if (!response.IsSuccessStatusCode)
            //    {
            //        Console.WriteLine($"Failed to process employee {employee.FullName}: {response.StatusCode}");
            //        var errorResponse = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine($"Error details: {errorResponse}");
            //        continue;
            //    }

            //    var responseJson = await response.Content.ReadAsStringAsync();
            //    var salary = decimal.Parse(responseJson);
            //    Console.WriteLine($"Salary for Employee {employee.FullName} as of today = {salary}");
            //}

            //Console.ReadKey();
        }
    }
}
