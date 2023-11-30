/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import excepciones.MyException;
import interfazGUI.VentanaListado;

/**
 *
 * @author Sergio
 */
public class Mercancia extends Almacen {

    private String descripcion;
    private float precio;

    public Mercancia(String codigo, String descripcion, int cantidad, float precio) {
        super(codigo, cantidad);
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public Mercancia(String descripcion, float precio) {
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public float getPrecio() {
        return precio;
    }

    public Mercancia() {
    }

    public String[] toArray() {
        String[] datos = new String[VentanaListado.CABECERA.length];
        datos[0] = getCodigo();
        datos[1] = getDescripcion();
        datos[2] = getCantidad() + "";
        datos[3] = getPrecio() + "";
        return datos;
    }

    @Override
    public String toString() {

        return String.format("%s  %s  %d  %f",
                getCodigo(), getDescripcion(), getCantidad(), getPrecio());
    }

}
