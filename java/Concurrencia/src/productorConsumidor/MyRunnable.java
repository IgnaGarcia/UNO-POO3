package productorConsumidor;

public abstract class MyRunnable implements Runnable {
	protected Buffer buf = null;
	protected int id;

	public MyRunnable(Buffer buf, int id) {
		this.buf = buf;
		this.id = id;
	}
	
	public String toString() {
		return id + "; Buffer: " + buf;
	}

	public abstract void run();
}
