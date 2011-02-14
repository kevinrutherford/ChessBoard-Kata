Given /^the game has just started$/ do
  @first_move = true
end

Given /^the game has not just started$/ do
  @first_move = false
end

Given /^I have a White [pP]awn at (\w)(\d)$/ do |col,row|
  @pawn = [col,row.to_i]
end

Given /^the Pawn is on (\w)(\d)$/ do |col,row|
  @pawn = [col,row.to_i]
end

Given /^the Knight is at (\w)(\d)$/ do |col,row|
  @knight = [col,row]
end

Given /^I have a Black [kK]night at (\w)(\d)$/ do |col,row|
  @knight = [col,row]
end

Given /^the valid moves are (\w)(\d)$/ do |col,row|
end

When /^I move the Pawn to (\w)(\d)$/ do |col, row|
  if row.to_i > 8
    @message = "Illegal move"
  elsif (row.to_i - @pawn[1] > 1) and ((@pawn[1] != 2) or !@first_move)
    @message = "Pawn cannot move 2 spaces unless it in the first round and is on the home row."
  elsif
    @pawn = [col,row.to_i]
    @message = "Pawn to #{col}#{row}"
  end
  @first_move = false
end

When /^the [pP]awn moves to (\w)(\d)$/ do |col,row|
  When "I move the Pawn to #{col}#{row}"
end

When /^I move the [kK]night to (\w)(\d)$/ do |col, row|
  if col[0] > 'H'[0]
    @message = "Illegal move"
  else
    @knight = [col,row.to_i]
    @message = "Knight to #{col}#{row}"
  end
  @first_move = false
end

Then /^I should be shown "([^"]*)"$/ do |msg|
  @message.should == msg
end

Then /^.{0,4}?[pP]awn should be at (\w)(\d)$/ do |col,row|
  @pawn.should == [col,row.to_i]
end

Then /^the [kK]night should be at (\w)(\d)$/ do |col,row|
  @knight.should == [col,row.to_i]
end

Then /^I should be warned of an illegal move message$/ do
  @message.should == "Illegal move"
end

