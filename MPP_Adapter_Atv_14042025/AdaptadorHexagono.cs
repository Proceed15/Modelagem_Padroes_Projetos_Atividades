public class AdaptadorHexagono: Poligono
	{
		private HexagonoEstrangeiro hexagonoEstrangeiro;
		//required not needed because class only returns if it has a value
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        //required also not valid in this line
		public AdaptadorHexagono()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
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
		public override string getName()
        {
            return "Hexágono";
        }
	}