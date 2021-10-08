package productorConsumidor;

import java.util.Arrays;

public class Impresor extends MyRunnable{

	public Impresor(Buffer buf, int id) {
		super(buf, id);
	}

	@Override
	public void run() {
		double[] item;

		while (true) {
			try {
				Thread.sleep(600);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			
			long startMillis = System.currentTimeMillis();

			item = buf.pop();
			System.out.println(Arrays.toString(item));

			long time = System.currentTimeMillis() - startMillis;
			System.out.println(this + "; Tiempo: " + time);
		}
	}

	@Override
	public String toString() {
		return super.toString() +  " Imprimiendo";
	}
}
