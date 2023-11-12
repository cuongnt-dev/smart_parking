from flask import Flask, request, jsonify

from detection import detect_plate, extract_number_plate_text, init_model

app = Flask(__name__)


@app.get("/detect")
def detect():
    image_path = request.args.get('image')
    plate,image_file = detect_plate(image_path)
    plate_text, plate_extract_path = extract_number_plate_text(plate, image_file)
    return jsonify({
        "PlateText": plate_text,
        "PlateExtractPath": plate_extract_path
    })


if __name__ == '__main__':
    init_model()
    app.run(debug=True, port=3000)