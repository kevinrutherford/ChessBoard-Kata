Given /^the game has just started$/ do
  @first_move = true
end

Given /^the game has not just started$/ do
  @first_move = false
end

Given /^I have a White [pP]awn at (\w)(\d)$/ do |col,row|
  @pawn = Position.new(col,row)
end

Given /^the Pawn is on (\w)(\d)$/ do |col,row|
  @pawn = Position.new(col,row)
end

Given /^the Knight is at (\w)(\d)$/ do |col,row|
  @knight = Position.new(col,row)
end

Given /^I have a Black [kK]night at (\w)(\d)$/ do |col,row|
  @knight = Position.new(col,row)
end

Given /^the valid moves are (\w)(\d)$/ do |col,row|
  @valid_moves = [Position.new(col,row)]
end

Given /^the valid moves are$/ do |table|
  @valid_moves = table.rows.flatten.map { |move| Position.from(move) }
end

When /^I move the Pawn to (\w)(\d)$/ do |col, row|
  dest = Position.new(col,row)
  if @valid_moves and !@valid_moves.include?(dest)
    @message = "illegal move"
  elsif dest.illegal?
    @message = "Illegal move"
  elsif (row.to_i - @pawn.row > 1) and ((@pawn.row != 2) or !@first_move)
    @message = "Pawn cannot move 2 spaces unless it in the first round and is on the home row."
  elsif dest.diagonally_ahead_of?(@pawn)
    if @knight == dest
      @pawn = dest
      @knight = nil
      @message = "Pawn takes Knight. Pawn wins"
    else
      @message = "Pawn cannot diagonally unless it is capturing a piece."
    end
  elsif dest == @knight
    @message = "Pawn collides with Knight. Draw"
  else
    @pawn = dest
    @message = "Pawn to #{dest}"
  end
  @first_move = false
end

When /^the [pP]awn moves to (\w)(\d)$/ do |col,row|
  When "I move the Pawn to #{col}#{row}"
end

When /^I move the [kK]night to (\w)(\d)$/ do |col, row|
  dest = Position.new(col,row)
  if @valid_moves and !@valid_moves.include?(dest)
    @message = "Illegal Move"
  elsif col[0] > 'H'[0]
    @message = "Illegal move"
  elsif dest == @pawn
    @pawn = nil
    @message = "Knight takes Pawn. Knight Wins"
  else
    @knight = Position.new(col,row)
    @message = "Knight to #{dest}"
  end
  @first_move = false
end

Then /^I should be shown "([^"]*)"$/ do |msg|
  @message.should == msg
end

Then /^Pawn should be at (\w)(\d)$/ do |col,row|
  @pawn.should == Position.new(col,row)
end

Then /^the pawn should be at (\w)(\d)$/ do |col,row|
  @pawn.should == Position.new(col,row)
end

Then /^the [kK]night should be at (\w)(\d)$/ do |col,row|
  @knight.should == Position.new(col,row)
end

Then /^I should be warned of an illegal move message$/ do
  @message.should == "Illegal move"
end

Then /^the knight should be taken$/ do
  @knight.should be_nil
end

Then /^the pawn should be taken$/ do
  @pawn.should be_nil
end
