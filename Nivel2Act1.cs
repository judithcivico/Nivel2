using System;

public class Cafetera(){
	public double capacidadMaxima = 1000;
	public double cantidadActual = 0;
	
public Constructor(double capacidadMaxima, double cantidadActual) {
	this.capacidadMaxima = capacidadMaxima;
	this.cantidadActual =  cantidadActual;
	llenarCafetera();
	servirTaza();
	vaciarcafetera();
	agregarCafe();
	
	private double capacidadMaxima {
		get { return capacidadMaxima; }
		set { capacidadMaxima = value; }
	}
	
	private double cantidadActual {
		get { return cantidadActual; }
		set { cantidadActual = value; }
	}
}
public llenarCafetera() {
	 this.cantidadActual = capacidadMaxima;
}
public servirTaza() {
	int llenarTaza;
	if(llenarTaza > this.cantidadActual) {
		Console.WriteLine("¡Recarga la cafetera! ");
	} else {
		this.cantidadActual -= llenarTaza;
}
}
public vaciarcafetera() {
	this.cantidadActual = 0;
}
public agregarCafe() {
	int rellenar;
	this.cantidadActual =  rellenar;
}
public mostrar() {
	Console.WriteLine("Capacidad máxima: " + this.capacidadMaxima);
	Console.WriteLine("Cantidad actual: " + this.cantidadActual);
}
}