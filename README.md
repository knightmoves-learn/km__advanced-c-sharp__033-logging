# 032 Swagger

## Lecture

[![# Swagger (Part 1)](https://img.youtube.com/vi/1E4uIz_DkU4/0.jpg)](https://www.youtube.com/watch?v=1E4uIz_DkU4)
[![# Swagger (Part 2)](https://img.youtube.com/vi/rZzhNrmw3zA/0.jpg)](https://www.youtube.com/watch?v=rZzhNrmw3zA)

## Instructions

In `HomeEnergyApi/Program.cs`
- Add the method `AddLogging()` to `builder.services()`

In `HomeEnergyApi/Filters/GlobalExceptionFilter.cs`
- On `GlobalExceptionFilter` add a private property of type `ILogger<GlobalExceptionFilter>`
- Modify the `OnException()` method so that...
    - The newly added property of type `ILogger<GlobalExceptionFilter>` calls `LogError()` with the following arguments
        - The `Exception` that ocurred
        - A string with the value `"An error occurred: {ErrorMessage}"`
        - The `Message` property on the `Exception` that ocurred
    - Existing functionality should stay in place

In `HomeEnergyApi/Controllers/AuthenticationControllerV1`
- Add a new private readonly property of type `ILogger<AuthenticationControllerV2>` and add it to the constructor on `AuthenticationControllerV1`
- Modify `Register()` so that...
    - Replace all instances of `Console.WriteLine` with calling `LogInformation()` on the new `ILogger<AuthenticationControllerV2>` property. Log the same information that was previously being written to the console.
    - Call `LogDebug()` on the new `ILogger<AuthenticationControllerV2>` property after the `User` is saved, passing the message `Saved Username: $USERNAME` where $USERNAME is the `Username` of the `User` being saved.


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
