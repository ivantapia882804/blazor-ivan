[FunctionName("ProductsGet")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "products")] HttpRequest req,
    ILogger log)
