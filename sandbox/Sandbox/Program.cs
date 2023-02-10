class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.SetLhsRhs(10, 1);
        divider.DisplayResult();

        divider.SetLhsRhs(0, 100);
        divider.DisplayResult();

        divider.SetLhsRhs(5, 0);
        divider.DisplayResult();

        divider.SetLhsRhs(25, 5);
        divider.DisplayResult();


    }
}

class IntegerDivision {
    private int _lhs = 1;
    private int _rhs = 1;

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
    }

    public int Result()
    {
        int result = _lhs / _rhs;
        return result;
    }
    public void SetLhsRhs(int lhs, int rhs)
    {
        _lhs = lhs;
        if(rhs == 0)
        {
            Console.WriteLine("You cannot divide by zero.");
            _rhs = 1;
            _lhs = 1;
        }

        else
        {
            _rhs = rhs;
        }
        
    }

}
