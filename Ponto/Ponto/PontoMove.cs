namespace Ponto
{
    public class PontoMove : Ponto
    {
        public PontoMove(float x, float y) : base(x, y)
        {
        }

        public void Move(float x, float y)
        {
            X += x;
            Y += y;
        }
    }
}
