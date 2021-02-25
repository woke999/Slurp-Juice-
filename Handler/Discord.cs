using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using static Slurp_Juice_.Handler.UI;
using static Slurp_Juice_.Forms.Controls.Injector;

namespace Slurp_Juice_.Handler
{
    public static class Discord
    {
        public static DiscordRpcClient client;

        public static void DiscordID()
        {
            client = new DiscordRpcClient("811723701955461130");
            client.Initialize();
        }

        public static void DiscordStart()
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                State = $"Viewing homepage", //you start on the homepage, no need for a if statement :pog:
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }

        public static void HomePage()  //same thing as above, but just doesn't check if discord is initilized since it already will be
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                State = $"Viewing homepage",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }
        
		//basically this checks the bools in the ui handler and updates based off which is true
        //this is really bad
        //i wanna kms 
        //too many fucking if statements
        //could probably do a case statement but im lazy lol
        public static void Update()
        {
            if (HomeControl == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                    State = $"Viewing homepage",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }
            if (InjectorControl == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                    State = $"Viewing injector",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }
            if (SettingsControl == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                    State = $"Viewing settings",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }
            if (ThemeControl == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Main.Version} | Attached: {attached}",
                    State = $"Viewing themes",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }
        }

        public static void OpenState()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Opening file",
                State = $"Slurrpin on da juice",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }

		//you need to deinitilize the discord client when the program exits otherwise it may not shutdown properly 
        public static void ShutDown()
        {
            client.Deinitialize();
        }


		//just a personal status for me 
		//you can make a button in the settings control and have it set to this
        public static void DevStatus()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Dev Status",
                State = $"Woke hates being sober",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }

        public static void Settings()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Settings",
                State = $"Viewing settings",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }

		//this is for restarting the discord RPC on the settings page
		//i currently dont have a button for that but you can update it to add one
		//for that just had a button to stop discord presence and one for restarting it
        public static void SettingsStart()
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Settings",
                State = $"Viewing settings",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }


		//i plan on adding a dev settings control eventually :)
        public static void DevSettings()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Slurp Juice {Main.Version} | Dev Settings",
                State = $"Viewing dev settings",
                Assets = new Assets()
                {
                    LargeImageKey = "slurpjuice",
                    LargeImageText = "Slurp Juice open source",
                }
            });
        }
    }
}
