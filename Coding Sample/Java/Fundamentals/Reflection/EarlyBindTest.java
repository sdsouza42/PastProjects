import finance.*;

class EarlyBindTest{

	public static void main(String[] args) throws Exception{
		double p = Double.parseDouble(args[0]);
		Class<?> c = Class.forName(args[1]);
		LoanPolicy pol = (LoanPolicy)c.newInstance();
		int m = 10;
		for(int n = 1; n <= m; ++n){
			float r = pol.interestRate(p, n);
			double emi;
			emi = p * Math.pow(1 + r / 100, n) / (12 * n);
			System.out.printf("%d\t%.2f%n", n, emi);
		}
	}
}

