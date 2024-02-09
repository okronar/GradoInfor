package testNeodatis;

public class Pedido {
	
	private String numeroCliente;
	private String numeroPedido;
	private String fecha;
	
public Pedido(String numeroCliente, String numeroPedido, String fecha) {
	this.numeroCliente = numeroCliente;
	this.numeroPedido = numeroPedido;
	this.fecha = fecha;
	
}
public String getNumeroCliente() {
	return numeroCliente;
}
public String getNumeroPedido() {
	return numeroPedido;
}
public String getFecha() {
	return fecha;
}

}
