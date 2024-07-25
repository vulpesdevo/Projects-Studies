import kivy 
from kivy.app import App
from kivy.properties import ObjectProperty
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.core.window import Window

##----------------------------------kivy BUILDER --------------------------------##
Builder.load_file('bg1.kv')
##----------------------------------kivy BUILDER --------------------------------##

class myColor(Widget) :
    def cl(self):
        self.ids.input.text=""
class myBGcolor(App):
    def build(self):
##---------------------1st way to change background color -----------------##
##----------------------2nd is on bg1.kvfile -----------------------------##

                        ## RGB color
        Window.clearcolor = (86/255,113/255,137/255,1) 

##---------------------1st way to change background color -----------------##
        return myColor()
## main
if __name__ == '__main__':
    myBGcolor().run()