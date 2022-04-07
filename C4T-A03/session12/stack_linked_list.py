class Node:
    def __init__(self, cargo = None, previous = None):
        self.cargo = cargo
        self.previous = previous

    def __str__(self):
        return "{}".format(self.cargo)

class NodeStack:
    def __init__(self):
        self.length = 0
        self.last = None
    
    def is_empty(self):
        return self.length == 0

    def insert(self, cargo):
        if self.last is None:
            node = Node(cargo = cargo)
        else:
            node = Node(cargo= cargo, previous= self.last)
        
        self.length +=1
        self.last = node

    def remove(self):
        if not self.is_empty():
            cargo = self.last.cargo
            self.last = self.last.previous
            self.length -= 1
        else:
            return None

node_stack = NodeStack()
node_stack.insert("cargo_1")
print(node_stack.last)
node_stack.insert("cargo_2")
node_stack.insert("cargo_3")
print(node_stack.last)
node_stack.remove()
print(node_stack.last)