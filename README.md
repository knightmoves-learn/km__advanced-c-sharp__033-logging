# 032 Swagger

## Lecture

[![# Swagger (Part 1)](https://img.youtube.com/vi/1E4uIz_DkU4/0.jpg)](https://www.youtube.com/watch?v=1E4uIz_DkU4)
[![# Swagger (Part 2)](https://img.youtube.com/vi/rZzhNrmw3zA/0.jpg)](https://www.youtube.com/watch?v=rZzhNrmw3zA)

## Instructions

In `HomeEnergyApi/Program.cs`
- Call the following methods on `builder.Services`
    - `AddVersionedApiExplorer()` with the following passed options
        - `GroupNameFormat` as `'v'VVV`
        - `SubstituteApiVersionInUrl` as `true`
    - `AddSwaggerGen()` with the following passed options
        - Create two Swagger Documents using `SwaggerDoc()` and passing the following arguments
            - `"v1"` / `new OpenApiInfo { Title = "Home Energy Api V1", Version = "v1" }`
            - `"v2"` / `new OpenApiInfo { Title = "Home Energy Api V2", Version = "v2" }`
        - Add a Security Definition named `ApiKey` with an `OpenApiSecurityScheme` containing the following properties
            - In = `ParameterLocation.Header`
            - Name = `"X-Api-Key"`
            - Type = `SecuritySchemeType.ApiKey`
            - Description = `"Api key from header"`
        - Add a Security Definition named `Bearer` with an `OpenApiSecurityScheme` containing the following properties
            - In = `ParameterLocation.Header`
            - Name = `"X-Api-Key"`
            - Type = `SecuritySchemeType.ApiKey`
            - Scheme = `"Bearer"`
            - BearerFromat = `"JWT"`
            - Description = `"Api key from header"`
        - Add a Security Requirement with `AddSecurityRequirement()`, passing an `OpenApiSecurityRequirement` with the following items
            - A new `OpenApiSecurityScheme` with a `Reference` to the `ApiKey` Security Definition followed by an empty `List<string>`
            - A new `OpenApiSecurityScheme` with a `Reference` to the `Bearer` Security Definition followed by an empty `List<string>`
- Configure the app to only require `ApiKeyMiddleware`, Authentication, and Authorization, when the requested path does not start with `/swagger` by using `app.UseWhen()`
- Configure the app to use Swagger by using `app.UseSwagger()`
- Configure the app to use the Swagger UI, by using `app.UseSwaggerUI` and passing the following options
    - Create a swagger endpoint with `SwaggerEndpoint()` passing the path `"/swagger/v1/swagger.json"` and title `"Home Energy Api V1"`
    - Create a swagger endpoint with `SwaggerEndpoint()` passing the path `"/swagger/v2/swagger.json"` and title `"Home Energy Api V2"`
    - Set the `RoutePrefix` to `"swagger"`

## Additional Information
- Do not remove or modify anything in `HomeEnergyApi.Tests`
- Some Models may have changed for this lesson from the last, as always all code in the lesson repository is available to view
- Along with `using` statements being added, any packages needed for the assignment have been pre-installed for you, however in the future you may need to add these yourself

## Building toward CSTA Standards:
- Document design decisions using text, graphics, presentations, and/or demonstrations in the development of complex programs (3A-AP-23) https://www.csteachers.org/page/standards
- Systematically design and develop programs for broad audiences by incorporating feedback from users (3A-AP-19) https://www.csteachers.org/page/standards

## Resources
- https://swagger.io/
- https://github.com/dotnet/aspnet-api-versioning/wiki/API-Documentation

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
