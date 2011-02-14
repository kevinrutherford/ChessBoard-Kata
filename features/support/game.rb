class Position

  ACHR = 'A'[0]

  attr_reader :row, :col

  def initialize(col,row)
    @col = (col.upcase)[0] - ACHR
    @row = row.to_i
  end

  def illegal?
    @row > 8
  end

  def diagonally_ahead_of?(other)
    return false unless @row == other.row+1
    col_diff = @col - other.col
    [-1,1].include?(col_diff)
  end

  def to_s
    "#{(@col + ACHR).chr}#{@row}"
  end

  def ==(other)
    @col == other.col && @row == other.row
  end
end
