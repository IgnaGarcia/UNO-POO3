package waitNotify;

public class VariableIncDec {
	public static void main(String[] args) {
		int o2 = -5, cant1 = 0, cant0 = 0;
		Monitor miMonitor = new Monitor(1000);
		new HiloSumador(miMonitor).start();
		new HiloRestador(miMonitor).start();
		new HiloRestador(miMonitor).start();
		new HiloRestador(miMonitor).start();

		new HiloSumador(miMonitor).start();
		new HiloSumador(miMonitor).start();
		new HiloSumador(miMonitor).start();
		new HiloSumador(miMonitor).start();
		new HiloSumador(miMonitor).start();
		new HiloSumador(miMonitor).start();

		for (;;) {
			int o1 = miMonitor.valor();
			if (o1 != o2)
				System.out.println(o1);
			o2 = o1;
			if (o1 == 1)
				cant1++;
			if (o2 == 0)
				cant0++;
			if (cant1 > 1000)
				System.out.println(
						"cant1=" + new Integer(cant1).toString() + "   cant0=" + new Integer(cant0).toString());
		}
	}
}
