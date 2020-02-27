def get_data(f, nc):
    a = []
    b = []
    with open(f, 'r') as f_handle:
        for line in f_handle:
            coeffs = line.split()
            a.append(coeffs[:nc])
            b.append(coeffs[nc:])
        return (a, b)

if __name__ == '__main__':
    a, b = get_data('in', 3)
    print(a)
    print(b)
