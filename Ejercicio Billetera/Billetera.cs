namespace Billetera
{
	public class Billetera
	{
		// PASO 1: DECLARAMOS LAS PROPIEDADES
		public int BilletesDe10 { get; set; }
		public int BilletesDe20 { get; set; }
		public int BilletesDe50 { get; set; }
		public int BilletesDe100 { get; set; }
		public int BilletesDe200 { get; set; }
		public int BilletesDe500 { get; set; }
		public int BilletesDe1000 { get; set; }

		// PASO 2: Agregamos un método/funcion que se llame Total del tipo decimal, 
		// y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.
		public decimal Total
		{
			get
      {
        var total =
						BilletesDe10 * 10m +
							BilletesDe20 * 20m +
						BilletesDe50 * 50m +
						BilletesDe100 * 100m +
						BilletesDe200 * 200m +
						BilletesDe500 * 5000m +
						BilletesDe1000 * 1000m;

						// El return devolvera el importe total en la billetera
						return total;
      }
		}


// PASO 3: Agregamos un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera
		public Billetera Combinar(Billetera billetera2)
		{
			var nueva = new Billetera();

			// COMBINAMOS
			nueva.BilletesDe10 = BilletesDe10 + billetera2.BilletesDe10;
			nueva.BilletesDe20 = BilletesDe20 + billetera2.BilletesDe20;
			nueva.BilletesDe50 = BilletesDe50 + billetera2.BilletesDe50;
			nueva.BilletesDe100 = BilletesDe100 + billetera2.BilletesDe100;
			nueva.BilletesDe200 = BilletesDe200 + billetera2.BilletesDe200;
			nueva.BilletesDe500 = BilletesDe500 + billetera2.BilletesDe500;
			nueva.BilletesDe1000 = BilletesDe1000 + billetera2.BilletesDe1000;

			// VACIAMOS LA PRIMER BILLETERA
			BilletesDe10 = 0;
			BilletesDe20 = 0;
			BilletesDe50 = 0;
			BilletesDe100 = 0;
			BilletesDe200 = 0;
			BilletesDe500 = 0;
			BilletesDe1000 = 0;

			// VACIAMOS LA SEGUNDA BILLETERA
			billetera2.BilletesDe10 = 0;
			billetera2.BilletesDe20 = 0;
			billetera2.BilletesDe50 = 0;
			billetera2.BilletesDe100 = 0;
			billetera2.BilletesDe200 = 0;
			billetera2.BilletesDe500 = 0;
			billetera2.BilletesDe1000 = 0;

			//Devolvemos una nueva billetera  
			return nueva;
		}
	}
}