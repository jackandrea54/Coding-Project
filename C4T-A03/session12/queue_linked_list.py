class Node:
    def __init__(self, cargo = None, next = None):
        self.cargo = cargo
        self.next = next

    def __str__(self):
        return "{}".format(self.cargo)

class NodeQueue:
    def __init__(self, capacity):
        self.length = 0
        self.head = None
        self.capacity = capacity
    def is_empty(self):
        return self.length == 0

    def is_full(self):
        return self.length == self.capacity
    
    def enqueue(self, cargo):
        node = Node(cargo = cargo)
        if not self.is_full():
            if self.head is None:
                self.head = node

            else: 
                last = self.head
                while last.next:
                    last = last.next
                last.next = node
            self.length += 1
        else:
            drop_item = node
            return drop_item

    def dequeue(self):
        if not self.is_empty():
            cargo = self.head.cargo
            self.head = self.head.next
            self.length -= 1
            return cargo
        else:
            return None

node_queue = NodeQueue(10)
node_queue.enqueue('cargo_1')
node_queue.enqueue('cargo_2')
node_queue.enqueue('cargo_3')
print(node_queue.head)
print(node_queue.head.next)
node_queue.enqueue('cargo_4')
node_queue.dequeue()
print(node_queue.head)