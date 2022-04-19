namespace Hw3
{
    class CatHouse
    {
        public int CatCount { get; set; }
        public string Name { get; set; }
        public Cat[] cats;

        public CatHouse(string name, Cat[] cats, int catCount)
        {
            Name = name;
            CatCount = catCount;
            this.cats = new Cat[CatCount];
            for (int i = 0; i < CatCount; i++)
            {
                this.cats[i] = cats[i];
            }
        }

        public void AddCat(Cat cat)
        {
            CatCount += 1;
            Cat[] newCat = new Cat[CatCount];

            for (int i = 0; i < CatCount - 1; i++)
            {
                newCat[i] = cats[i];
            }
            newCat[CatCount - 1] = cat;
            cats = newCat;

        }

        public void AllCatsInHouse()
        {
            for (int i = 0; i < CatCount; i++)
            {
                //Console.WriteLine(
                //   $"Nickname: {cats[i].Nickname}\n" +
                //   $"Age: {cats[i].Age}\n" +
                //   $"Gender: {cats[i].Gender}\n" +
                //   $"Price: {cats[i].Price}\n"
                //   );
                cats[i].Show();
            }
        }

        public void RemoveByNickname(string name)
        {
            Cat[] newArr = new Cat[CatCount - 1];
            for (int i = 0, j = 0; i < CatCount; i++)
            {
                if (cats[i].Nickname != name)
                {
                    newArr[j] = cats[i];
                    j++;
                }
            }
            CatCount -= 1;
            cats = newArr;
        }
    }
}
