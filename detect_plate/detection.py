import cv2
from lib_detection import load_model, detect_lp, im2single
import easyocr
import numpy as np
import re

# Đường dẫn ảnh, các bạn đổi tên file tại đây để thử nhé
img_name = "0000_08244_b.jpg"
test_img_path = f"test/{img_name}"

# Load model LP detection
wpod_net_path = "wpod-net_update1.json"
wpod_net = load_model(wpod_net_path)

# Đọc file ảnh đầu vào
Ivehicle = cv2.imread(test_img_path)
Ivehicle = cv2.resize(Ivehicle, (900, 700))

# Kích thước lớn nhất và nhỏ nhất của 1 chiều ảnh
Dmax = 608
Dmin = 310

# Lấy tỷ lệ giữa W và H của ảnh và tìm ra chiều nhỏ nhất
ratio = float(max(Ivehicle.shape[:2])) / min(Ivehicle.shape[:2])
side = int(ratio * Dmin)
bound_dim = min(side, Dmax)

_, LpImg, lp_type = detect_lp(wpod_net, im2single(Ivehicle), bound_dim, lp_threshold=0.5)

def normalize_image(image):

    image = image.astype("float32")
    image -= image.min()
    image /= image.max()
    image *= 255
    return image.astype("uint8")

if len(LpImg):
    # Xử lý đọc biển đầu tiên, các bạn có thể sửa code để detect all biển số
    filename = f'detect/{img_name}'

    # Convert the image from RGB to BGR before saving
    rgb_image = normalize_image(LpImg[0])
    # bgr_image = cv2.cvtColor(rgb_image, cv2.COLOR_BGR2RGB)
    cv2.imwrite(filename, rgb_image)


def replace_with_dict(val, d):
    if d is None:
         d = {'I': '1', 'J': '1'}
    return val.translate(str.maketrans(d))

pattern = r'[^A-Za-z0-9\-]+'
def extract_number_plate_text(img_name):
    plateResult = {}
    IMAGE_PATH = f'detect/{img_name}'
    # Load the image of the number plate
    image = cv2.imread(IMAGE_PATH)

    reader = easyocr.Reader(["en"])
    results = reader.readtext(image)

    for result in results:
        bounding_box = result[0]
        bounding_box_int = np.array(bounding_box, dtype=int)

        # Draw the bounding box around the text box
        cv2.rectangle(image, bounding_box_int[0], bounding_box_int[2], (0, 255, 0), 2)
        plateResult[bounding_box_int[0][1]] = result[1]

    cv2.imwrite(f'extract/{img_name}', image)
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
    return concatenated_string


# Extract the text from the number plate image
plate = extract_number_plate_text(img_name)
print(plate)
