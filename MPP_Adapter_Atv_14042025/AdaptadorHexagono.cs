public class AdaptadorHexagono: Poligono
	{
		private HexagonoEstrangeiro hexagonoEstrangeiro;
		public AdaptadorHexagono()
		{
		}
		public HexagonoEstrangeiro getHexagonoEstrangeiro()
		{
			return hexagonoEstrangeiro;
		}
		public void setHexagonoEstrangeiro(HexagonoEstrangeiro hex)
		{
			hexagonoEstrangeiro = hex;
		}
		public override double getArea()
		{
			return hexagonoEstrangeiro.calculaArea();
		}
 
	}