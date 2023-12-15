from flask import Flask, request, jsonify, render_template

from detection import detect_plate, extract_number_plate_text, init_model, init_reader
import psycopg2

from util import hash_string, get_current_day

app = Flask(__name__, template_folder='templates')

from datetime import datetime
DATABASE_URI = "dbname=smart_parking user=postgres password=Abc12345 host=localhost port=5432"
connection = None
def init_connection():
    global connection
    try:
        connection = psycopg2.connect(DATABASE_URI)
        print("Successfully connect")
    except Exception as e:
        print("Error when connect to DB")

def get_user(username, password):
    global connection
    cursor = connection.cursor()
    hashed_password = hash_string(password)
    # Use parameterized query to prevent SQL injection
    try:
        cursor.execute('SELECT * FROM "user" WHERE name = %s AND password = %s', (username, hashed_password))
    except Exception as e:
        print("Error when Checking User")

    users = cursor.fetchall()
    if len(users) > 0:
        return users[0]
    return None

@app.get("/detect")
def detect():
    image_path = request.args.get('image')
    plate,image_file, err = detect_plate(image_path)
    if err is not None:
        return jsonify({
            "PlateText": "",
            "PlateExtractPath": "",
            "Error": err,
        })
    plate_text, plate_extract_path = extract_number_plate_text(plate, image_file)
    return jsonify({
        "PlateText": plate_text,
        "PlateExtractPath": plate_extract_path,
        "Error": None,
    })


@app.route('/card', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        username = request.form.get('username')
        password = request.form.get('password')

        # Check username and password
        usr = get_user(username, password)
        if usr is not None:
            # Successful login
            print(usr[3])
            path = f"{usr[3]}_{get_current_day()}.png"
            return render_template('index.html', username=username, path=path)
        else:
            # Failed login
            error_message = "Invalid username or password. Please try again."
            return render_template('index.html', error_message=error_message)

    # Default behavior for GET requests
    return render_template('index.html')

if __name__ == '__main__':
    init_model()
    init_reader()
    init_connection()
    app.run(debug=True, port=3000)