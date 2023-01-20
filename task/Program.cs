namespace task
{
    /// <summary>
    ///                     Decorator                                                 /// Decorator
    ///     Спроектируйте систему профессий для RPG игры. Профессия в                 /// Design a profession system for an RPG game. Profession in
    /// игре - это аналог игровых уровней. После получения каждой                     /// game - this is an analogue of game levels. After receiving each
    /// следующей профессии персонаж пользователя приобретает                         /// of the next profession, the user's character acquires
    /// (усовершенствует) свои характеристики.                                        /// (improve) its characteristics.
    ///     Например:                                                                 ///     For example:
    ///     Человек воин имеет скорость перемещения 30 единиц, но после               /// Human warrior has a movement speed of 30 units, but after
    /// получения профессии «лучник» на его скорость влияет модификатор               /// getting the profession "archer" modifier affects his speed
    /// +20. Если бы он стал не лучником, а меченосцем, то его модификатор            /// +20. If he became not an archer, but a swordsman, then his modifier
    /// скорости был бы меньше на 10 единиц по сравнению с человеком                  /// speed would be less than 10 units compared to a person
    /// воином.                                                                       /// warrior.
    ///                 Описания всех профессий                                       /// Descriptions of all professions
    ///  ------------------------------------------------------------------------     ///  -----------------------------------------------------------------------
    /// | Название      |  Родительская  |______________Модификаторы_____________|    /// | Title         | Parent         |______________Modifiers_______________|
    /// | профессии     |  профессия     |  Атака | Скорость | Здоровье | Защита |    /// | professions   | profession     | Attack | Speed | Health | Protection |
    /// | --------------|----------------|--------|----------|----------|--------|    /// | --------------|----------------|--------|-------|--------|------------|
    /// | Человек       |  нет           |  +20   | +20      | +150     | +0     |    /// | Man           | no             | +20    | +20   | +150   | +0         |
    /// | Человек воин  |  человек       |  +20   | +10      | +50      | +20    |    /// | Man warrior   | man            | +20    | +10   | +50    | +20        |
    /// | Меченосец     |  Человек воин  |  +40   | -10      | +50      | +40    |    /// | Sword-bearer  | Man warrior    | +40    | -10   | +50    | +40        |
    /// | Лучник        |  Человек воин  |  +20   | +20      | +50      | +10    |    /// | Archer        | Man warrior    | +20    | +20   | +50    | +10        |
    /// | Всадник       |  Меченосец     |  -10   | +40      | +200     | +100   |    /// | Rider         | Sword-bearer   | -10    | +40   | +200   | +100       |
    /// | Эльф          |  нет           |  +15   | +30      | +100     | +0     |    /// | Elf           | no             | +15    | +30   | +100   | +0         |
    /// | Эльф воин     |  Эльф          |  +20   | -10      | +100     | +20    |    /// | Elf warrior   | Elf            | +20    | -10   | +100   | +20        |
    /// | Эльф маг      |  Эльф          |  +10   | +10      | -50      | +10    |    /// | Elf mage      | Elf            | +10    | +10   | -50    | +10        |
    /// | Арбалетчик    |  Эльф воин     |  +20   | +10      | +50      | -10    |    /// | Crossbowman   | Elf warrior    | +20    | +10   | +50    | -10        |
    /// | Злой маг      |  Эльф маг      |  +70   | +20      | +0       | +0     |    /// | Evil mage     | Elf mage       | +70    | +20   | +0     | +0         |
    /// | Добрый маг    |  Эльф маг      |  +50   | +30      | +100     | +30    |    /// | Good mage     | Elf mage       | +50    | +30   | +100   | +30        |
    ///  ------------------------------------------------------------------------     ///  -----------------------------------------------------------------------
    ///                                                                               ///
    ///     Необходимо спроектировать архитектуру этого приложения,                   /// It is necessary to design the architecture of this application,
    /// используя паттерн «Decorator». В этом случае при перемещении                  /// using the "Decorator" pattern. In this case, when moving
    /// персонажа будут вызываться методы Move из всех внутренних                     /// the character's Move methods will be called from all internal
    /// объектов и к «0» будет применяться модификатор скорости.                      /// objects and "0" will have the speed modifier applied.
    ///  
    /// </summary>

    // Паттерн Decorator динамически добавляет объекту новые обязанности. 
    // Является гибкой альтернативой порождению подклассов с целью расширения функциональности.
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

        }
    }

    public class UnitType
    {
        public string Name { get; private set; }
        public UnitType Base { get; private set; }
        public IReadOnlyDictionary<int, UnitType> UpgradesTo { get; private set; }
        public int Attack { get; private set; }
        public int Speed { get; private set; }
        public int Health { get; private set; }
        public int Defence { get; private set; }

        public UnitType(string name, UnitType @base, int attack, int speed, int health, int defence, IReadOnlyDictionary<int, UnitType> upgradesTo)
        {
            Name = name;
            Base = @base;
            Attack = attack;
            Speed = speed;
            Health = health;
            Defence = defence;
            UpgradesTo = upgradesTo;
        }
    }
}