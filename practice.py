# print("hi")
# print("deni")
# print("git stash")

from string import ascii_uppercase

def fibonacci(num):
    if num <= 1:
        return num
    else:
        return fibonacci(num-1)+fibonacci(num-2)

def pattern():
    alphabets = "ADEFIJKLMOPQY"
    alphas = convert_str_to_list(alphabets)
    counts = [1,3,5,3,1]
    index = 0
    for count in counts:
        space = ' ' * ((5-count)// 2)
        rows = []
        for i in range(count):
            rows.append(alphas[index])
            index += 1
        print(space + ' '.join(rows))
            
    
def convert_str_to_list(text):
    alphas = []
    for i in text:
        alphas.append(i)
    return alphas

def practice():
    letters = iter(ascii_uppercase)
    print(next(letters))

pattern()