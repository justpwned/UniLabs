#!/usr/bin/env python3

import sys
import os
import utils

def gaussian_method(a, b):
    for i in range(len(a)):
        row = a[i]
        
        found_nz = False
        for j in range(i, len(row)):
            if not found_nz and row[j] != 0:
                first_nz = row[j]
                found_nz = True
            if found_nz:
                row[j] /= first_nz
        b[i][0] /= first_nz

        for j in range(i + 1, len(a)):
            for k in range(j, len(a[j])):
                a[j][k] -= a[i][k] * a[j][0]

        print(a)
        print(b)
        print()
        

if __name__ == '__main__':
    if len(sys.argv) != 2:
        print('Usage: ./gaussian_elim matrix_file')
        exit(1)
    
    if not os.path.isfile(sys.argv[1]):
        print(f'{sys.argv[1]} should be file!')
        exit(1)

    a, b = utils.get_data('in_matrix')
    gaussian_method(a, b)
    #x = gaussian_method(a, b)
    #print(f'the answer is {x}') 
