import kivy 
from kivy.app import App
from kivy.properties import ObjectProperty
from kivy.uix.widget import Widget
from kivy.lang import Builder

##----------------------------------kivy BUILDER --------------------------------##
Builder.load_file('BOX.kv')
##----------------------------------kivy BUILDER --------------------------------##

class myLayout(Widget) :
    pass

class myBox(App):
    def build(self):
        return myLayout()
## main
if __name__ == '__main__':
    myBox().run()