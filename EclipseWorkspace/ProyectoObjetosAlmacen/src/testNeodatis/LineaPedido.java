package testNeodatis;

public class LineaPedido {
	
private String numeroPedido;
private String codigo;
private String cantidad;

public LineaPedido(String numeroPedido, String codigo, String cantidad) {
	
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
public String getCantidad() {
	return cantidad;
}


}
