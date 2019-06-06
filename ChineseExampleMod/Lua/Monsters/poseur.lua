-- A basic monster script skeleton you can copy and modify for your own creations.
comments = {"闻起来像敌人。", "Poseur 摆着姿势\n就好像他的生活依靠于摆姿势。", "Poseur 的四肢不应该\n以这种方式移动。"}
commands = {"行动 1", "行动 2", "行动 3"}
randomdialogue = {"Random\nDialogue\n1.", "Random\nDialogue\n2.", "Random\nDialogue\n3."}

sprite = "poseur" --Always PNG. Extension is added automatically.
name = "Poseur"
hp = 100
atk = 1
def = 1
check = "这里是检查信息~"
dialogbubble = "right" -- See documentation for what bubbles you have available.
canspare = false
cancheck = true

-- Happens after the slash animation but before 
function HandleAttack(attackstatus)
    if attackstatus == -1 then
        -- player pressed fight but didn't press Z afterwards
    else
        -- player did actually attack
    end
end
 
-- This handles the commands; all-caps versions of the commands list you have above.
function HandleCustomCommand(command)
    if command == "行动 1" then
        currentdialogue = {"Selected\nAct 1."}
    elseif command == "行动 2" then
        currentdialogue = {"Selected\nAct 2."}
    elseif command == "行动 3" then
        currentdialogue = {"Selected\nAct 3."}
    end
    BattleDialog({"你选择了 " .. command .. "。"})
end