# Story Generator Frontend

This is the C# WinForms frontend for the Story Generator project. It interacts with a Flask backend to generate stories based on user prompts.

## Setup Instructions


- .NET Framework 4.7.2 or higher
- Visual Studio

### Steps to Setup the C# WinForms Application

1. **Create a new C# WinForms project in Visual Studio**

    - Open Visual Studio.
    - Create a new C# WinForms App (.NET Framework) project.
    - Name the project `StoryGeneratorFrontEnd`.

2. **Install Newtonsoft.Json**

    - Open the NuGet Package Manager (Tools > NuGet Package Manager > Manage NuGet Packages for Solution).
    - Search for `Newtonsoft.Json`  and `System.Net.Http` and `Microsoft.CognitiveServices.Speech` and install all three.

3. **MainForm.cs**

 Dependencies and Libs
   using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;


5. **Run the Application**
1. 
    -Start with the backend Python project
    -Open the terminal and navigate to the project folder
    - Start the Flask server by running `python app.py` in the backend project directory.
2.
    - Open a second terminal and enter the command: Invoke-RestMethod -Uri http://127.0.0.1:5000/generate-story -Method Post -Body '{"prompt": "Once upon a time", "max_length": 200}' -ContentType "application/json"
     to send HTTP and HTTPS requests to RESTful web services & receive responses.
3.
    - Run the C# WinForms application from Visual Studio.
    - Enter a prompt and click the "Generate Story" button to see the the response

## Additional Notes

- Ensure that the Flask server is running before you attempt to generate a story in the C# WinForms application frontend.
- If any issues, check the console output for error messages and ensure that all dependencies are installed correctly.