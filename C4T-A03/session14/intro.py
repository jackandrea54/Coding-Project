import requests

name = 'nghia'

url = "http://127.0.0.1:5000/"

response = requests.get(url)

print(response.status_code)
print(response.text)
# print(response.json())