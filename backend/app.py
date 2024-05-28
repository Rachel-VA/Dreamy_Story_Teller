""" 
Rachael Savage
MS539- Programming Concepts
Dr. briant Becote
25/5/2024

Go to README.md file to see stepts to setup environment, installations, and neccessary dependecies 
"""

from flask import Flask, request, jsonify
from transformers import pipeline

app = Flask(__name__)

# Initialize HuggingFace text generation pipeline and specify model name
story_generator = pipeline("text-generation", model="EleutherAI/gpt-neo-2.7B")

# Predefined prompts for different genres
genre_prompts = {
    "Fantasy": "In a land of magic and wonder, ",
    "Sci-Fi": "In a distant future, where technology rules, ",
    "Mystery": "On a dark and stormy night, ",
    "Adventure": "In the heart of the jungle, "
}
#define a route to bind the  URL to accept  GET request
@app.route('/generate-story', methods=['POST'])
def generate_story():
    try:
        data = request.json #get json data from the POST request
        prompt = data['prompt'] #extract prompts
        genre = data.get('genre', '') #extract genre

        max_length = int(data.get('max_length', 200)) #set length

        # for genre-specific prompt if provided
        if genre in genre_prompts:
            prompt = genre_prompts[genre] + prompt

        # Generate max length story based on defined length above
        story = story_generator(prompt, max_length=max_length)[0]['generated_text']

        return jsonify({'story': story}) #return text
    except Exception as e:
        app.logger.error(f"Error generating story:{e}")
        return jsonify({'error': 'Error processing your requestion', 'details': str(e)})

#run the app on port 5000
if __name__ == '__main__':
    app.run(port=5000)
