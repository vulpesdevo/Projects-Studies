import kivy
from kivy.app import App
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.core.window import Window
from kivy.uix.popup import Popup
from kivy.uix.button import Button
from kivy.uix.boxlayout import BoxLayout

from kivy.uix.label import Label

Builder.load_file("loginDESIGN.kv")

Window.size = (600, 800)


class Login(Widget):
    def clear(self, clr):
        username = self.ids.un
        password = self.ids.pword
        username.text = ""
        password.text = ""

    def signin_button(self):
        global username, password
        username = self.ids.un
        password = self.ids.pword
        if username.text == "sdca.itpe02" and password.text == "@itpe02":
            pop = "Login Successfully"
        else:
            pop = "Username and Password did not match"

        self.message(pop)

    # TODO Rename this here and in `signin_button`
    def message(self, popM):
        box = BoxLayout()
        box.orientation = "vertical"
        box.add_widget(Label(text=popM))
        button = Button(
            text="Exit",
            background_color=(201 / 255, 44 / 255, 109 / 255, 0.5),
            background_normal="",
        )
        box.add_widget(button)

        messagePOP = Popup(
            title="",
            content=box,
            size_hint=(0.5, 0.25),
            auto_dismiss=False,
            background_color=(31 / 255, 138 / 255, 112 / 255, 0.8),
        )

        button.bind(on_release=messagePOP.dismiss)
        if popM == "Username and Password did not match":
            button.bind(on_release=self.clear)
        messagePOP.open()

    # button.bind(on_release=self.clear)


class main(App):
    title = "Login"

    def build(self):
        return Login()


if __name__ == "__main__":
    main().run()
