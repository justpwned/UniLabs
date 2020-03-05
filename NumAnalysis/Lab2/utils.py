def get_data(f):
    a = []
    b = []
    with open(f, 'r') as f_handle:
        for line in f_handle:
            coeffs = line.split()
            nc = len(coeffs) - 1
            a.append([float(i) for i in coeffs[:nc]])
            b.append([float(i) for i in coeffs[nc:]])
        return (a, b)

if __name__ == '__main__':
    a, b = get_data('in_matrix')
    print(a)
    print(b)
