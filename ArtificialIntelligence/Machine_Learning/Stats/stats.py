import numpy as np
import matplotlib.pyplot as plt

incomes = np.random.normal(27000, 15000, 10000)
def Mean():
    return np.mean(incomes)

def Visualize():
    plt.hist(incomes,50)
    plt.show()

Mean()
Visualize() #displays graphical window popup
