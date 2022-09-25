# -*- coding:utf-8 -*-
import socket

host = "192.168.50.52" #お使いのサーバーのホスト名を入れます
port = 139 #適当なPORTを指定してあげます

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM) #オブジェクトの作成をします

client.connect((host, port)) #これでサーバーに接続します

massage = "from nadechin"

client.send(massage.encode('utf-8')) #適当なデータを送信します（届く側にわかるように）

response = client.recv(4096) #レシーブは適当な2の累乗にします（大きすぎるとダメ）

print(response)