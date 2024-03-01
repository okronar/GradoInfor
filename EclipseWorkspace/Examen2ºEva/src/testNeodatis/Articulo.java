package testNeodatis;

public class Articulo {
	
	private String fecha,tipo,producto;
	private int cantidad;
	private double precio;
	private double costeTotal;
public Articulo() {
	
	
}

public String getFecha() {
	return fecha;
}

public void setFecha(String fecha) {
	this.fecha = fecha;
}

public String getTipo() {
	return tipo;
}

public void setTipo(String tipo) {
	this.tipo = tipo;
}

public String getProducto() {
	return producto;
}

public void setProducto(String producto) {
	this.producto = producto;
}

public double getPrecio() {
	return precio;
}

public void setPrecio(double precio) {
	this.precio = precio;
}

public int getCantidad() {
	return cantidad;
}

public void setCantidad(int cantidad) {
	this.cantidad = cantidad;
}


public void setCosteTotal(double precio,int cantidad) {
	this.costeTotal = precio * cantidad;
	
}
public double getCosteTotal()
{
return costeTotal;	
}

}
