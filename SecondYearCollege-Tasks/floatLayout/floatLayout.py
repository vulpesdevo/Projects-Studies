import kivy 
from kivy.app import App
from kivy.properties import ObjectProperty
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.core.window import Window
## from kivy.uix.image import Image
##from kivy.uix.floatlayout import FloatLayout


##----------------------------------kivy BUILDER --------------------------------##
Builder.load_file('myLayOut.kv')
##----------------------------------kivy BUILDER --------------------------------##

class myFloat(Widget):
    pass

class Myfloat(App):
    def build(self):
##---------------------1st way to change background color -----------------##
##----------------------2nd is on bg1.kv file -----------------------------##

                        ## RGB color
        Window.clearcolor = (86/255,113/255,137/255,1) 

##---------------------1st way to change background color -----------------##
        return myFloat()
## main
if __name__ == '__main__':
    Myfloat().run()