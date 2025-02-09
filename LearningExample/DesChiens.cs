public class DesChiens
{

    public void TestCode() {
        DesChiens group = new DesChiens();
        group.AddChien(new UnChien("Didier"));
        group.AddChien(new UnChien("Marsell"));
        group.AddChien(new UnChien("Medor"));
        group.AddChien(new UnChien("Didi"));
        group.MakeChiensWouff();
        group.Clear();
        group.MakeChiensWouff();
    }

    private List<UnChien> m_meute = new List<UnChien>();
    public void AddChien(UnChien chien)
    {
        m_meute.Add(chien);
    }
    public void MakeChiensWouff()
    {
        if (m_meute.Count == 0)
        {
            Console.WriteLine("No dog");
        }
        else
        {

            foreach (UnChien c in m_meute)
                c.WoufName();
        }
    }

    public void Clear()
    {
        m_meute.Clear();
    }
}
