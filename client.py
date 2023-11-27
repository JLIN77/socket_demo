import socket
client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)  # init
client.connect(('192.168.0.14', 1111))                      # set IP and PORT
print('Client startup...')
while True:
        message = input("Send msg：")  
        client.send(message.encode('utf-8'))  
client.close() 
 
