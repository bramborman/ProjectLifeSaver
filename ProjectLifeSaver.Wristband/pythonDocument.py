#!/usr/bin/env python

import socket


TCP_IP = '10.10.85.230'    #Static IP address of the app
TCP_PORT = 15258           #Port that it communicates on
BUFFER_SIZE = 1024
MESSAGE = "Hello, World!" 

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((TCP_IP, TCP_PORT))  #seting the connection
s.send(MESSAGE)    #actual sending the message
data = s.recv(BUFFER_SIZE)      
s.close()     #end of the connection

print ("received data:", data)  #just some debug
