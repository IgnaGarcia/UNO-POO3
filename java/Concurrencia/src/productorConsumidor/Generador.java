package productorConsumidor;

/*
 * 
 * producto es vector 
 * productores generan vectores al azar
 * consumidor ordena el vector y lo mete en el buffer 2
 * impresor imprime el vector ordenado
 * 
 */
public class Generador extends MyRunnable {
	
	public Generador(Buffer buf, int id) {
		super(buf, id);
	}

	@Override
	public void run() {
		double[] item = new double[App.PROD_TAM];

		while (true) {
			try {
				Thread.sleep(400);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			
			long startMillis = System.currentTimeMillis();
			
			for(int i = 0; i < App.PROD_TAM; i++) {
				item[i] = Math.random()*100;
			}
			buf.put(item);
			
			long time = System.currentTimeMillis() - startMillis;
			System.out.println(this + "; Tiempo: " + time);
		}
	}

	@Override
	public String toString() {
		return super.toString() +  " Creando";
	}
}
