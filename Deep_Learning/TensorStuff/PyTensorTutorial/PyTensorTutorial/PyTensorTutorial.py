import tensorflow as tf

'''
https://www.youtube.com/watch?v=BhpvH5DuVu8&list=PLQVvvaa0QuDfKTOs3Keq_kaG2P55YRn5v&index=46
Input > weight > hidden layer 1 > run through activation function >  send it, with weights, to hidden layer 2 > 

compare output to intended output > cost function (cross entropy - how close to our intended target, or not close)
optimization function (optimizer) > minimize cost (AdamOptimizer, Socastic Gradient descent , AdaGrad)

Backwards and manipulates the weight the weights = backpropagation
from tensorflow.examples.tutorials.mnist import input_data
feed forward + backprop = epoch
'''

print('pt 1')
#from tensorflow.examples.tutorials.mnist import input_data
import input_data
mnist = input_data.read_data_sets("E:/MNIST_data/", one_hot=True)
print('pt 1a')
#mnist = input_data.read_data_sets("E:\tmp\data\\", one_hot=True)
#mnist = input_data.read_data_sets("/tmp/data/", one_hot=True)
print('pt 1b')
#10 classes, 0 - 9
'''
0 = [1,0,0,0,0,0,0,0,0,0]
1 = [0,1,0,0,0,0,0,0,0,0]
2 = [0,0,1,0,0,0,0,0,0,0]
3 = [0,0,0,1,0,0,0,0,0,0]
'''

n_nodeshl1 = 500 #hidden layer 1
n_nodeshl2 = 500 #hidden layer 2
n_nodeshl3 = 500 #hidden layer 3
n_classes = 10
batch_size = 100 #go through batches of 100 at a time
print('pt 2')
# height x width
x = tf.placeholder('float', [None, 784]) #input data
y = tf.placeholder('float') #label 
print('pt 3')
def neural_network_model(data):
    hidden_1_layer = {'weights':tf.Variable(tf.random_normal([784, n_nodeshl1])), 
                      'biases':tf.Variable(tf.random_normal(n_nodeshl1))}
    
    hidden_2_layer = {'weights':tf.Variable(tf.random_normal([n_nodeshl1, n_nodeshl2])), 
                      'biases':tf.Variable(tf.random_normal(n_nodeshl2))}

    hidden_3_layer = {'weights':tf.Variable(tf.random_normal([n_nodeshl2, n_nodeshl3])), 
                      'biases':tf.Variable(tf.random_normal(n_nodeshl3))}

    output_layer = {'weights':tf.Variable(tf.random_normal([n_nodeshl3, n_classes])), 
                      'biases':tf.Variable(tf.random_normal(n_classes))}
    #input data * weights + biases
    l1 = tf.add(tf.matmul(data,  hidden_1_layer['weights']) + hidden_1_layer['biases'])
    l1 = tf.nn.relu(l1)

    l2 = tf.add(tf.matmul(l1,  hidden_2_layer['weights']) + hidden_2_layer['biases'])
    l2 = tf.nn.relu(l2)

    l3 = tf.add(tf.matmul(l2,  hidden_3_layer['weights']) + hidden_3_layer['biases'])
    l3 = tf.nn.relu(l3)
    
    output = tf.add(tf.matmul(l3,  output_layer['weights']) + output_layer['biases'])

    return output
print('pt 4')
#train the network
def train_neural_network(x):
    prediction = neural_network_model(x)
    cost = tf.reduce_mean( tf.nn.softmax_cross_entropy_with_logits(prediction, y)) #cost function, going to calculate the difference of the prediction to the label
    #default learning rate: 0.001
    optimizer = tf.train.AdadeltaOptimizer().minimize(cost)
    #Epochs: cycle of feed forward + backprop
    hm_epochs = 10

    with tf.Session() as sess:
        sess.run(tf.initialize_all_variables)

        for epoch in hm_epochs:
            epoch_loss = 0
            for _ in range(int(mnist.train.num_examples / batch_size)):
                x, y = mnist.train.next_batch(batch_size)
                _, c = sess.run([optimizer, cost], feed_dict = { x: x, y: y})
                epoch_loss += c
            print('Epoch: ', epoch, ' completed out of ', hm_epochs, 'loss: ', epoch_loss)

        correct = tf.equal(tf.argmax(prediction, 1), tf.argmax(y ,1))

        accuracy = tf.reduce_mean(tf.cast(correct, 'float'))
        print('Accuracy: ', accuracy.eval({x:mnist.test.images, y:mnist.test.labels}))
print('pt 5 - starting training')
train_neural_network(x)