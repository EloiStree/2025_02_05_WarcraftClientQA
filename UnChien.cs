public class UnChien
{
    public string m_monNom = "Medor";
    public string m_address = "";
    public UnChien(string monNom)
    {
        m_monNom = monNom;
    }
    public void WoufName()
    {
        Console.WriteLine("Wouff " + m_monNom);
    }
}
