# Convert base X to base 10

Write a program that will convert a number in any base from base 2 through base 16, represented as a string (e.g. '102012'), to its decimal equivalent.

For any invalid input the program should return 0.

The algorithm should output an int.

###_Mathematics_

A whole number is represented as a string of symbols. The symbol, its position in the string and the number of symbols available (the base) combine to give the string a value.

####Base

The number of symbols is defined by the "base" of the number.

Base 10 (decimal) numbers have 10 symbols: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9.

Base 16 (hexadecimal) numbers have 16 symbols: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F.

Base 2 (binary) numbers have 2 symbols: 0, 1.

####Position

The position of each symbol in the string represents a multiplier for the symbol in that position.

The value of each position is given as a power of the base. From right to left the power increases by one with each position. For a number of n positions the position value is as follows: b<sup>n</sup>+b<sup>n-1</sup>+...+b<sup>3</sup>+b<sup>2</sup>+b<sup>1</sup>+b<sup>0</sup>

For example, given the base 10 string "35", the symbol "3" is in the ten's position. Its value is 3×10<sup>1</sup>=30.  The "5" is in the one's position. Its value is 5×10<sup>0</sup>=5. The combined decimal value of all the symbols is (3×10<sup>1</sup>)+(5×10<sup>0</sup>)=35.

In a similar example, given the base 16 string "35", the symbol "3" is in the 16's position. Its value is 3×16<sup>1</sup>=48. The "5" is in the one's position. Its value is 5×16<sup>0</sup>=5. The combined decimal value of all the symbols is (3×16<sup>1</sup>)+(5×16<sup>0</sup>)=53.

####More Examples

"FAB" base 16 => <br />
<code>
	&nbsp;(15×16<sup>2</sup>)+(10×16<sup>1</sup>)+(11×16<sup>0</sup>)<br />
	=(15×256)+(10×16)+(11×1)<br />
	=4011
</code>

"100110" base 2 =><br />
<code>
	&nbsp;(1×2<sup>5</sup>)+(0×2<sup>4</sup>)+(0×2<sup>3</sup>)+(1×2<sup>2</sup>)+(1×2<sup>1</sup>)+(0×2<sup>0</sup>)<br />
	=(1×32)+(0×16)+(0×8)+(1×4)+(1×2)+(0×1)<br />
	=38
</code>

"1057" base 10 => <br />
<code>
	&nbsp;(1×10<sup>3</sup>)+(0×10<sup>2</sup>)+(5×10<sup>1</sup>)+(7×10<sup>0</sup>)<br />
	=(1×1000)+(0×100)+(5×10)+(7×1)<br />
	=1057
</code>


"221" base 3 =><br />
<code>
	&nbsp;(2×3<sup>2</sup>)+(2×3<sup>1</sup>)+(1×3<sup>0</sup>)<br />
	=(2×9)+(2×3)+(1×1)<br />
	=25
</code>
