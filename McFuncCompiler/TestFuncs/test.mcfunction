# Test
setblock ~ ~ ~ air
say Hello world

define ping aaaaaaaaaaaa

define standard_sword iron_sword`sword.json`

scoreboard players set @s points 0 
scoreboard objectives add points dummy "Total Points"

$var = 50
$var += 10
$var -= 5

define somevalue 3333

$var = #somevalue
#$error = string
$var = null

points$mitchfizz05 = 69

give @s #standard_sword 1

execute as @a run tellraw @s `hello`

say #ping