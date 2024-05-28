using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; // for methods converting between .NET & JSON
using Newtonsoft.Json.Linq; // for JSON objects
using Microsoft.CognitiveServices.Speech; // for SpeechSynthesizer

namespace StoryGeneratorFrontEnd
{
    public partial class MainForm : Form
    {
        private SpeechSynthesizer synthesizer;

        public MainForm() // Constructor
        {
            try
            {
                
                InitializeComponent();
                InitializeSpeechSynthesizer();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form initialization: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialize the speech synthesizer
        private void InitializeSpeechSynthesizer()
        {
            try
            {
               
                var config = SpeechConfig.FromSubscription("Azure Key", "region");
                synthesizer = new SpeechSynthesizer(config);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing SpeechSynthesizer: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for generate story button
        private async void buttonGenerateStory_Click(object sender, EventArgs e)
        {
            try
            {
                string prompt = promptRichBox.Text; // Get user prompt text
                string genre = genreComboBox.SelectedItem.ToString(); // Get the selected genre
                string jsonResponse = await GenerateStory(prompt, genre); // Call the method
                JObject json = JObject.Parse(jsonResponse); // JSON response
                string story = json["story"].ToString(); // Extract story from JSON object
                StoryGeneratorRichBox.Text = story; // Display story
            }
            catch (HttpRequestException httpEx) // Catch network errors
            {
                MessageBox.Show($"Error in requesting story: {httpEx.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException jsonEx) // Catch errors related to JSON
            {
                MessageBox.Show($"Error parsing JSON response: {jsonEx.Message}", "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Catch all other errors
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method for generating story by sending a POST request to backend Python service
        private async Task<string> GenerateStory(string prompt, string genre)
        {
            using (HttpClient client = new HttpClient()) // Create a client instance
            {
                try
                {
                    // Dict to store data to be sent to the POST request
                    var values = new Dictionary<string, string>
                    {
                        { "prompt", prompt },
                        { "genre", genre },
                        { "max_length", "200" }
                    };
                    // Create a String content object and serialize the dict
                    var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");
                    // Send the POST request to the URL
                    var response = await client.PostAsync("http://127.0.0.1:5000/generate-story", content);
                    response.EnsureSuccessStatusCode(); // Ensure the response success, if not throw an error
                    return await response.Content.ReadAsStringAsync(); // Return string response
                }
                catch (Exception ex) // Catch all exceptions
                {
                    HandleAllException(ex); // Call the centralized exception handler
                    return "An error occurred, please try again."; // Return a generic error message
                }
            }
        }

        // Create a handling error method as a centralized handler
        private void HandleAllException(Exception ex)
        {
            if (ex is HttpRequestException)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex is JsonException)
            {
                MessageBox.Show($"JSON parsing error: {ex.Message}", "JSON parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //method to handle asynchronous disposal of the synthesizer
        private async Task DisposeSynthesizerAsync()
        {
            if (synthesizer != null)
            {
                await synthesizer.StopSpeakingAsync().ConfigureAwait(false);
                synthesizer.Dispose();
                synthesizer = null;
            }
        }


        private void promptRichBox_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event handling
        }


        // Handle button to read the generated story
        private async void ReadStoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string textToRead = StoryGeneratorRichBox.Text;
                if (!string.IsNullOrEmpty(textToRead))
                {
                    await synthesizer.SpeakTextAsync(textToRead);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading story: {ex.Message}", "Speech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
