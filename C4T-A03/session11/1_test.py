class Stack:
    def __init__(self):
        self.items1 = []
        self.items2 = []

    def __str__(self):
        return str(self.items2)

    def push(self, item):
        self.items2.append(item)

    def pop(self):
        if not self.is_empty():
            return self.items1.pop()
        else:
            return None

    def is_empty(self):
        return self.items1 ==[]

    def size(self):
        return len(self.items2)


new_stack = Stack()
# print(new_stack)

# new_stack.push(1)
# print(new_stack)
# new_stack.push(2)
# print(new_stack)
# new_stack.pop()
# print(new_stack)


class StackTraining(Stack):
    def reverse(self, text):
        self.items1 = list(text)
        for i in range(len(self.items1)):
            self.push(self.pop())

        return(''.join(self.items2))

    def decimal_to_binary(self, num):
        for _ in range(num):
            if num != 0:
                self.push(num%2)
                num = num//2
            else: 
                break

        return  "".join(str(x) for x in self.items2)
        



stack_training = StackTraining()
# print(stack_training.reverse("minh"))
print(stack_training.decimal_to_binary(13))