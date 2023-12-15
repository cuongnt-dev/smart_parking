import time
import re


def normalize_image(image):
    image = image.astype("float32")
    image -= image.min()
    image /= image.max()
    image *= 255
    return image.astype("uint8")


def replace_with_dict(val, d):
    if d is None:
        d = {'I': '1', 'J': '1', ".": "", "-": "", "|": "", "i": '1', 'l': '1', 'L': '1', 'j': '1', 'T': 1}
    return val.translate(str.maketrans(d))


def remove_special_characters(text):
    """
  This function removes all special characters except a-z and 0-9 from a string.

  Args:
    text: The string to remove special characters from.

  Returns:
    The string with all special characters removed.
  """
    pattern = r"[^\w\d]+"
    return re.sub(pattern, "", text)

def filter_accept_number(text):
    """
  This function removes all special characters except a-z and 0-9 from a string.

  Args:
    text: The string to remove special characters from.

  Returns:
    The string with all special characters removed.
  """
    pattern = r"[^\d]+"
    return re.sub(pattern, "", text)


def detect_dot(input_string):
    parts = input_string.split('.')
    if len(parts) > 1:
        # Extract the first two characters from the decimal part
        decimal_result = parts[1][:2]

        # Concatenate the integer part and the extracted decimal result
        final_result = parts[0] + str(decimal_result)
        return final_result
    else:
        return input_string

def current_milli_time():
    return round(time.time() * 1000)


import hashlib


def hash_string(text):
    if not text:
        return ""

    # Use SHA256 to create the hash
    sha = hashlib.sha256()

    # Convert the string to a byte array first, to be processed
    text_bytes = text.encode('utf-8')
    sha.update(text_bytes)

    # Convert the hash to a hexadecimal representation
    hash_result = sha.hexdigest().upper()

    return hash_result

from datetime import datetime
def get_current_day():
    current_day = datetime.today()
    formatted_date = current_day.strftime("%m%d%Y")
    return formatted_date