Given /^the game has just started$/ do
end

Given /^I have a White [pP]awn at (\w)(\d)$/ do |col,row|
  @pawn = [col,row]
end

Given /^the Pawn is on (\w)(\d)$/ do |col,row|
  @pawn = [col,row]
end

Given /^the Knight is at (\w)(\d)$/ do |col,row|
  @knight = [col,row]
end

Given /^I have a Black [kK]night at (\w)(\d)$/ do |col,row|
  @knight = [col,row]
end

When /^I move the Pawn to (\w)(\d)$/ do |col, row|
  @pawn = [col,row]
end
