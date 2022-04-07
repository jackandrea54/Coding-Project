class Stack:
    def __init__(self):
        self.items = []
    

    def __str__(self):
        return str(self.items)

    def push(self, item):
        self.items.append(item)

    def pop(self):
        if not self.is_empty():
            return self.items.pop()
        else:
            return None

    def is_empty(self):
        return self.items ==[]

    def size(self):
        return len(self.items)

    def is_balanced(self, text):
        self.items = list(text)


    def is_balanced(self): 
        open_list = ["[","{","("] 
        close_list = ["]","}",")"] 
        self = []
        for i in self: 
            if i in open_list: 
                stack.append(i) 
            elif i in close_list: 
                pos = close_list.index(i) 
                if ((len(stack) > 0) and (open_list[pos] == stack[len(stack)-1])): 
                    stack.pop() 
                else: 
                    return "Unbalanced"
        if len(stack) == 0: 
            return "Balanced"
        else: 
            return "Unbalanced"
  
string = "{[]{()}}"
print(string,"-", is_balanced(string))
stack = Stack()
print(stack.is_balanced(""))