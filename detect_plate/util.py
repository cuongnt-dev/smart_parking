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
        d = {'I': '1', 'J': '1', ".": "", "-": "", "|": ""}
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


def current_milli_time():
    return round(time.time() * 1000)
