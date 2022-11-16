using System;

public class Producto() {
	private String nombreProducto = "";
	private int numLote = 0;
	
public Constructor(String nombreProducto, int numLote) {
	this.nombreProducto = nombreProducto;
	this.numLote =  numLote;
	
	private String nombreProducto {
		get { return nombreProducto; }
		set { nombreProducto = value; }
	}
	
	private int numLote {
		get { return numLote; }
		set { numLote = value; }
	}
}
public mostrar() {
	Console.WriteLine("Nombre: " + this.nombreProducto);
	Console.WriteLine("Numero de lote: " + this.numLote);
}
}

public class ProductoFresco : Producto {
	private String fechaEnvasado;
	private String paisOrigen;
	
public Constructor(String fechaEnvasado, String paisOrigen) {
	this.fechaEnvasado = fechaEnvasado;
	this.paisOrigen = paisOrigen;
	
	private String fechaEnvasado { 
		get { return fechaEnvasado; }
		set { fechaEnvasado = value; }
	}
	
	private String paisOrigen { 
		get { return paisOrigen; }
		set { paisOrigen = value; }
	}
}	
public mostrar() {
	Console.WriteLine("Fecha envasado: " + this.fechaEnvasado);
	Console.WriteLine("Pais de origen: " + this.paisOrigen);
}
}

public class ProductoRefrigerado : Producto {
	private int codigo;
	
public Constructor(int codigo) {
	this.codigo = codigo;
	
	private int codigo {
		get { return codigo; }
		set { codigo = value; }
	}
}
public mostrar() {
	Console.WriteLine("Codigo: " + this.codigo);
}
}

public class ProductoCongelado : Producto {
	private double temperatura;
	
public Constructor(double temperatura) {
	this.temperatura;
	
	private double temperatura {
		get { return temperatura }
		set { temperatura = value }
	}
}
public mostrar() {
	Console.WriteLine("Temperatura: " + this.temperatura);
}
}