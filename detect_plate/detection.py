import os
import cv2
from lib_detection import detect_lp, im2single, load_model
import easyocr
import numpy as np
import re

from util import normalize_image, replace_with_dict, current_milli_time

root = os.path.dirname(os.path.abspath(__file__))
extract_dir_path = f"{root}\extract"
global wpod_net

def init_model():
    global wpod_net
    wpod_net_path = "wpod-net_update1.json"
    wpod_net = load_model(wpod_net_path)


def detect_plate(image_path):
    detect_plate_img = ""
    image_file = os.path.basename(image_path)
    # Đọc file ảnh đầu vào
    Ivehicle = cv2.imread(image_path)
    Ivehicle = cv2.resize(Ivehicle, (900, 700))

    # Kích thước lớn nhất và nhỏ nhất của 1 chiều ảnh
    Dmax = 608
    Dmin = 310

    # Lấy tỷ lệ giữa W và H của ảnh và tìm ra chiều nhỏ nhất
    ratio = float(max(Ivehicle.shape[:2])) / min(Ivehicle.shape[:2])
    side = int(ratio * Dmin)
    bound_dim = min(side, Dmax)

    _, LpImg, lp_type = detect_lp(wpod_net, im2single(Ivehicle), bound_dim, lp_threshold=0.5)

    if len(LpImg):
        detect_plate_img = normalize_image(LpImg[0])
    return detect_plate_img, image_file


def extract_number_plate_text(plate, image_file):
    pattern = r'[^A-Za-z0-9\-]+'
    plateResult = {}
    # Load the image of the number plate
    extract_path = f"{extract_dir_path}\{image_file}"

    reader = easyocr.Reader(["en"])
    results = reader.readtext(plate)

    for result in results:
        bounding_box = result[0]
        bounding_box_int = np.array(bounding_box, dtype=int)

        # Draw the bounding box around the text box
        cv2.rectangle(plate, bounding_box_int[0], bounding_box_int[2], (0, 255, 0), 2)
        plateResult[bounding_box_int[0][1]] = result[1]

    cv2.imwrite(extract_path, plate)
    sorted_items = sorted(plateResult.items())
    sorted_items = [item[1] for item in sorted_items]

    # Concatenate the values into a single string
    concatenated_string = ""
    for index, value in enumerate(sorted_items):
        temp_str = re.sub(pattern, '', str(value))
        if index == 0:
            temp_str = temp_str[:-1] + replace_with_dict(temp_str[-1], None)
            concatenated_string = f"{temp_str}"
        elif index == 1:
            concatenated_string += f" {replace_with_dict(value, None)}"
    return concatenated_string, extract_path
