#!/usr/bin/env python3

import importlib
utils = importlib.import_module('utils.py')

print('Hello, this is a test Python program!')
print('It will echo back everything you type:')

while (1):
    text = input()
    print(text)

print('Exiting program')
