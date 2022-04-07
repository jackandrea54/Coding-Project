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


    def is_balanced(self, expression_string): 
        open_list = ["{", "(", "["]
        closed_list = ["}", ")", "]"]

        for i in expression_string:
            if i in open_list:
                self.push(i)
            elif i in closed_list:
                pos = closed_list.index(i)
                if not self.is_empty() and self.items[-1] == open_list[pos]:
                    self.pop()
                else:
                    return False

        if self.size() == 0:
            return True
        else:
            return False


stack = Stack()
print(stack.is_balanced("abfdc[]"))