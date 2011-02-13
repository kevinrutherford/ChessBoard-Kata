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
  @message = "Pawn to #{col}#{row}"
end

When /^the [pP]awn moves to (\w)(\d)$/ do |col,row|
  When "I move the Pawn to #{col}#{row}"
end

When /^I move the [kK]night to (\w)(\d)$/ do |col, row|
  @knight = [col,row]
  @message = "Knight to #{col}#{row}"
end

Then /^I should be shown "([^"]*)"$/ do |msg|
  @message.should == msg
end

