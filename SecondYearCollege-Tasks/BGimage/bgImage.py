import kivy
from kivy.app import App
from kivy.properties import ObjectProperty
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.core.window import Window
from kivy.uix.image import Image


##----------------------------------kivy BUILDER --------------------------------##
Builder.load_file("image.kv")
##----------------------------------kivy BUILDER --------------------------------##


class myImg(Widget):
    pass


class myImageBG(App):
    def build(self):
        ##---------------------1st way to change background color -----------------##
        ##----------------------2nd is on bg1.kv file -----------------------------##

        ## RGB color

        ##---------------------1st way to change background color -----------------##
        return myImg()


## main
if __name__ == "__main__":
    myImageBG().run()
