-- Gui to Lua
-- Version: 3.2

-- Instances:

local ScreenGui = Instance.new("ScreenGui")
local OpenFrame = Instance.new("Frame")
local Open = Instance.new("TextButton")
local Main = Instance.new("Frame")
local PhanthomSmasher = Instance.new("TextLabel")
local ESP = Instance.new("TextButton")
local GUNMOD = Instance.new("TextButton")
local Close = Instance.new("TextButton")
local blahblahblah = Instance.new("TextLabel")

--Properties:

ScreenGui.Parent = game.CoreGui
ScreenGui.ZIndexBehavior = Enum.ZIndexBehavior.Sibling

OpenFrame.Name = "OpenFrame"
OpenFrame.Parent = ScreenGui
OpenFrame.BackgroundColor3 = Color3.fromRGB(32, 140, 255)
OpenFrame.Position = UDim2.new(0, 0, 0.548571408, 0)
OpenFrame.Size = UDim2.new(0, 130, 0, 45)
OpenFrame.Visible = false

Open.Name = "Open"
Open.Parent = OpenFrame
Open.BackgroundColor3 = Color3.fromRGB(32, 140, 255)
Open.BorderSizePixel = 0
Open.Position = UDim2.new(0.0607822575, 0, 0.117088318, 0)
Open.Size = UDim2.new(0, 113, 0, 34)
Open.Font = Enum.Font.SourceSans
Open.Text = "Open"
Open.TextColor3 = Color3.fromRGB(255, 255, 255)
Open.TextSize = 30.000
Open.MouseButton1Down:connect(function()
Main.Visible = true
OpenFrame.Visible = false
end)

Main.Name = "Main"
Main.Parent = ScreenGui
Main.BackgroundColor3 = Color3.fromRGB(32, 140, 255)
Main.BorderColor3 = Color3.fromRGB(32, 140, 255)
Main.Position = UDim2.new(0.20733653, 0, 0.225714296, 0)
Main.Size = UDim2.new(0, 390, 0, 164)
Main.Visible = false
Main.Draggable = true

PhanthomSmasher.Name = "Phanthom Smasher"
PhanthomSmasher.Parent = Main
PhanthomSmasher.BackgroundColor3 = Color3.fromRGB(32, 140, 255)
PhanthomSmasher.BorderSizePixel = 0
PhanthomSmasher.Position = UDim2.new(0.223076925, 0, 0, 0)
PhanthomSmasher.Size = UDim2.new(0, 215, 0, 32)
PhanthomSmasher.Font = Enum.Font.SourceSans
PhanthomSmasher.Text = "Phanthom Smasher"
PhanthomSmasher.TextColor3 = Color3.fromRGB(255, 255, 255)
PhanthomSmasher.TextSize = 30.000
PhanthomSmasher.TextStrokeColor3 = Color3.fromRGB(255, 255, 255)
PhanthomSmasher.TextStrokeTransparency = 0.800

ESP.Name = "ESP"
ESP.Parent = Main
ESP.BackgroundColor3 = Color3.fromRGB(20, 255, 35)
ESP.Position = UDim2.new(0.0769230798, 0, 0.378048778, 0)
ESP.Size = UDim2.new(0, 140, 0, 40)
ESP.Font = Enum.Font.SourceSans
ESP.Text = "ESP"
ESP.TextColor3 = Color3.fromRGB(0, 0, 0)
ESP.TextSize = 30.000
ESP.MouseButton1Down:connect(function()
--[[

Written by Issa Knife on V3rmillion. (https://v3rmillion.net/member.php?action=profile&uid=58375)

Modified for phantom forces update by Spoorloos#7871

]]

local espRainbow = false
local espToggle = true


local library = loadstring(game:HttpGet("https://pastebin.com/raw/CkyR8ePz",true))()
local espwindow = library:CreateWindow("ESP")

espwindow:Section('Edited By Spoorloos')

espwindow:Bind("Toggled", {
   flag = "espToggle";
   kbonly = true;
   default = Enum.KeyCode.N;
}, function()
   if espToggle == true then espToggle = false elseif espToggle == false then espToggle = true end
end)

espwindow:Section('Settings:')

espwindow:Bind("Rainbow", {
   flag = "espRainbow";
   kbonly = true;
   default = Enum.KeyCode.M;
}, function()
   if espRainbow == true then espRainbow = false elseif espRainbow == false then espRainbow = true end
end)

local player = game.Players.LocalPlayer
local players = {} 
local core = game:GetService("CoreGui")

function zigzag(X) return math.acos(math.cos(X*math.pi))/math.pi end

local counter = 0

function CreateBillboard(adornee)
local billboard = Instance.new("BillboardGui")
billboard.Name = "E"
local frame = Instance.new("Frame")
billboard.AlwaysOnTop = true
billboard.Size = UDim2.new(4, 0, 5.5, 0)
billboard.StudsOffset = Vector3.new(0, 0, 0)
billboard.Adornee = adornee
if espRainbow then
	frame.BackgroundColor3 = Color3.fromHSV(zigzag(counter),1,1)
else 
	frame.BackgroundColor = BrickColor.new("Maroon")
end
frame.BackgroundTransparency = .35
frame.BorderSizePixel = 0
frame.Size = UDim2.new(1, 0, 1, 0)
billboard.Parent = core
frame.Parent = billboard
counter = counter + 0.0005
billboard.Parent = core
end

function GetEnemyPlayers()
players = {}
if #game:GetService("Teams"):GetTeams() > 0 then
local friendly = player.Team.Name
for i,v in pairs(game:GetService("Teams"):GetTeams()) do
if v.Name ~= friendly and v.Name ~= (game.Teams:FindFirstChild("Spectators") and game.Teams.Spectators.Name) then
local enemyPlayers = v:GetPlayers()
for i,v in pairs(enemyPlayers) do
table.insert(players, v)
end
end
end
return players
end
end

function InsertBillboardToPlayers()
for i,v in pairs(game:GetService("CoreGui"):GetChildren()) do if v.Name == "E" then v:Destroy() end end
local otherTeamR
if game.Players.LocalPlayer.Team ~= nil then
	if game.Players.LocalPlayer.Team.Name == "Ghosts" then
		otherTeamR = "Phantoms"
	elseif game.Players.LocalPlayer.Team.Name == "Phantoms" then
		otherTeamR = "Ghosts"
	end
end

local players = game.Workspace:FindFirstChild("Players")
local otherteam = players:FindFirstChild(otherTeamR)
for i,v in pairs(otherteam:GetChildren()) do
CreateBillboard(v.Torso)
end
end

if espToggle then
InsertBillboardToPlayers()
end

game.Players.PlayerAdded:Connect(function(plr)
plr.CharacterAdded:Wait()
players = GetEnemyPlayers()
if espToggle then
InsertBillboardToPlayers()
else
for i,v in pairs(game:GetService("CoreGui"):GetChildren()) do if v.Name == "E" then v:Destroy() end end
end
end)

game.Players.PlayerRemoving:Connect(function(plr)
plr.CharacterRemoving:Wait()
players = GetEnemyPlayers()
if espToggle then
InsertBillboardToPlayers()
else
for i,v in pairs(game:GetService("CoreGui"):GetChildren()) do if v.Name == "E" then v:Destroy() end end
end
end)

game:GetService('RunService').Stepped:Connect(function()
if espToggle then
InsertBillboardToPlayers()
else
for i,v in pairs(game:GetService("CoreGui"):GetChildren()) do if v.Name == "E" then v:Destroy() end end
end
end)
end)

GUNMOD.Name = "GUN MOD"
GUNMOD.Parent = Main
GUNMOD.BackgroundColor3 = Color3.fromRGB(20, 255, 35)
GUNMOD.Position = UDim2.new(0.56410259, 0, 0.378048778, 0)
GUNMOD.Size = UDim2.new(0, 140, 0, 40)
GUNMOD.Font = Enum.Font.SourceSans
GUNMOD.Text = "GUN MOD"
GUNMOD.TextColor3 = Color3.fromRGB(0, 0, 0)
GUNMOD.TextSize = 30.000
GUNMOD.MouseButton1Down:connect(function()
loadstring(game:HttpGet("https://pastebin.com/raw/rPbJcqbK", true))()
end)

Close.Name = "Close"
Close.Parent = Main
Close.BackgroundColor3 = Color3.fromRGB(208, 0, 0)
Close.Position = UDim2.new(0.941025674, 0, -1.67638063e-08, 0)
Close.Size = UDim2.new(0, 23, 0, 26)
Close.Font = Enum.Font.SourceSans
Close.Text = "X"
Close.TextColor3 = Color3.fromRGB(255, 255, 255)
Close.TextSize = 30.000
Close.TextStrokeColor3 = Color3.fromRGB(255, 255, 255)
Close.MouseButton1Down:connect(function()
OpenFrame.Visible = true
Main.Visible = false
end)

blahblahblah.Name = "blah blah blah"
blahblahblah.Parent = Main
blahblahblah.BackgroundColor3 = Color3.fromRGB(32, 140, 255)
blahblahblah.BorderColor3 = Color3.fromRGB(32, 140, 255)
blahblahblah.Position = UDim2.new(0, 0, 0.835365832, 0)
blahblahblah.Size = UDim2.new(0, 390, 0, 27)
blahblahblah.Font = Enum.Font.SourceSans
blahblahblah.Text = "Scripts aren't mine GUI made by Hitlersmellz On Instagram"
blahblahblah.TextColor3 = Color3.fromRGB(255, 255, 255)
blahblahblah.TextScaled = true
blahblahblah.TextSize = 15.000
blahblahblah.TextStrokeColor3 = Color3.fromRGB(255, 255, 255)
blahblahblah.TextStrokeTransparency = 0.800
blahblahblah.TextWrapped = true