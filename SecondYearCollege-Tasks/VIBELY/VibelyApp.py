import datetime
import os, sys
import sqlite3
from kivy.config import Config
from kivy.lang import Builder
from kivymd.app import MDApp, App
from kivy.uix.floatlayout import FloatLayout
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.button import Button
from kivy.uix.label import Label
from kivy.uix.popup import Popup
from kivy.resources import resource_add_path
from kivymd.uix.menu import MDDropdownMenu

from kivymd.uix.tab import MDTabsBase

Builder.load_file("VibelyAppDes.kv")
# Define our different
class Tab(FloatLayout, MDTabsBase):
    """Class implementing content for a tab."""


class vibelyApp(FloatLayout):
    def on_tab_switch(self, instance_tabs, instance_tab, instance_tab_label, tab_text):
        self.ids.label.text = tab_text

    def dropdown(self, button):
        menu_items = [
            {
                "text": "Personal information",
                "viewclass": "OneLineListItem",
                "on_release": self.personInfo,
            },
            {
                "text": "Change Password",
                "viewclass": "OneLineListItem",
                "on_release": self.changepass,
            },
            {
                "text": "Logout",
                "viewclass": "OneLineListItem",
                "on_release": self.logout,
            },
        ]
        self.menu = MDDropdownMenu(
            items=menu_items,
            width_mult=3,
        )
        self.menu.caller = button
        self.menu.open()

    # action__________-------------------------
    def personInfo(self, *args):
        # Functionality for item 1
        print("Item 1 clicked")

    def changepass(self, *args):
        # Functionality for item 2
        print("Item 2 clicked")

    def logout(self, *args):
        # Functionality for item 3
        self.menu.dismiss()
        self.ids.screen_managerA.current = "loginScreen"
        self.ids.screen_managerA.transition.direction = "right"

        print("Item 3 clicked")

    # action__________-------------------------

    def LDtheme(self, app):
        print(app.theme_cls.theme_style)
        if app.theme_cls.theme_style == "Light":
            self.Dark(app)
        else:
            self.Light(app)

    # Light Theme
    def Light(self, app):
        app.theme_cls.theme_style = "Light"
        app.theme_cls.primary_palette = "Indigo"

    # Dark Theme
    def Dark(self, app):
        app.theme_cls.theme_style = "Dark"
        app.theme_cls.primary_palette = "DeepPurple"

    def function_name(self, screenName, direction):
        self.ids.screen_managerA.current = screenName
        self.ids.screen_managerA.transition.direction = direction

    def signin(self):
        us = self.ids.username.text
        p = self.ids.passw.text
        dbconn = sqlite3.connect(
            "kivysql.db", detect_types=sqlite3.PARSE_DECLTYPES | sqlite3.PARSE_COLNAMES
        )
        c = dbconn.cursor()
        c.execute(
            "SELECT * FROM mstuser WHERE mstuser.username = :var_username and mstuser.password = :var_password",
            {"var_username": us, "var_password": p},
        )
        if record := c.fetchall():
            self.ids.screen_managerA.current = "dashScreen"
            self.ids.screen_managerA.transition.direction = "left"
            self.ids.username.text = ""
            self.ids.passw.text = ""
            print("Record Exist")
        else:
            print("No record")
            pop = "Incorrect Input"
            self.messageLog(pop)

    def signup(self):
        check = [
            self.ids.regisUser.text,
            self.ids.regisFN.text,
            self.ids.regisLN.text,
            self.ids.regisEmail.text,
            self.ids.regisPass.text,
        ]
        print(check)
        global pop
        pop = "Incomplete Requirements" if "" in check else "Registered Successfully"
        print(pop)
        if pop == "Registered Successfully":
            self.insertData()
        self.message(pop)

    def insertData(self):
        usern = self.ids.regisUser.text
        fn = self.ids.regisFN.text
        ln = self.ids.regisLN.text
        email = self.ids.regisEmail.text
        password = self.ids.regisPass.text
        dbconn = sqlite3.connect(
            "kivysql.db", detect_types=sqlite3.PARSE_DECLTYPES | sqlite3.PARSE_COLNAMES
        )
        c = dbconn.cursor()
        c.execute(
            "INSERT INTO mstuser(username, first_name, last_name, email, password, created_at, updated_at)VALUES(:var_username, :var_firstname, :var_lastname, :var_email, :var_password, :var_created_at, :var_updated_at)",
            {
                "var_username": usern,
                "var_firstname": fn,
                "var_lastname": ln,
                "var_email": email,
                "var_password": password,
                "var_created_at": datetime.datetime.now(),
                "var_updated_at": datetime.datetime.now(),
            },
        )
        dbconn.commit()
        dbconn.close()

    def messageLog(self, popM):
        messagePOP = self.message2(popM)
        messagePOP.open()

    def message(self, popM):
        messagePOP = self.message2(popM)
        if popM == "Registered Successfully":
            self.ids.screen_managerA.current = "loginScreen"
            self.ids.screen_managerA.transition.direction = "right"
        messagePOP.open()

    # TODO Rename this here and in `messageLog` and `message`
    def message2(self, popM):
        box = BoxLayout()
        box.orientation = "vertical"
        box.add_widget(Label(text=popM))
        button = Button(
            text="OK",
            background_color=(201 / 255, 44 / 255, 109 / 255, 0.5),
            background_normal="",
        )
        box.add_widget(button)
        result = Popup(
            title="",
            content=box,
            size_hint=(0.5, 0.25),
            auto_dismiss=False,
            background_color=(31 / 255, 138 / 255, 112 / 255, 0.8),
        )
        button.bind(on_release=result.dismiss)
        return result


# Designate Our .kv design file


class screenManagerApp(MDApp):
    def build(self):
        self.theme_cls.material_style = "M3"
        self.theme_cls.theme_style = "Dark"
        self.theme_cls.primary_palette = "Blue"
        self.theme_cls.accent_palette = "Teal"
        return vibelyApp()


if __name__ == "__main__":
    if hasattr(sys, "_MEIPASS"):
        resource_add_path(os.path.join(sys._MEIPASS))
    screenManagerApp().run()
