local class = require("Class")
local helloworld = class ("Helloworld",{})

function helloworld.ctor()
	
	print("helloworld")
end

function helloworld.Start()
	print("helloworld start")
end

function helloworld.Update()
end

return helloworld
