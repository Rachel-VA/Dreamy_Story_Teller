# Story Generator Project

This project uses a Flask backend with a Hugging Face model to generate stories based on a given prompt.

## Setup Instructions


- Python 3.7 or higher


### Steps to Setup the Environment


## 1. Create a Project Folder and navigate to it using terminal
mkdir StoryGeneratorProject
cd StoryGeneratorProject

## 2. Set Up and Activate the Virtual Environment
python -m venv venv
venv\Scripts\activate

## 3. Install Required Packages
pip install flask transformers 
pip install huggingface-hub
pip install tensorflow
pip install requirements.txt



## 4. Create Flask API server
nside your project folder, create a new file named app.py (make sure the app.py file is inside the project, not the venv folder)

## 5. Run the Flask API
python app.py
to end stop the server, Ctrl + c

## 6.Test Endpoint
Open a new terminal and run the CURL command: curl -X POST http://127.0.0.1:5000/generate-story -H "Content-Type: application/json" -d '{"prompt": "Once upon a time", "max_length": 200}'

OR the alternative command: Invoke-RestMethod -Uri http://127.0.0.1:5000/generate-story -Method Post -Body '{"prompt": "Once upon a time", "max_length": 200}' -ContentType "application/json"

