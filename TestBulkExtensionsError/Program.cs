using TestBulkExtensionsError;

using var dbContext = new TestDbContext();
Console.WriteLine(dbContext.Clients.Count());