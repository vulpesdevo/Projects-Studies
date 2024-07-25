import kivy
import math
from kivy.app import App
from kivy.properties import ObjectProperty
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.core.window import Window
from kivy.graphics import Rectangle, Color
from kivy.uix.button import ButtonBehavior

## from kivy.uix.image import Image
##from kivy.uix.floatlayout import FloatLayout

# ---app size
Window.size = (400, 600)
# ---app size5

##----------------------------------kivy BUILDER --------------------------------##
Builder.load_file("calculator_design.kv")
##----------------------------------kivy BUILDER --------------------------------##


class calculator(Widget):
    ##-------------------method --------------------------------
    ## GLOBAL VARIABLES --------------------------------
    global myList
    myList = []
    ## GLOBAL VARIABLES --------------------------------

    def clear(self):
        self.ids.input.text = "0"

    def nums(self, numbers):
        element = self.ids.input.text
        if element in ["0", "Syntax error"]:
            self.ids.input.text = ""
            self.ids.input.text = f"{numbers}"
        else:
            self.ids.input.text = f"{element}{numbers}"

    def symbols(self, sign):  # sourcery skip: extract-duplicate-method
        ##global num1  # GLOBAL VARIABLES
        element = self.ids.input.text
        if element != "Syntax Error":
            myList.append((self.ids.input.text))
            myList.append(sign)
        self.ids.input.text = ""

    """def add(self):
        myList.append(float(self.ids.input.text))
        myList.append("+")
        self.ids.input.text = ""

    def sub(self):  # sourcery skip: class-extract-method
        global num1  # GLOBAL VARIABLES
        num1 = 0
        myList.append("-")
        num1 += float(self.ids.input.text)
        self.ids.input.text = ""

    def multi(self):
        global num1, oper  # GLOBAL VARIABLES
        num1 = 0
        myList.append("x")
        num1 += float(self.ids.input.text)
        self.ids.input.text = ""

    def div(self):
        global num1  # GLOBAL VARIABLES
        num1 = 0
        myList.append("/")
        num1 += float(self.ids.input.text)
        self.ids.input.text = ""
        """

    def equal(self):
        myList.append(int(self.ids.input.text))
        joined_Num = "".join(map(str, myList))

        print(joined_Num)
        try:
            res = eval(joined_Num)
            self.ids.input.text = f"{str(res)}"
            # DELETE the previous element from the list
            del myList[:]
        except Exception:
            del myList[:]
            self.ids.input.text = "Syntax Error"

        # ------------------------------------------------------
        ##other way---------------------------using List
        """ if "+" in myList:
            ans = num1 + num2
            self.ids.input.text = f"{ans}"
            myList.remove("+")
        ##other way----------------------------using List
        if "-" in myList:
            ans = num1 - num2
            self.ids.input.text = f"{ans}"
            myList.remove("-")

        if "x" in myList:
            ans = num1 * num2
            self.ids.input.text = f"{ans}"
            myList.remove("x")

        if "/" in myList:
            ans = num1 / num2
            self.ids.input.text = f"{ans}"
            myList.remove("/")"""


##-------------------method --------------------------------


class my_Calculator(App):
    title = "Calculator"

    def build(self):
        ##---------------------1st way to change background color -----------------##
        ##----------------------2nd is on bg1.kv file -----------------------------##

        ## RGB color
        Window.clearcolor = (24 / 255, 29 / 255, 49 / 255, 1)

        ##---------------------1st way to change background color -----------------##
        return calculator()


## main
if __name__ == "__main__":
    my_Calculator().run()
