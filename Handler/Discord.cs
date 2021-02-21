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


        public static void ShutDown()
        {
            client.Deinitialize();
        }

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

        public static void SettingsStart() //this is for restarting the discord RPC on the settings page
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
