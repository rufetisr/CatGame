namespace Hw3
{
    class PetShop
    {
        public CatHouse[] catHouses = new CatHouse[5];

        public PetShop(CatHouse[] catHouses, int catHouseCount)
        {
            this.catHouses = catHouses;
            CatHouseCount = catHouseCount;
        }

        public int CatHouseCount { get; set; }

        public void AllCatsInPetShop()
        {
            for (int i = 0; i < CatHouseCount; i++)
            {
                catHouses[i].AllCatsInHouse();
            }
        }
    }
}
