using System;

// C#
const float IVA = 21;

// Tienda - Precios
float precioRemera = 320.0F;
float precioPantalon = 560.0F;

// Cliente compra
int cantidadRemeras = 15;
int cantidadPantalones = 5;

// Subtotales
float subtotalRemera = precioRemera * cantidadRemeras;
float subtotalPantalon = precioPantalon * cantidadPantalones;
float subtotal = subtotalRemera + subtotalPantalon;
float total = (subtotal * IVA/100) + subtotal;

// Facturacion
char facturaTipo = 'C';
Console.WriteLine($"---------------------    Factura tipo: {facturaTipo}    ---------------------");
Console.WriteLine($"Detalle     ---  Precio  ---  Cantidad   ---   Subtotal");
Console.WriteLine($"Remeras     ---  {precioRemera}     ---  {cantidadRemeras}          ---   {subtotalRemera}");
Console.WriteLine($"Pantalones  ---  {precioPantalon}     ---  {cantidadPantalones}          ---   {subtotalPantalon}");
Console.WriteLine($"-----------------------------------------------------------------");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Iva: {IVA}%");
Console.WriteLine($"Total: {total}");