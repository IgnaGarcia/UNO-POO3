package productorConsumidor;

import java.util.Arrays;

public class Ordenador extends MyRunnable {
	private Buffer bufTo;
	
	public Ordenador(Buffer buf, int id, Buffer bufTo) {
		super(buf, id);
		this.bufTo = bufTo;
	}

	@Override
	public void run() {
		double[] item;

		while (true) {
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			
			long startMillis = System.currentTimeMillis();

			item = buf.pop();
			Arrays.sort(item);
			bufTo.put(item);

			long time = System.currentTimeMillis() - startMillis;
			System.err.println(this + "; Tiempo: " + time);
		}
	}

	@Override
	public String toString() {
		return super.toString() + "; 2doBuffer: " + bufTo +  " Ordenando";
	}
}
