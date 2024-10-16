namespace pratik_ilksınıf
{
    public class Person
    {
        private string name = string.Empty;
        private string surname = string.Empty;
        private DateTime birthDate;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public void IsimYazdir()
        {

            Console.WriteLine($"Ad : {name} ");
        }
        public void SoyadYazdir()
        {

            Console.WriteLine($"Soyad : {surname} ");
        }
        public void DogumTarihi()
        {
            Console.WriteLine($"Doğum Tarihi  : {birthDate} ");
        }
    }
}