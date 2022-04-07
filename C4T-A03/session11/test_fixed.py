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
        for char in text:
            self.push(char)

        reversed_string = ''

        for _ in text:
            reversed_string += self.pop()

        return reversed_string
    def decimal_to_binary(self, num):
        loop = True
        binary_string = ''
        while loop:
            modulus = num % 2
            self.push(modulus)
            num = num // 2
            if num == 0:
                loop = False
        for _ in range(self.size()):
            binary_string += str(self.pop())

        binary_number = int(binary_string)
        return binary_number
        

stack_training = StackTraining()
print(stack_training.reverse("minh"))
print(stack_training.decimal_to_binary(13))