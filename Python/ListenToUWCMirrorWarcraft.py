import socket
import struct

# Define the UDP port to listen on
UDP_PORT = 6999

# Create a UDP socket
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
sock.bind(("0.0.0.0", UDP_PORT))

print(f"Listening for UDP packets on port {UDP_PORT}...")


def handle_received_data(int_integerValue):
    # This function is called when data is received
    print(f"Received integer value: {int_integerValue}")

    int_player_id: int = int_integerValue /100000000 % 100
    int_data_tag : int= int_integerValue /1000000 % 100
    int_data_value : int= int_integerValue %1000000 

    print(f"Player ID: {int_player_id}, Data Tag: {int_data_tag} , Data Value: {int_data_value}")



try:
    while True:
        # Receive data from the socket
        data, addr = sock.recvfrom(1024)  # Buffer size is 1024 bytes
        data_length = len(data)
        
        # Check if the length of the data is 4, 8, or 16 bytes
        if data_length in (4, 8, 16):
            
            
            # print(f"Received {data_length} bytes from {addr}: {data}")
            
            if data_length == 8:
                index, integer= struct.unpack("<ii", data)
                handle_received_data(integer)
            if data_length == 4:
                integer = struct.unpack("<i", data)

                handle_received_data(integer)
            if data_length == 16:
                # dqte is unsigned long
                index, integer, ulong_data = struct.unpack("<iiQ", data)
                handle_received_data(integer)

except KeyboardInterrupt:
    print("\nExiting...")
finally:
    sock.close()