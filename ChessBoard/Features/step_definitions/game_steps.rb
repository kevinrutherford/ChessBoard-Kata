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
  if row.to_i > 8
    @message = "Illegal move"
  else
    @pawn = [col,row]
    @message = "Pawn to #{col}#{row}"
  end
end

When /^the [pP]awn moves to (\w)(\d)$/ do |col,row|
  When "I move the Pawn to #{col}#{row}"
end

When /^I move the [kK]night to (\w)(\d)$/ do |col, row|
  if col[0] > 'H'[0]
    @message = "Illegal move"
  else
    @knight = [col,row]
    @message = "Knight to #{col}#{row}"
  end
end

Then /^I should be shown "([^"]*)"$/ do |msg|
  @message.should == msg
end

Then /^.{0,4}?[pP]awn should be at (\w)(\d)$/ do |col,row|
  @pawn.should == [col,row]
end

Then /^the [kK]night should be at (\w)(\d)$/ do |col,row|
  @knight.should == [col,row]
end

Then /^I should be warned of an illegal move message$/ do
  @message.should == "Illegal move"
end

