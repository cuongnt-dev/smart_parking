import time
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

def current_milli_time():
    return round(time.time() * 1000)