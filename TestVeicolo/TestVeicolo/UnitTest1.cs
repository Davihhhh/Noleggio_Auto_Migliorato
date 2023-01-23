namespace TestVeicolo
{
    public class TestVeicolo
    {        
        [Fact]
        public void TestCostruttori()
        {
            Veicolo veicolo1 = new Veicolo();
            Veicolo veicolo2 = new Veicolo("marca", "modello", 100, 222, 121);
            Veicolo veicolo3 = new Veicolo("marca", "modello", "cond", 100, 222, 121, 2342, false);
            Assert.True(veicolo1 != null);
            Assert.True(veicolo2 != null);
            Assert.True(veicolo3 != null);
        }

        [Fact]
        public void TestTarga()
        {
            Veicolo v1 = new Veicolo();
            Veicolo v2 = new Veicolo();
            Assert.NotEqual(v1.Targa, v2.Targa);
        }
        [Fact]
        public void TestToString()
        {
            Veicolo veicolo3 = new Veicolo("marca", "modello", "cond", 100, 222, 121, 2342, false);
            string str = veicolo3.ToString();
            Assert.True(str == veicolo3.Targa + ";marca;modello;cond;100;222;121;2342");
        }
        [Fact]
        public void TestNoleggia()
        {
            Veicolo veicolo = new Veicolo("marca", "modello", "cond", 100, 222, 121, 2342, false);
            Veicolo veicolo2 = new Veicolo("marca", "modello", 100, 222, 121);
            Assert.True(veicolo.GetStatoNoleggio());
            Assert.False(veicolo2.GetStatoNoleggio());
        }
        [Fact]
        public void TestRestituzione()
        {
            Veicolo veicolo = new Veicolo("marca", "modello", "cond", 100, 222, 121, 2342, false);
            Veicolo veicolo2 = new Veicolo("marca", "modello", 100, 222, 121);
            double costo = veicolo.Restituisci();
            Assert.False(veicolo.GetStatoNoleggio());
            Assert.False(veicolo2.GetStatoNoleggio());
        }

    }
}