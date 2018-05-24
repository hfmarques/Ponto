namespace Ponto
{
    public class PontoReflete : Ponto
    {
        public PontoReflete(float x, float y) : base(x, y)
        {
        }

        public void Reflete()
        {
            X = X * -1;
            Y = Y * -1;
        }
    }
}
