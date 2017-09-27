namespace OperatorenÜberladen
{
    internal struct Bruchzahl
    {
        public int Zähler { get; }
        public int Nenner { get; }

        public Bruchzahl(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }

        public static bool operator ==(Bruchzahl left, Bruchzahl right)
        {
            return (left.Zähler / left.Nenner) == (right.Zähler / right.Nenner);
        }
        public static bool operator !=(Bruchzahl left, Bruchzahl right)
        {
            return !(left == right);
        }

        public static Bruchzahl operator *(Bruchzahl left, Bruchzahl right)
        {
            return new Bruchzahl(
                zähler: left.Zähler * right.Zähler,
                nenner: left.Nenner * right.Nenner);
        }
        public static Bruchzahl operator *(int left, Bruchzahl right)
        {
            return right * left;
        }
        public static Bruchzahl operator *(Bruchzahl left, int right)
        {
            return new Bruchzahl(
                zähler: left.Zähler * right,
                nenner: left.Nenner);
        }

        public int GGTeiler(int z1, int z2)
        {
            if (z2 == 0)
                return z1;
            else
                return GGTeiler(z2, z1 % z2);
        }

        public override string ToString()
        {
            return $"{Zähler}/{Nenner}";
        }
        public override bool Equals(object obj)
        {
            if (typeof(Bruchzahl) != obj.GetType())
                return false;

            var value = (Bruchzahl)obj;
            return this == value;
        }

        public override int GetHashCode()
        {
            var hashCode = 1279289283;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Zähler.GetHashCode();
            hashCode = hashCode * -1521134295 + Nenner.GetHashCode();
            return hashCode;
        }
    }
}
