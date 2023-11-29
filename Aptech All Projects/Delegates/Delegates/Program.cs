
using Delegates;

Calculate calculations = new Calculate();

calculate doesAdd = new calculate(calculations.add);
calculate doesSub = new calculate(calculations.sub);
calculate doesDivide = new calculate(calculations.divide);

doesAdd(1, 1);
doesSub(1, 1);
doesDivide(1, 1);




