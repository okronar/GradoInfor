package testNeodatis;

public class LineaPedido {
	
private String numeroPedido;
private String codigo;
private int cantidad;

public LineaPedido(String numeroPedido, String codigo, int cantidad) {
	
	this.numeroPedido = numeroPedido;
	this.codigo = codigo;
	this.cantidad = cantidad;
	
}
public String getNumeroPedido() {
	return numeroPedido;
}
public String getCodigo() {
	return codigo;
}
public int getCantidad() {
	return cantidad;
}


}
